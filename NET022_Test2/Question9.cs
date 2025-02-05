﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET022_Test2
{
    public class Question9
    {

        public static Func<int> RandomNumberGenerator = () =>
        {
            Random random = new Random();
            return random.Next(1, 10001);
        };

        public static Func<Func<int>, string> GenerateStringOutput = (getNumber) =>
        {
            int number = getNumber();
            return $"The Generates Number is: {number}";
        };

        static void Main()
        {
            Task.Factory.StartNew(() => RandomNumberGenerator)
                .ContinueWith(prevTask => GenerateStringOutput(prevTask.Result))
                .ContinueWith(finalTask => Console.WriteLine(finalTask.Result));

            Console.ReadLine();
        }
    }
}
