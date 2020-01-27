using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ExemploWebAPI.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace ExemploWebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        private static List<Cliente> ListaDeClientes = new List<Cliente>();


        [System.Web.Http.HttpGet]
        public List<Cliente> GetClientes()
        {
            return ListaDeClientes;
        }


        [System.Web.Http.HttpDelete]
        public void Delete(string nome)
        {
            ListaDeClientes.RemoveAt(ListaDeClientes.IndexOf(ListaDeClientes.First(x => x.Nome.Equals(nome))));

            //foreach (var item in ListaDeClientes)
            //{
            //    if (item.Nome == nome)
            //    {
            //        ListaDeClientes.Remove(item);
            //    }
            //}
        }


        [HttpPostAttribute]
        public void Post(string nome)
        {

            if (!string.IsNullOrEmpty(nome))
            {
                ListaDeClientes.Add(new Cliente(nome));
            }
        }
    }
}