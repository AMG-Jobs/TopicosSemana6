using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIACBibliotecaClases;

namespace SIACWEB.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string NombreCompleto { get; set; }

        public  ClienteModel() { }
        private ClienteModel(CLIENTES cliente)
        {
            this.Id = (int)cliente.ID;
            this.Nombre = cliente.NOMBRE;
            this.Apellido = cliente.APELLIDO;
            this.Provincia = cliente.PROVINCIA;
            this.Canton = cliente.CANTON;
            this.Distrito = cliente.DISTRITO;
            this.NombreCompleto = cliente.NombreCompleto;
        }
        public IList<ClienteModel> TraeClientes()
        {
            SIACService.Service1Client servicio = new SIACService.Service1Client();
            var lista = servicio.TraeClientes();
            IList<ClienteModel> listaModelos= new List<ClienteModel>();
            foreach (var item in lista)
            {
                listaModelos.Add(new ClienteModel(item));
            }
            return listaModelos;
        }

        public ClienteModel BuscarClientePorId(int id)
        {
            SIACService.Service1Client servicio = new SIACService.Service1Client();
            var elCliente=new ClienteModel(servicio.BuscarClientePorId(id));
            return elCliente;
        }

        public ClienteModel CrearCliente(ClienteModel nuevoCliente)
        {
            CLIENTES cliente = new CLIENTES();
            cliente.ID = nuevoCliente.Id;
            cliente.NOMBRE = nuevoCliente.Nombre;
            cliente.APELLIDO = nuevoCliente.Apellido;
            cliente.PROVINCIA = nuevoCliente.Provincia;
            cliente.CANTON = nuevoCliente.Canton;
            cliente.DISTRITO = nuevoCliente.Distrito;
            cliente.CONTRATOS = null;
            SIACService.Service1Client servicio = new SIACService.Service1Client();
            var resultadoWCF=servicio.CrearCliente(cliente);
            var elResultadoClientemodel = new ClienteModel(resultadoWCF);
            return elResultadoClientemodel;
        }

        public ClienteModel EditarCliente(ClienteModel clienteEditado)
        {
            CLIENTES cliente = new CLIENTES();
            cliente.ID = clienteEditado.Id;
            cliente.NOMBRE = clienteEditado.Nombre;
            cliente.APELLIDO = clienteEditado.Apellido;
            cliente.PROVINCIA = clienteEditado.Provincia;
            cliente.CANTON = clienteEditado.Canton;
            cliente.DISTRITO = clienteEditado.Distrito;
            SIACService.Service1Client servicio = new SIACService.Service1Client();
            var resultadoWCF = servicio.EditarCliente(cliente);
            var elResultadoClienteModel = new ClienteModel(resultadoWCF);
            return elResultadoClienteModel;
        }

        public string EliminarCliente(int id)
        {
            SIACService.Service1Client servicio = new SIACService.Service1Client();
            var resultado=servicio.EliminarCliente(id);
            return resultado;
        }
    }
}