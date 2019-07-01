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
	public partial class Corpo : ContentPage
	{
        string x;
		public Corpo ()
		{
			InitializeComponent ();
		}
        public  async void Cabeca_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua cabeça esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha cabeça está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha cabeça está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha cabeça está Dormente");
            }


        }

        async void Peito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu Peito esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu peito está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu peito está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu peito está Dormente");
            }
        }

        async void Barriga_Clicked(object sender, EventArgs e)
        {

             x = await DisplayActionSheet("Sua barriga esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha barriga está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha barriga está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha barriga está Dormente");
            }
        }

        async void PernaDireita_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua Perna esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha Perna está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha Perna está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha Perna está Dormente");
            }

        }

        async void JoelhoDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu joelho está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu joelho está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu joelho está Dormente");
            }

        }

        async void CanelaDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Sua canela esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está Dormente");
            }

        }

        async void PeDireita_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Dormente");
            }

        }

        async void PernaEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua perna esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Dormente");
            }

        }

        async void JoelhoEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu Joelho está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu Joelho está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu Joelho está Dormente");
            }

        }

        async void CanelaEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua canela esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha canela está Dormente");
            }

        }

        async void PeEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu péa está Dormente");
            }

        }

        async void BracoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Dormente");
            }

        }

        async void AnteBracoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Dormente");
            }

        }

        async void MaoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Dormente");
            }

        }

        async void BracoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Dormente");
            }

        }

        async void AnteBracoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço  está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Dormente");
            }

        }

        async void MaoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo", "Coçando", "Dormente");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Dormente");
            }

        }
    }
}