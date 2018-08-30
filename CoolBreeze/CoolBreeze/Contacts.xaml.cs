using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolBreeze
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contacts : ContentPage
	{
		public Contacts ()
		{
			InitializeComponent ();
		}

        private void ButtonJames_Clicked(object sender, EventArgs e)
        {
            Calling pageCalling = new Calling();
            pageCalling.PhoneNumber = ButtonJamesNumber.Text;

            Navigation.PushAsync(pageCalling);
        }

        private void ButtonJamesNumber_Clicked(object sender, EventArgs e)
        {
            Calling pageCalling = new Calling();
            pageCalling.PhoneNumber = ButtonJamesNumber.Text;

            Navigation.PushAsync(pageCalling);
        }

        private void ButtonKobe_Clicked(object sender, EventArgs e)
        {
            Calling pageCalling = new Calling();
            pageCalling.PhoneNumber = ButtonKobeNumber.Text;

            Navigation.PushAsync(pageCalling);
        }

        private void ButtonKobeNumber_Clicked(object sender, EventArgs e)
        {
            Calling pageCalling = new Calling();
            pageCalling.PhoneNumber = ButtonKobeNumber.Text;

            Navigation.PushAsync(pageCalling);
        }
    }
}