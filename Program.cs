﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            int a;
            Console.Write("informe o valor da aresta: ");
            p = int.Parse(Console.ReadLine());
            a = p * p;
            Console.WriteLine("o valor  da área é:{0} ", a);

        }
    }
}
