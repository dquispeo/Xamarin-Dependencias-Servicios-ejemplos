using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

namespace Lab07Dependencia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryDemo());
            };
        }
        public async void BtnScanear_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanning>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtCodigo.Text = result;
                }
            }
            catch (Exception)
            {
                //throw;
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}
