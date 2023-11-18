using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class BoardException : ApplicationException
    {
        public BoardException(string message) : base(message) { }
    }
}
