using AppTweet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTweet
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            new Login();
            
        }

        private void seConnecter(object sender, EventArgs e)
        {
            Debug.WriteLine("bouton seConnecter cliqué");
            hideError();
            hideListeTweets();

            if (this.identifiant.Text == null || string.IsNullOrEmpty(this.mdp.Text.ToString()) || this.identifiant.Text.ToString().Length < 3)
            {
                this.displayError("Veuillez saisir un identifiant de plus de 3 caractères");
                hideListeTweets();
                return;
            }

            if (this.mdp.Text == null || string.IsNullOrEmpty(this.mdp.Text.ToString()) || this.mdp.Text.Length < 6)
            {
                this.displayError("Veuillez saisir un mdp de plus de 6 caractères");
                hideListeTweets();
                return;
            }

            if (this.seSouvenir.IsToggled)
            {
                DisplayAlert("Mémorisation identifiant","Vous serez automatiquement connecté à votre prochaine visite", "OK");
            }
            
            displayTweets();
        }

        private void displayError(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }

        private void hideError()
        {
            this.erreur.IsVisible = false;
        }

        private void displayTweets()
        {
            this.listeTweets.IsVisible = true;
            
        }

        private void hideListeTweets()
        {
            this.listeTweets.IsVisible = false;
        }

    }
}
