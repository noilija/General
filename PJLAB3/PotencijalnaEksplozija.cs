using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLab3V2
{
    class PotencijalnaEksplozija : Exception
    {
        public PotencijalnaEksplozija() { }
        public PotencijalnaEksplozija(string message)
                :base(message)  { }
        public PotencijalnaEksplozija(string message,
            Exception inner) : base(message, inner) { }


    }
}
