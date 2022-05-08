using System;
using System.Text;

namespace Two_Factor_Authentication
{
    class KeyGenerator
    {
        private static String Key;
        private static char[] characters = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


        public static int getSize()
        {
            return characters.Length;
        }
        public static void GenerateKey()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                int number = Convert.ToInt32(rnd.Next(0, 36));
                sb.Append(characters[number]);
            }

            Key = sb.ToString();

        }

        public static String GetKey()
        {
            return Key;
        }
    }
}
