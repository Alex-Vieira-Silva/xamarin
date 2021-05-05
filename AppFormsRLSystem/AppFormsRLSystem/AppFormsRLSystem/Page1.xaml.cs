using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFormsRLSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var btnCarregar = this.FindByName<Button>("btnCarregar");
            btnCarregar.Clicked += BtnCarregar_Clicked;
        }

        private void BtnCarregar_Clicked(object sender, EventArgs e)
        {
            var _EntryNome = this.FindByName<Entry>("EntryNome");
            string value = _EntryNome.Text;

            //DisplayAlert("Click", "Você clicou no botão", "OK");

            DisplayAlert("Click", value, "OK");
        }
    }
}
