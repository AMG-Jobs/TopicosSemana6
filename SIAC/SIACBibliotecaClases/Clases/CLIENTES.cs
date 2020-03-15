using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIACBibliotecaClases
{
    partial class CLIENTES
    {
        public string NombreCompleto
        {
            get
            {
                var nombreCompleto = string.Format("{0} {1}", NOMBRE, APELLIDO);
                return nombreCompleto;
            }
            set { }
        }

        public CLIENTES(CLIENTES cl)
        {
            ID = cl.ID;
            NOMBRE = cl.NOMBRE;
            APELLIDO = cl.APELLIDO;
            PROVINCIA = cl.PROVINCIA;
            CANTON = cl.CANTON;
            DISTRITO = cl.DISTRITO;
        }
    }
}
