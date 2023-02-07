using System;
using System.Windows.Forms;

namespace Caruena_Loeva_Basis
{
    public partial class MainForm : Form
    {
        private readonly int length = 1000;                                  // Число отсчётов
        private readonly double dt = 0.1;                                    // Частота дискретизации

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
            // Параметры полигармонического сигнала
            var A1 = (double)numericUpDown_amplitude1.Value;
            var A2 = groupBox_harmonica2.Enabled.Equals(false) ? 0 : (double)numericUpDown_amplitude2.Value;
            var A3 = groupBox_harmonica3.Enabled.Equals(false) ? 0 : (double)numericUpDown_amplitude3.Value;
            var f1 = (double)numericUpDown_frequency1.Value;
            var f2 = groupBox_harmonica2.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequency2.Value;
            var f3 = groupBox_harmonica3.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequency3.Value;
            var phi1 = (double)numericUpDown_phase1.Value;
            var phi2 = groupBox_harmonica2.Enabled.Equals(false) ? 0 : (double)numericUpDown_phase2.Value;
            var phi3 = groupBox_harmonica3.Enabled.Equals(false) ? 0 : (double)numericUpDown_phase3.Value;
            // Параметры гауссова сигнала
            var Ag1 = (double)numericUpDown_amplitudeGauss1.Value;
            var Ag2 = groupBox_dome2.Enabled.Equals(false) ? 0 : (double)numericUpDown_amplitudeGauss2.Value;
            var Ag3 = groupBox_dome3.Enabled.Equals(false) ? 0 : (double)numericUpDown_amplitudeGauss3.Value;
            var sko1 = (double)numericUpDown_sko1.Value;
            var sko2 = groupBox_dome2.Enabled.Equals(false) ? 0 : (double)numericUpDown_sko2.Value;
            var sko3 = groupBox_dome3.Enabled.Equals(false) ? 0 : (double)numericUpDown_sko3.Value;
            var E1 = (double)numericUpDown_mathExpectation1.Value;
            var E2 = groupBox_dome2.Enabled.Equals(false) ? 0 : (double)numericUpDown_mathExpectation2.Value;
            var E3 = groupBox_dome3.Enabled.Equals(false) ? 0 : (double)numericUpDown_mathExpectation3.Value;
            // Параметры экспоненциально-затухающего полигармонического сигнала
            var a1 = (double)numericUpDown_attenuation1.Value;
            var a2 = groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_attenuation2.Value;
            var a3 = groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_attenuation3.Value;
            var fED1 = (double)numericUpDown_frequencyED1.Value;
            var fED2 = groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequencyED2.Value;
            var fED3 = groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_frequencyED3.Value;
            var phiED1 = (double)numericUpDown_phaseED1.Value;
            var phiED2 = groupBox_сomponent2.Enabled.Equals(false) ? 0 : (double)numericUpDown_phaseED2.Value;
            var phiED3 = groupBox_сomponent3.Enabled.Equals(false) ? 0 : (double)numericUpDown_phaseED3.Value;
            //
            var correlationOrder = (int)numericUpDown_correlationOrder.Value;
            var numberEigenvector = (int)numericUpDown_eigenvectorNumber.Value;

            // Генерация сигнала
            var InitSgnl = new double[length];
            if (tabControl_sgnlParam.SelectedIndex == 0)    // Полигармонический сигнал.
                InitSgnl = Signal.GenerateHarmonicSignal(length, new double[] { A1, A2, A3 }, new double[] { f1, f2, f3 }, new double[] { phi1, phi2, phi3 }, dt);
            if (tabControl_sgnlParam.SelectedIndex == 1)    // Гауссов сигнал.
                InitSgnl = Signal.GenerateGaussSignal(length, new double[] { Ag1, Ag2, Ag3 }, new double[] { sko1, sko2, sko3 }, new double[] { E1, E2, E3 }, dt);
            if (tabControl_sgnlParam.SelectedIndex == 2)    // Экспоненциально-затухающий полигармонический сигнал.
                InitSgnl = Signal.GenerateExponentialDecayingSignal(length, new double[] { a1, a2, a3 }, new double[] { fED1, fED2, fED3 }, new double[] { phiED1, phiED2, phiED3 }, dt);
            // Вычисление АКМ сигнала.
            var AKM = Matrix.AutoCorrelationMatrix(InitSgnl, correlationOrder);
            // SVD-разложение АКМ сигнала.
            double[,] matrixU, matrixV;
            var matrixSing = Matrix.MatrixSVD(AKM, out matrixU, out matrixV);

