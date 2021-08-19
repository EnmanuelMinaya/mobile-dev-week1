using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1Login
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {

            if (UsernameEntry.Text == null || UsernameEntry.Text == "")
                DisplayAlert("Error", "Campo Username no puede estar vacío ", "OK");
            else if (PasswordEntry.Text == null || PasswordEntry.Text == "")
                DisplayAlert("Error", "Campo Password no puede estar vacío ", "OK");
            else
                DisplayAlert("Bienvenido", "Hola " + UsernameEntry.Text, "OK");



        }
    }
}
