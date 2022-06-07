using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Comp_Firm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var client = new WebClient();
            var response = client.DownloadString("http://10.0.2.2:62692/api/Components");
            LViewComponents.ItemsSource = JsonConvert.DeserializeObject<List<Components>>(response);
        }

        private void LViewComponents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