            // Отрисовка графика исходного сигнала.
            chart_initSgnl.Series[0].Points.Clear();
            for (var i = 0; i < length; i++)
                chart_initSgnl.Series[0].Points.AddXY(i * dt, InitSgnl[i]);
            // Отрисовка графика сингулярных значений.
            chart_graphSVD.Series[0].Points.Clear();
            for (int i = 0; i < ((matrixSing.GetLength(0) > matrixSing.GetLength(1)) ? matrixSing.GetLength(1) : matrixSing.GetLength(0)); i++)
                chart_graphSVD.Series[0].Points.AddXY(i, matrixSing[i, i]);
            // Отрисовка левого и правого собственного вектора.
            chart_eigenvector.Series[0].Points.Clear();
            chart_eigenvector.Series[1].Points.Clear();
            for (int i = 0; i < matrixU.GetLength(1); i++)
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
            var M = (int)numericUpDown_M.Value;
            var N = (int)numericUpDown_N.Value;
            var min = (double)numericUpDown_min.Value;
            var max = (double)numericUpDown_max.Value;
            // Матрица коэффициэнтов и вектор Х и свободный столбец членов.
            var matrixA = Matrix.MatrixRandom(M, N, min, max);
            var vectorX = Matrix.MatrixRandom(N, 1, min, max);
            var vectorB = Matrix.MatrixProduct(matrixA, vectorX);
            // Сингулярное разложение и поиск псевдо-обратной матрицы Мура-Пенроуза.
            double[,] matrixU, matrixV;
            var matrixSing = Matrix.MatrixSVD(matrixA, out matrixU, out matrixV);
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
            for (int i = 0; i < matrixA.GetLength(0); i++) {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixA[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Вектор x:\n";
            for (int i = 0; i < vectorX.GetLength(0); i++)
                richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(vectorX[i, 0], 4));
            richTextBoxResultSLE.Text += "\n\n### Вектор b = A*x:\n";
            for (int i = 0; i < vectorB.GetLength(0); i++)
                richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(vectorB[i, 0], 4));
            richTextBoxResultSLE.Text += "\n\n### Матрица U:\n";
            for (int i = 0; i < matrixU.GetLength(0); i++) {
                for (int j = 0; j < matrixU.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixU[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Матрица V:\n";
            for (int i = 0; i < matrixV.GetLength(0); i++) {
                for (int j = 0; j < matrixV.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixV[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Сингулярная матрица Sing:\n";
            for (int i = 0; i < matrixSing.GetLength(0); i++) {
                for (int j = 0; j < matrixSing.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixSing[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Обратная сингулярная матрица (revSing):\n";
            for (int i = 0; i < matrixInvSing.GetLength(0); i++) {
                for (int j = 0; j < matrixInvSing.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixInvSing[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Псевдо-обратная матрица revА = V*revSing*UT:\n";
            for (int i = 0; i < matrixInvA.GetLength(0); i++) {
                for (int j = 0; j < matrixInvA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(matrixInvA[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Вектор x = revA*b:\n";
            for (int i = 0; i < vectorNewX.GetLength(0); i++)
                richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(vectorNewX[i, 0], 4));
            richTextBoxResultSLE.Text += string.Format("\n\n### Невязка системы: {0}", d);
            richTextBoxResultSLE.Text += "\n\n### Проверка свойства А*revA*A = A:\n";
            for (int i = 0; i < AinvAA.GetLength(0); i++) {
                for (int j = 0; j < AinvAA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(AinvAA[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
            richTextBoxResultSLE.Text += "\n### Проверка свойства revА*A*revA = revA:\n";
            for (int i = 0; i < invAAinvA.GetLength(0); i++) {
                for (int j = 0; j < invAAinvA.GetLength(1); j++)
                    richTextBoxResultSLE.Text += string.Format("{0}\t", Math.Round(invAAinvA[i, j], 4));
                richTextBoxResultSLE.Text += "\n";
            }
        }
        private void OnScrollTrackBarHarmonics(object sender, EventArgs e)
        {
            switch (trackBar_harmonics.Value) {
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
            switch (trackBar_gauss.Value) {
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
            switch (trackBar_expDecaying.Value) {
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