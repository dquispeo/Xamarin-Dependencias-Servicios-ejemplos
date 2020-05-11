using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Lab07Dependencia.Droid;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency(typeof(Lab07Dependencia.Droid.QRScanning))]
namespace Lab07Dependencia.Droid
{
    public class QRScanning : IQRScanning
    {
        public async Task<string> ScanAsync()
        {
            //var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Escanear cógido QR",
                BottomText = "Analizando ...",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}