using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogin.IO.Interfaces
{
    internal interface IWriter
    {
        public void WriteLine(string text);

        public void Write(string text);
    }
}
