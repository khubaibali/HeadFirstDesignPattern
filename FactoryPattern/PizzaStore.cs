﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        protected Pizza pizza = null;
        public abstract Pizza CreatePizza();
    }
}
