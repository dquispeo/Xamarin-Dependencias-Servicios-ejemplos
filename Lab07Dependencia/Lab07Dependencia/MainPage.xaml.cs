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
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
