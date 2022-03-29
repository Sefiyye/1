using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    internal class Word : IPrintable
    {
        private int _word;  
        public string word
        { 
            get; 
            set; 

        }
        public void Print()
        {
            Console.WriteLine(" ");
        }
    }
}
