﻿using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalha com Árvore Binária
            //Comparado ao SortedList o SortedDictionary tem mais agilidade para lidar c/ elementos por usar árvore
            IDictionary<string, Aluno> sorted
                = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
