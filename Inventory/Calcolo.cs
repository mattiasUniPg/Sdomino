﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Calcolo : Order
    {

        int[] basi = { 5, 7, 3 };
        int[] integrale = { 0, 1 };
        int[] aggiungi = { 1, 2, 2, 20 };

        public int Somma() 
        {
            int i, j, n;
            Console.ReadLine($"{i}");
            var totale=basi[i] + integrale[j] + aggiungi[n];
            return totale;
        }
    }
}
