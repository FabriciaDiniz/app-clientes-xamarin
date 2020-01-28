using AppListaClientes.Models;
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

    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
        }

        private void ListViewClientes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var cliente = (Cliente)e.Item;

            Navigation.PushAsync(new DetalheView(cliente));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }
    }
}
