using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GridTutorial
{	
	public partial class Balance2 : ContentPage
	{	
		public Balance2 ()
		{
			InitializeComponent ();
		}
        private void OnClickedHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
