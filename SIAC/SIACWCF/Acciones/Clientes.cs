using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIACBibliotecaClases;

namespace SIACWCF.Acciones
{
    internal class Clientes
    {
        SIACEntities elRepositorio = new SIACEntities();

        internal IList<CLIENTES> TraeClientes()
        {
            var elResultado=elRepositorio.CLIENTES.ToList().Select(cl => new CLIENTES(cl)).ToList();
            return elResultado;
        }
    }
}