using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEnviarEmail_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Application.Current.Properties.ContainsKey("email"))
                {
                    string email = Application.Current.Properties["email"] as string;
                    DisplayAlert("Mensagem", "E-mail enviado para " + email.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Mensagem", "Nenhum E-mail configurado", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void BtnConfig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
