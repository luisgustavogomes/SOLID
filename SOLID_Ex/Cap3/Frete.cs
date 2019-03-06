﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Ex.Cap3
{
    public class Frete : IServicoDeEntrega
    {
        public Frete()
        {
        }

        public double Para(string cidade)
        {
            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}