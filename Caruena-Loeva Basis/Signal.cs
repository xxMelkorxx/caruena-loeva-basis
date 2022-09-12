using System;

namespace Caruena_Loeva_Basis
{
    class Signal
    {
        private static readonly double DoublePI = 2 * Math.PI;
        /// <summary>
        /// Гармоническая функция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="f">Частота</param>
        /// <param name="phi">Начальная фаза</param>
        /// <param name="t">Переменная времени</param>
        private static double HarmonicFunction(double A, double f, double phi, double t)
        {
            return A * Math.Sin(DoublePI * f * t + phi);
        }
        /// <summary>
        /// Гауссова функиция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="SKO">Среднеквдаратичное отклонение</param>
        /// <param name="E">Математическое ожидание</param>
        /// <param name="t">Переменная времени</param>
        private static double GaussFunction(double A, double SKO, double E, double t)
        {
            return A * Math.Exp(-Math.Pow((t - E) / SKO, 2));
        }
        /// <summary>
        /// Экспоненциально-затухающая функция.
        /// </summary>
        /// <param name="a">Коэффициент затухания</param>
        /// <param name="f">Частота</param>
        /// <param name="phase">Фаза</param>
        /// <param name="t">Переменная времени</param>
        /// <returns></returns>
        private static double ExponentialDecayingFunction(double a, double f, double phase, double t)
        {
            return Math.Exp(-a * t) * Math.Sin(DoublePI * f * t + phase);
        }

        /// <summary>
        /// Генерация полигармонического сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="A">Амплитуды</param>
        /// <param name="f">Частоты</param>
        /// <param name="phi">Фазы</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный полигармонический сигнал</returns>
        public static double[] GenerateHarmonicSignal(int length, double[] A, double[] f, double[] phi, double dt)
        {
            var signal = new double[length];
            for (int i = 0; i < length; i++)
                for (int k = 0; k < A.Length; k++)
                    signal[i] += HarmonicFunction(A[k], f[k], phi[k], i * dt);
            return signal;
        }
        /// <summary>
        /// Генерация гауссова сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="A">Амплитуды</param>
        /// <param name="SKO">Среднеквдаратичные отклонения</param>
        /// <param name="E">Математические ожидания</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный гауссов сигнал</returns>
        public static double[] GenerateGaussSignal(int length, double[] A, double[] SKO, double[] E, double dt)
        {
            var signal = new double[length];
            for (int i = 0; i < length; i++)
                for (int k = 0; k < A.Length; k++)
                    signal[i] += GaussFunction(A[k], SKO[k], E[k], i * dt);
            return signal;
        }
        /// <summary>
        /// Генерация полигармонического затухающего сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="a">Коэффициенты затухания</param>
        /// <param name="f">Частоты</param>
        /// <param name="phi">Фазы</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный полигармонический затухающий сигнал</returns>
        public static double[] GenerateExponentialDecayingSignal(int length, double[] a, double[] f, double[] phi, double dt)
        {
            var signal = new double[length];
            for (int i = 0; i < length; i++)
                for (int k = 0; k < a.Length; k++)
                    signal[i] += ExponentialDecayingFunction(a[k], f[k], phi[k], i * dt);
            return signal;
        }
    }
}