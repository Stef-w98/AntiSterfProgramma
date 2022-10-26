using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiSterfProgramma.Model
{
    public class Weight
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("weightKg")]
        public double WeightKg { get; set; }

        [JsonProperty("weightLbs")]
        public double WeightLbs { get; set; }

        [JsonProperty("wMeasurementDateTime")]
        public DateTime WMeasurementDateTime { get; set; }

        [JsonProperty("notificationTime")]
        public DateTime NotificationTime { get; set; }

                
    }
}
