using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIACWEB.Models;


namespace SIACWEB.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ClienteModel cliente = new ClienteModel();
            return View(cliente.TraeClientes());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            ClienteModel cliente = new ClienteModel();
            var elCliente = cliente.BuscarClientePorId(id);
            return View(elCliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteModel model)
        {
            try
            {
                // TODO: Add insert logic here
                ClienteModel cliente = new ClienteModel();
                cliente.CrearCliente(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteModel cliente = new ClienteModel();
            var elCliente = cliente.BuscarClientePorId(id);
            return View(elCliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteModel model)
        {
            try
            {
                // TODO: Add update logic here
                ClienteModel cliente = new ClienteModel();
                cliente.EditarCliente(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteModel cliente = new ClienteModel();
            return View(cliente.BuscarClientePorId(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,ClienteModel model)
        {
            try
            {
                // TODO: Add delete logic here
                ClienteModel cliente = new ClienteModel();
                cliente.EliminarCliente(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
