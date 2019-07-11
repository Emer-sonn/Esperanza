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
    public partial class Costas : ContentPage
    {
        string x;
        public Costas()
        {
            InitializeComponent();
        }

        async void Nuca_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha nuca está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha nuca está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha nuca está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha nuca está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha nuca está Desconfortavel");
            }

        }

        async void Costas_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minhas costas estão:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas costas estão doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas costas estão Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas costas estão Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas costas estão Desconfortavel");
            }
        }

        async void PernaDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha perna está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Desconfortavel");
            }
        }

        async void JoelhoDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("A parte posterior do  joelho está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do joelho está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelhoa está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelho está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelho está Desconfortavel");
            }
        }

        async void PanturilhaDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha panturilha está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Desconfortavel");
            }
        }

        async void PeDireita_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu pé está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Desconfortavel");
            }
        }

        async void PernaEsquerda_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha perna está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha perna está Desconfortavel");
            }
        }

        async void JoelhoEsquerda_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("A parte posterior do  joelho está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do joelho está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelhoa está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelho está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("A parte posterior do  joelho está Desconfortavel");
            }
        }

        async void PanturilhaEsquerda_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha panturilha está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha panturilha está Desconfortavel");
            }
        }

        async void PeEsquerda_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu pé está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu pé está Desconfortavel");
            }
        }

        async void BracoEsquedo_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu braço está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Desconfortavel");
            }
        }

        async void AnteBracoEsquedo_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu  antebraço está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Desconfortavel");
            }
        }

        async void MaoEsquedo_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha mão está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Desconfortavel");
            }
        }

        async void BracoDireito_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu braço está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu braço está Desconfortavel");
            }
        }

        async void AnteBracoDireito_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Meu  antebraço está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Meu antebraço está Desconfortavel");
            }
        }

        async void MaoDireito_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minha mão está:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minha mão está Desconfortavel");
            }
        }

        async void Nadegas_Clicked(object sender, EventArgs e)
        {
            x = await DisplayActionSheet("Minhas Nadegas estão:", "Cancel", null, "Doendo?", "Coçando?", "Dormente?", "Desconfortavel?");
            if (x == "Doendo?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas Nadegas estão doendo");
            }
            if (x == "Coçando?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas Nadegas estão Coçando");
            }
            if (x == "Dormente?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas Nadegas estão Dormente");
            }
            if (x == "Desconfortavel?")
            {
                await CrossTextToSpeech.Current.Speak("Minhas Nadegas estão Desconfortavel");
            }
        }
    }
}