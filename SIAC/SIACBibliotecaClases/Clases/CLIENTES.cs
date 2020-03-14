using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIACBibliotecaClases
{
    partial class CLIENTES
    {
        string NombreCompleto
        {
            get
            {
                var nombreCompleto=string.Format("{0} {1}",NOMBRE,APELLIDO)
                return "";

            }
            set { }
        }
    }
}
