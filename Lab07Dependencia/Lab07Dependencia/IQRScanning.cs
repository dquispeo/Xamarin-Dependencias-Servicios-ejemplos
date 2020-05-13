using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab07Dependencia
{
    public interface IQRScanning
    {
        Task<string> ScanAsync();
    }
}
