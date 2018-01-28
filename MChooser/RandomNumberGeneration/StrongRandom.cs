using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.RandomNumberGeneration
{
    public class StrongRandom : RandomNumberGenerator
    {
        private static RandomNumberGenerator rand;

        public StrongRandom()
        {
            rand = RandomNumberGenerator.Create();
        }

        public override void GetBytes(byte[] data)
        {
            rand.GetBytes(data);
        }

        public double NextDouble()
        {
            byte[] bytes = new byte[4];
            rand.GetBytes(bytes);
            return (double)BitConverter.ToUInt32(bytes, 0) / UInt32.MaxValue;
        }

        public int Next(int minValue, int maxValue)
        {
            return (int)Math.Round(NextDouble() * (maxValue - minValue - 1)) + minValue;
        }

        public int Next()
        {
            return Next(0, int.MaxValue);
        }

        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }
    }
}
