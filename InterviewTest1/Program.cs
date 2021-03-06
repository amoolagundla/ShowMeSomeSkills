﻿using System;
using System.Linq;

namespace InterviewTest1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new Repo().All();

            data.SelectMany(invoice => invoice.LineItems)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}