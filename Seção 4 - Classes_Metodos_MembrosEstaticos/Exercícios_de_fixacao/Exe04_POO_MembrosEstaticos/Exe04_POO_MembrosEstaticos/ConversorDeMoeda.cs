using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe04_POO_MembrosEstaticos {
    class ConversorDeMoeda {
        public static double IoF = 6.0;

        public static double DolarParalelo(double valor, double quotacao) {
            return valor * quotacao * (1 + (IoF / 100));
        }
    }
}
