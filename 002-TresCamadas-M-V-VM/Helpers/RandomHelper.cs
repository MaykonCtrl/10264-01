using System;
using System.Text;
using System.Windows.Media;

namespace _002_TresCamadas_M_V_VM.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random RandomSeed = new Random();

        public static string RandomString(int size, bool lowerCase)
        {
            var randStr = new StringBuilder(size);

            var start = (lowerCase) ? 97 : 65;

            for (var i = 0; i < size; i++)
                randStr.Append((char)(26 * RandomSeed.NextDouble() + start));

            return randStr.ToString();
        }

        public static int RandomInt(int min, int max)
        {
            return RandomSeed.Next(min, max);
        }

        public static double RandomDouble()
        {
            return RandomSeed.NextDouble();
        }

        public static double RandomNumber(int min, int max, int digits)
        {
            return Math.Round(RandomSeed.Next(min, max - 1) + RandomSeed.NextDouble(), digits);
        }

        public static bool RandomBool()
        {
            return (RandomSeed.NextDouble() > 0.5);
        }

        public static DateTime RandomDate()
        {
            return RandomDate(new DateTime(1900, 1, 1), DateTime.Now);
        }

        public static DateTime RandomDate(DateTime from, DateTime to)
        {
            var range = new TimeSpan(to.Ticks - from.Ticks);
            return from + new TimeSpan((long)(range.Ticks * RandomSeed.NextDouble()));
        }

        public static Color RandomColor()
        {
            return Color.FromRgb((byte)RandomSeed.Next(255), (byte)RandomSeed.Next(255), (byte)RandomSeed.Next(255));
        }

    }
}
