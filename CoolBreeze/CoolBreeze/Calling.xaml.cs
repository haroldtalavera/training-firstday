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

	public partial class Calling : ContentPage
	{
        private string number;

        public string PhoneNumber
        {
            get { return number; }
            set { number = value; }
        }

        public Calling ()
		{
			InitializeComponent();
		}

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            LabelNumber.Text = number;

            if (number == "09201234567")
            {
                LabelName.Text = "James Yap";
                ImageCall.Source = "http://d166sg2vgpqyb1.cloudfront.net/wp-content/uploads/2018/07/10205450/Fastbreak-James-Yap.jpg";
            }
            else if (number == "09181234567")
            {
                LabelName.Text = "Kobe Bryant";
                ImageCall.Source = "https://sa.kapamilya.com/absnews/abscbnnews/media/2017/sports/12/18/kobe-bryant-24.jpg";
            }
            else
            {
                LabelName.Text = "Unknown";
                ImageCall.Source = "http://getdrawings.com/img/facebook-profile-picture-silhouette-20.jpg";
            }
        }
    }
}