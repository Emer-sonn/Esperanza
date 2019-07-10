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
             x = await DisplayActionSheet("Sua cabeça esta?", "Cancel", null, "Doendo", "Coçando", "Dormente","Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha cabeça está Desconfortavel");
            }


        }

        async void Peito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu Peito esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu peito está Desconfortavel");
            }
        }

        async void Barriga_Clicked(object sender, EventArgs e)
        {

             x = await DisplayActionSheet("Sua barriga esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha barriga está Desconfortavel");
            }
        }

        async void PernaDireita_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua Coxa esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha Coxa está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha Coxa está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha Coxa está Dormente");
            }
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha coxa está Desconfortavel");
            }

        }

        async void JoelhoDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu joelho está Desconfortavel");
            }

        }

        async void CanelaDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha perna esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Desconfortavel");
            }

        }

        async void PeDireita_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Desconfortavel");
            }

        }

        async void PernaEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Minha coxa esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Minha coxa está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Minha coxa está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("Minha coxa está Dormente");
            }
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha coxa está Desconfortavel");
            }

        }

        async void JoelhoEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu Joelho está Desconfortavel");
            }

        }

        async void CanelaEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua perna esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Desconfortavel");
            }

        }

        async void PeEsquerda_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu péa está Desconfortavel");
            }

        }

        async void BracoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Desconfortavel");
            }

        }

        async void AnteBracoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Desconfortavel");
            }

        }

        async void MaoEsquedo_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Desconfortavel");
            }

        }

        async void BracoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu Braço está Desconfortavel");
            }

        }

        async void AnteBracoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Desconfortavel");
            }

        }

        async void MaoDireito_Clicked(object sender, EventArgs e)
        {
             x = await DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
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
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Desconfortavel");
            }

        }

        async void Quadril_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu quadril esta?", "Cancel", null, "Doendo", "Coçando", "Dormente", "Desconfortavel");
            if (x == "Doendo")
            {
                await CrossTextToSpeech.Current.Speak("Meu quadril está doendo");
            }
            if (x == "Coçando")
            {
                await CrossTextToSpeech.Current.Speak("Meu quadril está Coçando");
            }
            if (x == "Dormente")
            {
                await CrossTextToSpeech.Current.Speak("MMeu quadril está Dormente");
            }
            if (x == "Desconfortavel")
            {
                await CrossTextToSpeech.Current.Speak("Meu quadril está Desconfortavel");
            }
        }

       
    }
}