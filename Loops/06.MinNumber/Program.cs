﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
  

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                double maxNumber = double.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num < maxNumber)
                    {
                        maxNumber = num;
                    }
                }
                Console.WriteLine(maxNumber);
            }
        }
    

        

        }
    

