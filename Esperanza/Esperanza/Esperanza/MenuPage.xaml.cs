using Esperanza.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Esperanza
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();

		}

        private void Introbtn(object sender, EventArgs e)
        {
            Detail = new Intro();
        }

        private void Sobrebtn(object sender, EventArgs e)
        {
            Detail = new Sobre();
        }

        private void Falabtn(object sender, EventArgs e)
        {
            Detail = new Falar();
        }

        private void Frasesbtn(object sender, EventArgs e)
        {
            Detail = new Frases();
        }

        private void Corpobtn(object sender, EventArgs e)
        {
            Detail = new Corpo();
        }

        private void Sintomasbtn(object sender, EventArgs e)
        {
            Detail = new Sintomas();
        }
        private void Costasbtn(object sender, EventArgs e)
        {
            Detail = new Costas();
        }
    }
}