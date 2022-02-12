using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos
{
    public class Calculadora
    {
        public bool EsPrimo(int n)
        {
            
            for (int i = 2; i < n; i++)
            {
                if ((n % i)==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
