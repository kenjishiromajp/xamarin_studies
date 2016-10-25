using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB_XF_Hello.Views
{
    public partial class NavsHomeView : ContentPage
    {
        public NavsHomeView()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage2());
        }
    }
}
