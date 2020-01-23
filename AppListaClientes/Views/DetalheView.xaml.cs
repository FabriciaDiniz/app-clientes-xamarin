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
        public List<Cliente> Cliente { get; set; }
        public DetalheView(Cliente cliente)
        {
            InitializeComponent();

            //estou ciente que isso é uma má prática, mas não sei como fazer direito ainda
            this.Cliente = new List<Cliente>();
            this.Title = "Detalhes Cliente";
            this.Cliente.Add(cliente);

            this.BindingContext = this;
        }
    }
}