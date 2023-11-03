using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_Accounting.Infrastructure
{
    internal static class Helper
    {
        public static async void UpDateTime()
        {
            Fields._currentTime[0] = DateTime.Now.ToString().Split(' ')[1].Remove(5, 3);
            await Task.Delay(1000);
            UpDateTime();
        }
    }
}
