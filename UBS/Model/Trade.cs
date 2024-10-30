using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBS.Model.Interface;

namespace UBS.Model
{
    public class Trade : ITrade
    {
        private string _ClientSector ;
        private double _value;

        [JsonProperty("value")]
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [JsonProperty("clientsector")]
        public string ClientSector 
        {
            get => _ClientSector ;
            set { _ClientSector = value; }
        }

        public Trade(double value, string ClientSector )
        {
            _value = value;
            _ClientSector  = ClientSector ;
        }

        public Trade()
        { }


    }
}
