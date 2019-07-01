using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Esperanza.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Intro : ContentPage
	{
		public Intro ()
		{
			InitializeComponent ();
		}
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }
}