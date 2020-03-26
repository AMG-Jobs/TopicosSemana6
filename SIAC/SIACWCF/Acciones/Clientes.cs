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

        internal CLIENTES BuscarClientePorId(int idCliente)
        {
            var elResultado = elRepositorio.CLIENTES.ToList().Where(cl => cl.ID == idCliente).Select(cl => new CLIENTES(cl)).FirstOrDefault();
            return elResultado;
        }

        internal CLIENTES CrearCliente(CLIENTES nuevoCliente)
        {
            var elResultado = elRepositorio.CLIENTES.Add(nuevoCliente);
            elRepositorio.SaveChanges();
            return elResultado;
        }

        internal string EliminarCliente(int clienteEliminado)
        {
            var elCliente = elRepositorio.CLIENTES.ToList().Where(cl => cl.ID == clienteEliminado).FirstOrDefault();
            elRepositorio.CLIENTES.Remove(elCliente);
            elRepositorio.SaveChanges();
            return "Exito en la elimincación";
        }

        internal CLIENTES EditarCliente(CLIENTES clienteEditado)
        {
            var elClienteAlmacedo = elRepositorio.CLIENTES.ToList().Where(cl => cl.ID == clienteEditado.ID).FirstOrDefault();
            elClienteAlmacedo.NOMBRE = clienteEditado.NOMBRE;
            elClienteAlmacedo.APELLIDO = clienteEditado.APELLIDO;
            elClienteAlmacedo.PROVINCIA = clienteEditado.PROVINCIA;
            elClienteAlmacedo.CANTON = clienteEditado.CANTON;
            elClienteAlmacedo.DISTRITO = clienteEditado.DISTRITO;
            elRepositorio.SaveChanges();
            return clienteEditado;
        }
    }
}