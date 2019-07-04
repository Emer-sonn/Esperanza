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
            x = await DisplayActionSheet("Qual a intensidade do seu sono?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muito sono");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou sonolento ");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou pouco sonolento");
            }
        }

        async void Tontuta(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Qual a intensidade da sua tontura ?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou muito Tonto");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou tonto");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com pouco");
            }
        }

        async void Taquicardia(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Você esta seu coração?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Muito acelerado");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Acelerado");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Esta fraco");
            }
        }

        async void Coriza(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto o seu nariz esta escorrendo?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Escorrendo muito");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("escorrendo");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Escorrendo um pouco");
            }
        }

        async void Dordecabeca(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Qaunto esta a sua dor de cabeça?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de cabeça");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou com dor de cabeça");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de cabeça");
            }
        }

        async void Dordedente(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto você esta com dor de dente?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de dente");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou com dor de dente");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de dente");
            }
        }

        async void Dordegarganta(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto você esta com dor de garganta", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita dor de garganta");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou com dor de garganta");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de dor de garganta");
            }
        }

        async void Febre(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto de febre você sente que esta?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita febre");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou com febre");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com pouca febre");
            }
        }

        async void Faltadear(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("O quanto de falta de ar você esta sentindo?", "Sair", null, "Muito", "Médio", "Pouco");
            if (x == "Muito")
            {
                await CrossTextToSpeech.Current.Speak("Estou com muita falta de ar");
            }
            if (x == "Médio")
            {
                await CrossTextToSpeech.Current.Speak("Estou com falta de ar");
            }
            if (x == "Pouco")
            {
                await CrossTextToSpeech.Current.Speak("Estou com um pouco de falta de ar");
            }
        }
    }
}