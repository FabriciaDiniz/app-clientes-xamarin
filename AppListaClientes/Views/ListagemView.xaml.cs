using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppListaClientes.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

    }
    public partial class ListagemView : ContentPage
    {

        public List<Cliente> Clientes { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Clientes = new List<Cliente>();

            for (int i = 0; i < 10; i++)
            {
                string nome = "Fulano" + (i + 1);
                string email = "fulano" + (i + 1) + "@mail.com";
                this.Clientes.Add(new Cliente { Nome = nome, Email = email });
            };

            this.BindingContext = this;
            
        }

        private void ListViewClientes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var cliente = (Cliente)e.Item;

            Navigation.PushAsync(new DetalheView(cliente));
        }
    }
}
