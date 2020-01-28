using AppListaClientes.Models;
using AppListaClientes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaClientes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroView : ContentPage
    {
        public Cliente Cliente { get; set; }

        public CadastroView()
        {
            InitializeComponent();
            this.Cliente = new Cliente();
            this.BindingContext = new CadastroViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // TODO: adicionar checagem se os campos não estão vazios
            ListagemClientes listagem = new ListagemClientes();

            // TODO: consertar isso pra ele conseguir pegar a ref de cliente
            // TODO: adicionar try/catch aqui pro caso de dar algo errado na hora de adicionar
            listagem.Clientes.Add(Cliente);
            DisplayAlert("Cadastro", "Cadastro de " + Cliente.Nome + " efetuado", "Ok");
            Navigation.PushAsync(new ListagemView());
        }
    }
}