using AppListaClientes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaClientes.ViewModels
{
    public class ListagemViewModel
    {
        public List<Cliente> Clientes { get; set; }

        public ListagemViewModel()
        {
            this.Clientes = new ListagemClientes().Clientes;
        }

    }
}
