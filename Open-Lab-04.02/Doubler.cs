using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string letter = "";
            for (int i = 0; i < original.Length; i++)
                {
                letter = letter + original[i] + original[i];
                }
            return letter;
        }
    }
}
