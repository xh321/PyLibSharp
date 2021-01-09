﻿using PyLibSharp.Requests;
using System;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Requests.Get("https://api.yukari.one/pcr/unit_data.py", new ReqParams()
            {
                Timeout = 3000
            });

            Console.WriteLine("结束");
            Console.WriteLine(str);

            foreach (string s in str)
            {
                Console.Write(s);
            }

            Console.ReadKey();
        }
        private static void Requests_ReqExceptionHandler(object sender, Requests.AggregateExceptionArgs e)
        {
            
            Console.WriteLine(e.AggregateException);
        }
    }
}
