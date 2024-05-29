using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.MVVM.Models
{
    public class Weather
    {
        public int id
        {
            get; set;
        }
        public string main
        {
            get; set;
        }
        public string description
        {
            get; set;
        }
        public string icon
        {
            get; set;
        }
        public string imageUrl =>string.Format($"https://openweathermap.org/img/wn/{icon}@2x.png");
    }
}
