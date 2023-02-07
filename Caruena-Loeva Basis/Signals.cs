using System;

namespace Caruena_Loeva_Basis
{
    class Signals
    {
        /// <summary>
        /// Гармоническая функция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="f">Частота</param>
        /// <param name="phi">Начальная фаза</param>
        /// <param name="t">Переменная времени</param>
        private static double HarmonicFunction(double a, double f, double phi, double t) => a * Math.Sin(2 * Math.PI * f * t + phi);

        /// <summary>
        /// Гауссова функиция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="s">Дисперсия</param>
        /// <param name="shift">Сдвиг</param>
        /// <param name="t">Переменная времени</param>
        private static double GaussFunction(double a, double s, double shift, double t) => a * Math.Exp(-Math.Pow((t - shift) / s, 2));

        /// <summary>
        /// Экспоненциально-затухающая функция.
        /// </summary>
        /// <param name="a">Коэффициент затухания</param>
        /// <param name="f">Частота</param>
        /// <param name="phase">Фаза</param>
        /// <param name="t">Переменная времени</param>
        private static double ExponentialDecayingFunction(double a, double f, double phase, double t) => Math.Exp(-a * t) * Math.Sin(2 * Math.PI * f * t + phase);

        /// <summary>
        /// Генерация полигармонического сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="a">Амплитуды</param>
        /// <param name="f">Частоты</param>
        /// <param name="phi">Фазы</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный полигармонический сигнал</returns>
        public static double[] GenerateHarmonicSignal(int length, double[] a, double[] f, double[] phi, double dt)
        {
            var result = new double[length];
            
            for (var i = 0; i < length; i++)
            for (var k = 0; k < a.Length; k++)
                result[i] += HarmonicFunction(a[k], f[k], phi[k], i * dt);
            
            return result;
        }

        /// <summary>
        /// Генерация гауссова сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="a">Амплитуды</param>
        /// <param name="s">Дисперсии</param>
        /// <param name="shift">Сдвиги</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный гауссов сигнал</returns>
        public static double[] GenerateGaussSignal(int length, double[] a, double[] s, double[] shift, double dt)
        {
            var result = new double[length];
            
            for (var i = 0; i < length; i++)
            for (var k = 0; k < a.Length; k++)
                result[i] += GaussFunction(a[k], s[k], shift[k], i * dt);
            
            return result;
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
            var result = new double[length];
            
            for (var i = 0; i < length; i++)
            for (var k = 0; k < a.Length; k++)
                result[i] += ExponentialDecayingFunction(a[k], f[k], phi[k], i * dt);
            
            return result;
        }
    }
}