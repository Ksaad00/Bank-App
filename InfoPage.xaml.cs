using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GridTutorial
{	
	public partial class InfoPage : ContentPage
	{	
		public InfoPage ()
		{
			InitializeComponent ();

            PersonName.Text = $"Welcome, {Application.Current.Properties["Name"].ToString()}!";
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Kirollos Saad";
        }
        private void OnButtonClicked1(object sender, EventArgs e)
        {
            (sender as Button).Text = "03/08/2000";
        }
        private void OnButtonClicked2(object sender, EventArgs e)
        {
            (sender as Button).Text = "123 Main St.";
        }
        private void OnButtonClicked3(object sender, EventArgs e)
        {
            (sender as Button).Text = "New York";
        }
        private void OnButtonClicked4(object sender, EventArgs e)
        {
            (sender as Button).Text = "USA";
        }
        
        private void OnClickedAccount(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyTabbedPage());
        }
    }
}

