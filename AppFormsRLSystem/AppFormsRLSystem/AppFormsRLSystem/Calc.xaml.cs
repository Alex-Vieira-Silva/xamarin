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
    public partial class Calc : ContentPage
    {
        public Calc()
        {
            InitializeComponent();

            var btnSomar = this.FindByName<Button>("btnSomar");
            btnSomar.Clicked += BtnSomar_Clicked;
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            var _EntryN1 = this.FindByName<Entry>("EntryN1");
            var _EntryN2 = this.FindByName<Entry>("EntryN2");

            double total = Convert.ToDouble(_EntryN1.Text) + Convert.ToDouble(_EntryN2.Text);

            DisplayAlert("Resultado", total.ToString(), "OK");
        }
    }
}
