using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }



        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Page2 page2= new Page2();
        //    await Navigation.PushAsync(page2);
        //}

    }
}