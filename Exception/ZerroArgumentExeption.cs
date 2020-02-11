using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsDemo
{
    class ZerroArgumentExeption : Exception
    {
        #region ======----- CTOR -----======

        public ZerroArgumentExeption()
        {

        }

        public ZerroArgumentExeption(string message)
            : base(message)
        {

        }

        public ZerroArgumentExeption(string message, Exception innerExeption)
            : base(message, innerExeption)
        {

        }

        #endregion
    }
}
