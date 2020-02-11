using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsDemo
{
    class FormatArgumentExeption : Exception
    {
        #region ======----- CTOR -----=====

        public FormatArgumentExeption()
        {

        }

        public FormatArgumentExeption(string message)
            : base(message)
        {

        }

        public FormatArgumentExeption(string message, Exception innerExeption)
            : base(message, innerExeption)
        {

        }

        #endregion
    }
}
