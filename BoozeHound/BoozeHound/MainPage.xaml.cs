using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BoozeHound
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int legalAge = 0;
        private string country = "";
        private DateTime userBirthday;
        void Handle_Clicked(object Sender, System.EventArgs e)
        {
            
        }
    }
}