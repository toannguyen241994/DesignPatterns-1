﻿using DoFactory.GangOfFour.FactoryMethod.Structural;
using FactoryMethod.EmailManagers;
using FactoryMethod.Factory1;
using FactoryMethod.FactoryMethodAvocadoShopExample;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory example 1

            Console.WriteLine("Factory Method Example 1 with email server.");
            Console.WriteLine();
            FactoryExample1ClientCode.Run();

            #endregion

            #region DoFactory GangOfFour FactoryMethod Structural example

            Console.WriteLine("Gang Of Four Factory Method Structural example");
            Console.WriteLine();

            GofFFacotryExample.Run();

            #endregion

            #region Factory Method Avocado Shop Example

            Console.WriteLine("Factory Pattern Avocado Shop Example");
            Console.WriteLine();
            FactoryPattern.Run();

            #endregion

            Console.Read();
        }
    }
}
