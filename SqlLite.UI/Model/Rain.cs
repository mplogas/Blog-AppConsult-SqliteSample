using Newtonsoft.Json.Linq;
using SqlLite.UI.Data;
using SQLite;

namespace SqlLite.UI.Model
{
    public class Rain
    {
        private const string ThreeHour = "3h";

        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double H3 { get; set; }

        public Rain() { }

        public Rain(JToken rainData)
        {
            if (rainData.SelectToken(ThreeHour) != null)
                H3 = double.Parse(rainData.SelectToken(ThreeHour).ToString());
        }
    }
}
