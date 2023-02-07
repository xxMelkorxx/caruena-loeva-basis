using System;
using System.Windows.Forms;

namespace Caruena_Loeva_Basis
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Число отсчётов.
        /// </summary>
        private const int Length = 1000;

        /// <summary>
        /// Частота дискретизации.
        /// </summary>
        private const double Dt = 0.1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            OnClickButtonGenerateSgnl(null, EventArgs.Empty);
            OnClickButtonSolveSLE(null, EventArgs.Empty);
        }

        /// <summary>
        /// Кнопка генерации сигнала.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonGenerateSgnl(object sender, EventArgs e)
        {
            var correlationOrder = (int)numericUpDown_correlationOrder.Value;
            var numberEigenvector = (int)numericUpDown_eigenvectorNumber.Value;

            // Генерация сигнала
            double[] initSignal;
            switch (tabControl_sgnlParam.SelectedIndex)
            {
                case 0:
                    initSignal = Signals.GenerateHarmonicSignal(Length,
                        new[]
                        {
                            (double)numericUpDown_amplitude1.Value,
                            groupBox_harmonica2.Enabled ? (double)numericUpDown_amplitude2.Value : 0,
                            groupBox_harmonica3.Enabled ? (double)numericUpDown_amplitude3.Value : 0
                        },
                        new[]
                        {
                            (double)numericUpDown_frequency1.Value,
                            groupBox_harmonica2.Enabled ? (double)numericUpDown_frequency2.Value : 0,
                            groupBox_harmonica3.Enabled ? (double)numericUpDown_frequency2.Value : 0
                        },
                        new[]
                        {
                            (double)numericUpDown_phase1.Value,
                            groupBox_harmonica2.Enabled ? (double)numericUpDown_phase2.Value : 0,
                            groupBox_harmonica3.Enabled ? (double)numericUpDown_phase2.Value : 0
                        }, Dt);
                    break;
                case 1:
                    initSignal = Signals.GenerateGaussSignal(Length,
                        new[]
                        {
                            (double)numericUpDown_amplitudeGauss1.Value,
                            groupBox_dome2.Enabled ? (double)numericUpDown_amplitudeGauss2.Value : 0,
                            groupBox_dome3.Enabled ? (double)numericUpDown_amplitudeGauss3.Value : 0
                        },
                        new[]
                        {
                            (double)numericUpDown_sko1.Value,
                            groupBox_dome2.Enabled ? (double)numericUpDown_sko2.Value : 0,
                            groupBox_dome3.Enabled ? (double)numericUpDown_sko2.Value : 0
                        },
                        new[]
                        {
                            (double)numericUpDown_mathExpectation1.Value,
                            groupBox_dome2.Enabled ? (double)numericUpDown_mathExpectation2.Value : 0,
                            groupBox_dome3.Enabled ? (double)numericUpDown_mathExpectation2.Value : 0
                        }, Dt);
                    break;
                case 2:
                    initSignal = Signals.GenerateExponentialDecayingSignal(Length,
                        new[]
                        {
                            (double)numericUpDown_attenuation1.Value,
                            groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_attenuation2.Value,
                            groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_attenuation2.Value
                        },
                        new[]
                        {
                            (double)numericUpDown_frequencyED1.Value,
                            groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequencyED2.Value,
                            groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequencyED2.Value
                        },
                        new[]
                        {
                            (double)numericUpDown_phaseED1.Value,
                            groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_phaseED2.Value,
                            groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_phaseED2.Value
                        }, Dt);
                    break;
                default:
                    initSignal = new double[Length];
                    break;
            }

            // Вычисление АКМ сигнала.
            var autoCorrelationMatrix = Matrix.AutoCorrelationMatrix(initSignal, correlationOrder);
            
            // SVD-разложение АКМ сигнала.
            var matrixSing = Matrix.SVD(autoCorrelationMatrix, out var matrixU, out var matrixV);

            // Отрисовка графика исходного сигнала.
            chart_initSgnl.Series[0].Points.Clear();
            for (var i = 0; i < Length; i++)
                chart_initSgnl.Series[0].Points.AddXY(i * Dt, initSignal[i]);
            
            // Отрисовка графика сингулярных значений.
            chart_graphSVD.Series[0].Points.Clear();
            for (var i = 0; i < (matrixSing.GetLength(0) > matrixSing.GetLength(1) ? matrixSing.GetLength(1) : matrixSing.GetLength(0)); i++)
                chart_graphSVD.Series[0].Points.AddXY(i, matrixSing[i, i]);
            
            // Отрисовка левого и правого собственного вектора.
            chart_eigenvector.Series[0].Points.Clear();
            chart_eigenvector.Series[1].Points.Clear();
            for (var i = 0; i < matrixU.GetLength(1); i++)
            {
                chart_eigenvector.Series[0].Points.AddXY(i, matrixU[i, numberEigenvector - 1]);
                chart_eigenvector.Series[1].Points.AddXY(i, matrixV[i, numberEigenvector - 1]);
            }
        }

        /// <summary>
        /// Кнопка "Решить СЛУ".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonSolveSLE(object sender, EventArgs e)
        {
            // Размеры СЛУ.
            var m = (int)numericUpDown_M.Value;
            var n = (int)numericUpDown_N.Value;
            var min = (double)numericUpDown_min.Value;
            var max = (double)numericUpDown_max.Value;
            
            // Матрица коэффициэнтов и вектор Х и свободный столбец членов.
            var matrixA = Matrix.MatrixRandom(m, n, min, max);
            var vectorX = Matrix.MatrixRandom(n, 1, min, max);
            var vectorB = Matrix.MatrixProduct(matrixA, vectorX);
            
            // Сингулярное разложение и поиск псевдо-обратной матрицы Мура-Пенроуза.
            double[,] matrixU, matrixV;
            var matrixSing = Matrix.SVD(matrixA, out matrixU, out matrixV);
            var matrixInvSing = Matrix.InverseSingularityMatrix(matrixSing);
            var matrixInvA = Matrix.MatrixProduct(Matrix.MatrixProduct(matrixV, matrixInvSing), Matrix.MatrixTransposition(matrixU));
            var vectorNewX = Matrix.MatrixProduct(matrixInvA, vectorB);
            
            // Вычисление невязок системы.
            var d = Matrix.Discrepancy(matrixA, vectorNewX, vectorB);
            textBoxDiscrepancy.Text = d.ToString("e3");
            
            // Проверка свойств.
            var AinvAA = Matrix.MatrixProduct(Matrix.MatrixProduct(matrixA, matrixInvA), matrixA);
            var invAAinvA = Matrix.MatrixProduct(Matrix.MatrixProduct(matrixInvA, matrixA), matrixInvA);
            
            // Вывод результата в RichTextBox.
            richTextBoxResultSLE.Text = "### Матрица А:\n";
            for (var i = 0; i < matrixA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixA[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Вектор x:\n";
            for (var i = 0; i < vectorX.GetLength(0); i++)
                richTextBoxResultSLE.Text += vectorX[i, 0].ToString("F3").PadLeft('\t');
            
            richTextBoxResultSLE.Text += "\n\n### Вектор b = A*x:\n";
            for (var i = 0; i < vectorB.GetLength(0); i++)
                richTextBoxResultSLE.Text += vectorB[i, 0].ToString("F3").PadLeft('\t');
            
            richTextBoxResultSLE.Text += "\n\n### Матрица U:\n";
            for (var i = 0; i < matrixU.GetLength(0); i++)
            {
                for (var j = 0; j < matrixU.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixU[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Матрица V:\n";
            for (var i = 0; i < matrixV.GetLength(0); i++)
            {
                for (var j = 0; j < matrixV.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixV[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Сингулярная матрица Sing:\n";
            for (var i = 0; i < matrixSing.GetLength(0); i++)
            {
                for (var j = 0; j < matrixSing.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixSing[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Обратная сингулярная матрица (revSing):\n";
            for (var i = 0; i < matrixInvSing.GetLength(0); i++)
            {
                for (var j = 0; j < matrixInvSing.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixInvSing[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Псевдо-обратная матрица revА = V*revSing*UT:\n";
            for (var i = 0; i < matrixInvA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixInvA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += matrixInvA[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Вектор x = revA*b:\n";
            for (var i = 0; i < vectorNewX.GetLength(0); i++)
                richTextBoxResultSLE.Text += vectorNewX[i, 0].ToString("F3").PadLeft('\t');
            
            richTextBoxResultSLE.Text += "\n\n### Невязка системы: " + d.ToString("e3");
            
            richTextBoxResultSLE.Text += "\n\n### Проверка свойства А*revA*A = A:\n";
            for (var i = 0; i < AinvAA.GetLength(0); i++)
            {
                for (var j = 0; j < AinvAA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += AinvAA[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }

            richTextBoxResultSLE.Text += "\n### Проверка свойства revА*A*revA = revA:\n";
            for (var i = 0; i < invAAinvA.GetLength(0); i++)
            {
                for (var j = 0; j < invAAinvA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += invAAinvA[i, j].ToString("F3").PadLeft('\t');
                richTextBoxResultSLE.Text += '\n';
            }
        }

        private void OnScrollTrackBarHarmonics(object sender, EventArgs e)
        {
            switch (trackBar_harmonics.Value)
            {
                case 1: // Сигнал из 1-ой гармоники.
                    groupBox_harmonica1.Enabled = true;
                    groupBox_harmonica2.Enabled = false;
                    groupBox_harmonica3.Enabled = false;
                    break;
                case 2: // Сигнал из 2-х гармоники.
                    groupBox_harmonica1.Enabled = true;
                    groupBox_harmonica2.Enabled = true;
                    groupBox_harmonica3.Enabled = false;
                    break;
                case 3: // Сигнал из 3-х гармоники.
                    groupBox_harmonica1.Enabled = true;
                    groupBox_harmonica2.Enabled = true;
                    groupBox_harmonica3.Enabled = true;
                    break;
            }
        }

        private void OnScrollTrackBarrackBarGauss(object sender, EventArgs e)
        {
            switch (trackBar_gauss.Value)
            {
                case 1: // Сигнал из 1-ой гармоники.
                    groupBox_dome1.Enabled = true;
                    groupBox_dome2.Enabled = false;
                    groupBox_dome3.Enabled = false;
                    break;
                case 2: // Сигнал из 2-х гармоники.
                    groupBox_dome1.Enabled = true;
                    groupBox_dome2.Enabled = true;
                    groupBox_dome3.Enabled = false;
                    break;
                case 3: // Сигнал из 3-х гармоники.
                    groupBox_dome1.Enabled = true;
                    groupBox_dome2.Enabled = true;
                    groupBox_dome3.Enabled = true;
                    break;
            }
        }

        private void OnScrollTrackBarrackBarExpDecaying(object sender, EventArgs e)
        {
            switch (trackBar_expDecaying.Value)
            {
                case 1: // Сигнал из 1-ой гармоники.
                    groupBox_сomponent1.Enabled = true;
                    groupBox_сomponent2.Enabled = false;
                    groupBox_сomponent3.Enabled = false;
                    break;
                case 2: // Сигнал из 2-х гармоники.
                    groupBox_сomponent1.Enabled = true;
                    groupBox_сomponent2.Enabled = true;
                    groupBox_сomponent3.Enabled = false;
                    break;
                case 3: // Сигнал из 3-х гармоники.
                    groupBox_сomponent1.Enabled = true;
                    groupBox_сomponent2.Enabled = true;
                    groupBox_сomponent3.Enabled = true;
                    break;
            }
        }
    }
}