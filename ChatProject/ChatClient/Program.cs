﻿using ServiceProxy.Core;
using System;

namespace ChatClient
{
    class Program
    {
        private static ClientCore mClientCore = new ClientCore();
        static void Main(string[] args)
        {
            mClientCore.Send("7897");

            Console.ReadKey();
        }
    }
}
