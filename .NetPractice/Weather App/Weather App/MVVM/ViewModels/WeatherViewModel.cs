using Newtonsoft.Json;
using Realms.Sync.Exceptions;
using System.Collections.Generic;
using System.ComponentModel;
using Weather_App.MVVM.Models;
namespace Weather_App.MVVM.ViewModels
{
    public class WeatherViewModelClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public static double Longitude;
        public static double Latitude;

        private List<ListData>? _listDatas;
        public List<ListData> ListDatas
        {
            get
            {
                return _listDatas;
            }
            set
            {
                _listDatas = value; OnPropertyChanged(nameof(ListDatas));
            }
        }

        private string? _cityNamelbl;
        public string CityNamelbl
        {
            get
            {
                return _cityNamelbl;
            }
            set
            {
                _cityNamelbl = value; OnPropertyChanged(nameof(CityNamelbl));
            }
        }

        private string? _weatherInfoNamelbl;
        public string WeatherInfoNamelbl
        {
            get
            {
                return _weatherInfoNamelbl;
            }
            set
            {
                _weatherInfoNamelbl = value; OnPropertyChanged(nameof(WeatherInfoNamelbl));
            }
        }

        private string? _cloudImageUrl;
        public string CloudImageUrl
        {
            get
            {
                return _cloudImageUrl;
            }
            set
            {
                _cloudImageUrl = value; OnPropertyChanged(nameof(CloudImageUrl));
            }
        }

        private string? _humiditylbl;
        public string Humiditylbl
        {
            get
            {
                return _humiditylbl;
            }
            set
            {
                _humiditylbl = value; OnPropertyChanged(nameof(Humiditylbl));
            }
        }

        private string? _templbl;
        public string Templbl
        {
            get
            {
                return _templbl;
            }
            set
            {
                _templbl = value; OnPropertyChanged(nameof(Templbl));
            }
        }

        private string? _speedlbl;
        public string Speedlbl
        {
            get
            {
                return _speedlbl;
            }
            set
            {
                _speedlbl = value; OnPropertyChanged(nameof(Speedlbl));
            }
        }

        public void GetWeather(dynamic root) // Assuming API returns dynamic type
        {
            ListDatas = new List<ListData>();

            CityNamelbl = root.city.name;
            try
            {
                WeatherInfoNamelbl = root.list[0].weather[0].description;
            }
            catch(JsonReaderException e)
            {
                Console.WriteLine(e.ToString());
            };
            try
            {
            CloudImageUrl = root.list[0].weather[0].imageUrl;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {

            Humiditylbl = $"{root.list[0].main.humidity} %"; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
            Templbl = $"{root.list[0].main.temp} °F"; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
            Speedlbl = $"{root.list[0].wind.speed} km/h";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            foreach (var item in root.list)
            {
                ListDatas.Add(item.ToListData());
            }
        }
        public async Task GetCurrentDeviceLocation()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();
                Latitude = location.Latitude;
                Longitude = location.Longitude;
                OnPropertyChanged(nameof(Latitude)); // Notify UI of changes
                OnPropertyChanged(nameof(Longitude)); // Notify UI of changes
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle case where location is not supported on device
                Console.WriteLine(fnsEx.ToString());
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine(ex.ToString());
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}