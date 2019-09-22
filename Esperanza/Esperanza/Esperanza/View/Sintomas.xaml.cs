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
	public partial class Sintomas : ContentPage
	{
        string x;
		public Sintomas ()
		{
			InitializeComponent ();
		}

        async void Sono(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Qual a intensidade do seu sono?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muito sono");
            }
            else 
            {
                await CrossTextToSpeech.Current.Speak("Estou pouco sonolento");
            }
        }

        async void Tontuta(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Qual a intensidade da sua tontura ?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou me sentindo muito Tonto");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estoume sentindo um pouco tonto");
            }
        }

        async void Taquicardia(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Você esta seu coração?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("meu coração está muito acelerado");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("meu coração está acelerado");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("meu coração está fraco");
            }
        }

        async void Coriza(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Seu nariz esta escorrendo?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("meu nariz está escorrendo muito");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("meu nariz está escorrendo um pouco");
            }
        }

        async void Dordecabeca(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Quanto esta a sua dor de cabeça?", "Sair", null, "Muito",  "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de cabeça");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de cabeça");
            }
        }

        async void Dordedente(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto você esta com dor de dente?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de dente");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de dente");
            }
        }

        async void Dordegarganta(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto você esta com dor de garganta", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de garganta");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de garganta");
            }
        }

        async void Febre(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto de febre você sente que esta?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita febre");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estou febril");
            }
        }

        async void Faltadear(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto de falta de ar você esta sentindo?", "Sair", null, "Muito", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita falta de ar");
            }
            else
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de falta de ar");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "Retrato");
        }

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    MessagingCenter.Send(this, "Paisagem"); //during page close setting back to portrait 
        //}
    }
}