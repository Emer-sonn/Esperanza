using Plugin.TextToSpeech;
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
	public partial class Falar : ContentPage
	{
		public Falar ()
		{
			InitializeComponent ();
		}
        private async void Falar_Clicked(object sender, EventArgs e)
        {
            var x = texto.Text;
          
            await CrossTextToSpeech.Current.Speak(x);

        }
    }
}