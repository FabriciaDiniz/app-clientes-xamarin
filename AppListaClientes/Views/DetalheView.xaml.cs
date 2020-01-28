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
    public partial class DetalheView : ContentPage
    {
        public DetalheView(Cliente cliente)
        {
            InitializeComponent();
            this.Title = "Detalhes Cliente";
            this.BindingContext = new DetalheViewModel(cliente);
        }
    }
}