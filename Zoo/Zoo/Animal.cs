﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        public static List<string> Dyreliste = new List<string>();
        protected int count;
        protected string name;
        protected static int fulgecount;
        protected static int rovdyrcount;
        protected static int fiskcount;
        protected static int totalcount = fulgecount + rovdyrcount + fiskcount;
        protected static int listcount = Dyreliste.Count;

        public void CheckAllAnimals() //Dette virker, men tror ikke det er det mads er ude efter / Jeg håber det virkelig ikke, fordi det er for meget copy/paste og kedeligt.
        {
            Løver løver = new Løver();
            Tiger tiger = new Tiger();
            løver.AddLøver();
            tiger.AddTiger();
        }
        public int getcount()
        {
            return count;
        }
        public void setcount(int c)
        {
            this.count = c;
        }
    }
}