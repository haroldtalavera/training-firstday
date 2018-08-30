using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolBreeze
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


        private void Button1_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button1.Text;
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button2.Text;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button3.Text;
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button4.Text;
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button5.Text;
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button6.Text;
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button7.Text;
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button8.Text;
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button9.Text;
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text + Button0.Text;
        }

        private void ButtonDial_Clicked(object sender, EventArgs e)
        {
            Calling pageCalling = new Calling();
            pageCalling.PhoneNumber = LabelNumber.Text;

            Navigation.PushAsync(pageCalling);
        }

        private void LabelNumber_Clicked(object sender, EventArgs e)
        {
            LabelNumber.Text = LabelNumber.Text.Substring(0, LabelNumber.Text.Length - 1);
        }

        private void ButtonContacts_Clicked(object sender, EventArgs e)
        {
            Contacts contactPage = new Contacts();

            Navigation.PushAsync(contactPage);
        }
    }
}
