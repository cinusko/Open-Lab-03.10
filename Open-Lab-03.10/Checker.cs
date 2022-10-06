using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int contains = 0;

            foreach (var characters in str)
            { 
                if (characters == letter) { contains++; }
            }
            return contains;
        }
    }
}
