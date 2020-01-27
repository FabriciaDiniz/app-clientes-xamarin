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
        public string Nome { get; set; }
        public string Email { get; set; }

        public CadastroView()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // TODO: adicionar checagem se os campos não estão vazios
            ListagemView lv = new ListagemView();
            lv.Clientes.Add(new Cliente { Nome = Nome, Email = Email });
            DisplayAlert("Cadastro", "Cadastro de " + Nome + " efetuado", "Ok");
            Navigation.PushAsync(lv);
        }
    }
}