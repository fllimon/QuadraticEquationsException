using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsDemo
{
    class NoRootExeption : Exception
    {
        #region ======----- CTOR -----=====

        public NoRootExeption()
        {

        }

        public NoRootExeption(string message)
            : base(message)
        {

        }

        public NoRootExeption(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        #endregion
    }
}
