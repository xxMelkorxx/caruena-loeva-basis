using System;

namespace Caruena_Loeva_Basis
{
    class Matrix
    {
        /// <summary>
        /// Cоздание случайной матрицы.
        /// </summary>
        /// <param name="rows">Число строк</param>
        /// <param name="cols">Число столбцов</param>
        /// <param name="minVal">Нижний предел диапазона случайных чисел</param>
        /// <param name="maxVal">Верхний предел диапазона случайных чисел</param>
        public static double[,] MatrixRandom(int rows, int cols, double minVal, double maxVal)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            var result = new double[rows, cols];
            
            for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
                result[i, j] = (maxVal - minVal) * rnd.NextDouble() + minVal;
            
            return result;
        }

        /// <summary>
        /// Переумножение матриц.
        /// </summary>
        /// <param name="matrixA">1-ая матрица</param>
        /// <param name="matrixB">2-ая матрица (на которую умножаем)</param>
        public static double[,] MatrixProduct(double[,] matrixA, double[,] matrixB)
        {
            var aRows = matrixA.GetLength(0);
            var aCols = matrixA.GetLength(1);
            var bRows = matrixB.GetLength(0);
            var bCols = matrixB.GetLength(1);

            if (aCols != bRows)
                throw new Exception("Несоответствующие матрицы!");

            var result = new double[aRows, bCols];
            for (var i = 0; i < aRows; i++)
            for (var j = 0; j < bCols; j++)
            for (var k = 0; k < aCols; k++)
                result[i, j] += matrixA[i, k] * matrixB[k, j];

            return result;
        }

        /// <summary>
        /// Транспонирование матрицы.
        /// </summary>
        /// <param name="matrix">Матрица</param>
        public static double[,] MatrixTransposition(double[,] matrix)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);
            var matrixT = new double[n, m];
            
            for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                matrixT[i, j] = matrix[j, i];

            return matrixT;
        }

        /// <summary>
        /// Вычисление обратной сингулярной матрицы с применением регуляризации.
        /// </summary>
        /// <param name="singularityMatrix">Сингулярная матрица</param>
        public static double[,] InverseSingularityMatrix(double[,] singularityMatrix)
        {
            var m = singularityMatrix.GetLength(0);
            var n = singularityMatrix.GetLength(1);

            var singMaxValue = double.MinValue;
            for (var i = 0; i < (m > n ? n : m); i++)
                singMaxValue = Math.Max(singularityMatrix[i, i], singMaxValue);

            var invSingularityMatrix = new double[n, m];
            for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                invSingularityMatrix[i, j] = (i == j) ? (singularityMatrix[i, i] > singMaxValue * 0.01f) ? 1 / singularityMatrix[i, i] : 0 : 0;

            return invSingularityMatrix;
        }

        /// <summary>
        /// Сингулярное разложение.
        /// </summary>
        /// <param name="mtxA">Матрица, которую требуется разложить</param>
        /// <param name="mtxU">Левая сингулярная матрица</param>
        /// <param name="mtxV">Правая сингулярная матрица</param>
        /// <returns>Сингулярная матрица</returns>
        public static double[,] SVD(double[,] mtxA, out double[,] mtxU, out double[,] mtxV)
        {
            var m = mtxA.GetLength(0);
            var n = mtxA.GetLength(1);

            double[] w;
            
            // Библиотека alglib https://www.alglib.net/docs.php
            alglib.rmatrixsvd(mtxA, m, n, 2, 2, 2, out w, out mtxU, out mtxV);

            mtxV = MatrixTransposition(mtxV);
            var matrixSing = new double[m, n];
            
            for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                matrixSing[i, j] = (i == j) ? w[i] : 0;

            return matrixSing;
        }

        /// <summary>
        /// Вычисление невязки СЛУ.
        /// </summary>
        /// <param name="mtxA"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Discrepancy(double[,] mtxA, double[,] x, double[,] b)
        {
            var m = mtxA.GetLength(0);
            var n = mtxA.GetLength(1);

            var d = 0d;
            for (var i = 0; i < m; i++)
            {
                var sum = 0.0;
                for (var j = 0; j < n; j++)
                    sum += mtxA[i, j] * x[j, 0];
                d += (b[i, 0] - sum) * (b[i, 0] - sum);
            }

            return d / m;
        }

        /// <summary>
        /// Вычисление АКП сигнала.
        /// </summary>
        /// <param name="m">Порядок автокорреляции</param>
        /// <param name="x">Сигнал х</param>
        private static double AutoCorrelationSequence(int m, double[] x)
        {
            var sum = 0d;
            m = Math.Abs(m);
            for (var k = 0; k < x.Length - m; k++)
                sum += x[k] * x[k + m];
            return sum / (x.Length - m);
        }

        /// <summary>
        /// Вычисление АКМ сигнала.
        /// </summary>
        /// <param name="x">Сигнал х</param>
        /// <param name="p"></param>
        public static double[,] AutoCorrelationMatrix(double[] x, int p)
        {
            var result = new double[p, p];
            for (var i = 0; i < p; i++)
            for (var j = 0; j < p; j++)
                result[i, j] = AutoCorrelationSequence(i - j, x);
            return result;
        }
    }
}