﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmer
{
    class Swimmer
    {
        private string name;
        private BathingSuit suit;
        public Swimmer(string name)
        {

        }
        public Swimmer(string name, BathingSuit suit)
        {

        }
        public virtual void SetSuit(BathingSuit bathingSuit)
        {
            suit = bathingSuit;
        }

        public virtual void Swim() 
        {
            Console.WriteLine("Splish Splash - it's so fun in the bath");
        }

    }
}
