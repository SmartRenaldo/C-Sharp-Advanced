﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericCovarianceAndContravariance
{
    public interface IListIN<in T>
    {
        void Show(T item);
    }
}
