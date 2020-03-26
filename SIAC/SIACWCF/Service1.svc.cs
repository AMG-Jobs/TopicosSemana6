using SIACBibliotecaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SIACWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public CLIENTES BuscarClientePorId(int idCliente)
        {
            var accion = new Acciones.Clientes();
            var resultado = accion.BuscarClientePorId(idCliente);
            return resultado;
        }

        public CLIENTES CrearCliente(CLIENTES nuevoCliente)
        {
            var accion = new Acciones.Clientes();
            var resultado = accion.CrearCliente(nuevoCliente);
            return resultado;
        }

        public CLIENTES EditarCliente(CLIENTES clienteEditado)
        {
            var accion = new Acciones.Clientes();
            var resultado = accion.EditarCliente(clienteEditado);
            return resultado;
        }

        public string EliminarCliente(int clienteEliminado)
        {
            var accion = new Acciones.Clientes();
            var resultado = accion.EliminarCliente(clienteEliminado);
            return resultado;
        }

        public IList<CLIENTES> TraeClientes()
        {
            var accion = new Acciones.Clientes();
            var resultado = accion.TraeClientes();
            return resultado;
        }

        
    }
}
