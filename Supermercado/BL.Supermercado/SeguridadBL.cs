using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Supermercado
{
    public class SeguridadBL
    {
        public bool Autorizar(string Usuario, string Contra)
        {
            if (Usuario == "admin" && Contra == "123")
            {
                return true;
            }
            else
            {
                if (Usuario == "user" && Contra == "456")
                {
                    return true;
                }
            }

            return false;
        }
     
    }
}
