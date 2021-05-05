using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFormsRLSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var mEntry = new Entry
            {
                Placeholder = "Digite sua Senha",
                IsPassword = true
            };

            this.Content = mEntry;
        }
    }
}
