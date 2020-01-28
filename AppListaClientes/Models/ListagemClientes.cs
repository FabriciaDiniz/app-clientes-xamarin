using System;
using System.Collections.Generic;
using System.Text;

namespace AppListaClientes.Models
{
    public class ListagemClientes
    {
        public List<Cliente> Clientes { get; set; }

        public ListagemClientes()
        {
            this.Clientes = new List<Cliente>();

            for (int i = 0; i < 10; i++)
            {
                string nome = "Fulano" + (i + 1);
                string email = "fulano" + (i + 1) + "@mail.com";
                this.Clientes.Add(new Cliente { Nome = nome, Email = email });
            };

        }
    }
}
