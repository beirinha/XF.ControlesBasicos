using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("email"))
            {
                string email = Application.Current.Properties["email"] as string;
                swEnviar.On = true;
                txtEmail.IsVisible = true;
                txtEmail.Text = email;
            }            
        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void SwEnviar_OnChanged(object sender, ToggledEventArgs e)
        {
            txtEmail.IsVisible = swEnviar.On;
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            if (!swEnviar.On || string.IsNullOrEmpty(txtEmail.Text))
                Application.Current.Properties.Clear();
            else
                Application.Current.Properties["email"] = txtEmail.Text;
        }
    }
}