using AppListaClientes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaClientes.ViewModels
{
    public class DetalheViewModel
    {
        public Cliente Cliente { get; set; }

        public DetalheViewModel(Cliente cliente)
        {
            this.Cliente = cliente;
        }
    }
}
