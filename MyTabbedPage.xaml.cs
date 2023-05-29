using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridTutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage ()
        {
            InitializeComponent();
        }
        private void OnClickedBalance(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BalancePage());
        }
        private void OnClickedBalance2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Balance2());
        }

    }
}
