using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppListaClientes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

    }
    public partial class MainPage : ContentPage
    {

        public List<Cliente> Clientes { get; set; }
        public MainPage()
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

        private void listViewClientes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var cliente = (Cliente)e.Item;

            DisplayAlert("Lista Clientes", string.Format("Você selecionou o cliente {0}", 
                cliente.Nome), "Ok");
        }
    }
}
