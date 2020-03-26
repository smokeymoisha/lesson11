﻿using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class Cat
    {
        private readonly IHunter _hunter;
        private readonly IValerian _valerian;

        public Cat(IHunter hunter, IValerian valerian)
        {
            _hunter = hunter;
            _valerian = valerian;
        }

        public void Geeting()
        {
            Console.WriteLine("I am cat");
            _hunter.GoHunt();
            _valerian.GoNutsOverValerian();
        }
    }
}