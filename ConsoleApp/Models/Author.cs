﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Author : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}