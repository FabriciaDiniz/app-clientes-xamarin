using AppListaClientes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaClientes.ViewModels
{
    public class CadastroViewModel
    {
        public Cliente Cliente { get; set; }

        public CadastroViewModel()
        {
            this.Cliente = new Cliente();
        }
    }
}
