using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.MVVM.Models
{
    public class ListData
    {
         
        public int dt
        {
            get; set;
        }
        public string CurrentDateTime => UtcTimeLibrary.UtcTimeStamp.ConvertToUtc(dt);
        public Main main
        {
            get; set;
        }
        public List<Weather> weather
        {
            get; set;
        }
        public Clouds clouds
        {
            get; set;
        }
        public Wind wind
        {
            get; set;
        }
        public int visibility
        {
            get; set;
        }
        public int pop
        {
            get; set;
        }
        public Sys sys
        {
            get; set;
        }
        public string dt_txt
        {
            get; set;
        }
    
}
}
