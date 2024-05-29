using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_App.MVVM.Models;

namespace Weather_App.MVVM.API
{
    public static class ApiData
    {
        public static async Task<Root> GetWeatherData(double longitude,double latitude)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(String.Format($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid=4fda4948ba84441e6c2dc036bc4b0295"));
            var result = JsonConvert.DeserializeObject<Root>(response);
            return result;
        }
        public static async Task<Root> GetWeatherDataByCity(string city)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(String.Format($"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid=4fda4948ba84441e6c2dc036bc4b0295"));
            var result = JsonConvert.DeserializeObject<Root>(response);
            return result;
        }
    }
}
