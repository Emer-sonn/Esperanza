using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Esperanza.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sintomas : ContentPage
	{
		public Sintomas ()
		{
			InitializeComponent ();
		}

        private void Sono(object sender, EventArgs e)
        {
            
            //sono.BorderColor = Color.Red;
            //System.Threading.Thread.Sleep(1000);
            //sono.BorderColor = Color.Blue;



        }
    }
}