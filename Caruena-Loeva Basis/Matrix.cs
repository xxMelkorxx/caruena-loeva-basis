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
        /// <returns></returns>
        public static double[,] MatrixRandom(int rows, int cols, double minVal, double maxVal)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            var result = new double[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = (maxVal - minVal) * rnd.NextDouble() + minVal;
            return result;
        }
        /// <summary>
        /// Переумножение матриц.
        /// </summary>
        /// <param name="matrixA">1-ая матрица</param>
        /// <param name="matrixB">2-ая матрица (на которую умножаем)</param>
        /// <returns></returns>
        public static double[,] MatrixProduct(double[,] matrixA, double[,] matrixB)
        {
            var aRows = matrixA.GetLength(0); var aCols = matrixA.GetLength(1);
            var bRows = matrixB.GetLength(0); var bCols = matrixB.GetLength(1);

            if (aCols != bRows)
                throw new Exception("Несоответствующие матрицы!");

            var result = new double[aRows, bCols];
            for (int i = 0; i < aRows; i++)
                for (int j = 0; j < bCols; j++)
                    for (int k = 0; k < aCols; k++)
                        result[i, j] += matrixA[i, k] * matrixB[k, j];

            return result;
        }
        /// <summary>
        /// Транспонирование матрицы.
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <returns></returns>
        public static double[,] MatrixTransposition(double[,] matrix)
        {
            var M = matrix.GetLength(0);    //Число строк
            var N = matrix.GetLength(1);    //Число столбцов
            var matrixT = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrixT[i, j] = matrix[j, i];

            return matrixT;
        }
        /// <summary>
        /// Вычисление обратной сингулярной матрицы с применением регуляризации.
        /// </summary>
        /// <param name="singularityMatrix">Сингулярная матрица</param>
        /// <returns></returns>
        public static double[,] InverseSingularityMatrix(double[,] singularityMatrix)
        {
            var M = singularityMatrix.GetLength(0); //Число строк
            var N = singularityMatrix.GetLength(1); //Число столбцов

            var singMaxValue = 0.0;
            for (int i = 0; i < ((M > N) ? N : M); i++)
                if (singularityMatrix[i, i] > singMaxValue) singMaxValue = singularityMatrix[i, i];

            var invSingularityMatrix = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    invSingularityMatrix[i, j] = (i == j) ? ((singularityMatrix[i, i] > singMaxValue * 0.01f) ? 1 / singularityMatrix[i, i] : 0) : 0;

            return invSingularityMatrix;
        }
        /// <summary>
        /// Сингулярное разложение.
        /// </summary>
        /// <param name="A">Матрица, которую требуется разложить</param>
        /// <param name="U">Левая сингулярная матрица</param>
        /// <param name="VT">Правая сингулярная матрица</param>
        /// <returns>Сингулярная матрица</returns>
        public static double[,] MatrixSVD(double[,] A, out double[,] U, out double[,] V)
        {
            var M = A.GetLength(0);     //Число строк
            var N = A.GetLength(1);     //Число столбцов

            double[] W;
            // Библиотека alglib https://www.alglib.net/docs.php
            alglib.rmatrixsvd(A, M, N, 2, 2, 2, out W, out U, out V);

            V = MatrixTransposition(V);
            var matrixSing = new double[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    matrixSing[i, j] = (i == j) ? W[i] : 0;

            return matrixSing;
        }
        /// <summary>
        /// Вычисление невязки СЛУ.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="x"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Discrepancy(double[,] A, double[,] x, double[,] b)
        {
            var M = A.GetLength(0);     //Число строк
            var N = A.GetLength(1);     //Число столбцов

            var d = 0.0;
            for (int i = 0; i < M; i++) {
                var sum = 0.0;
                for (int j = 0; j < N; j++)
                    sum += A[i, j] * x[j, 0];
                d += (b[i, 0] - sum) * (b[i, 0] - sum);
            }
            return d / M;
        }
        /// <summary>
        /// Вычисление АКП сигнала.
        /// </summary>
        /// <param name="m">Порядок автокорреляции</param>
        /// <param name="x">Сигнал х</param>
        private static double AutoCorrelationSequence(int m, double[] x)
        {
            var sum = 0.0;
            m = Math.Abs(m);
            for (int k = 0; k < x.Length - m; k++)
                sum += x[k] * x[k + m];
            return sum / (x.Length - m);
        }
        /// <summary>
        /// Вычисление АКМ сигнала.
        /// </summary>
        /// <param name="x">Сигнал х</param>
        /// <param name="y">Сигнад y</param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double[,] AutoCorrelationMatrix(double[] x, int p)
        {
            var R = new double[p, p];
            for (int i = 0; i < p; i++)
                for (int j = 0; j < p; j++)
                    R[i, j] = AutoCorrelationSequence(i - j, x);
            return R;
        }
    }
}