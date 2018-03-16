using Newtonsoft.Json.Linq;
using SqlLite.UI.Data;
using SQLite;

namespace SqlLite.UI.Model
{
    public class Snow
    {
        private const string ThreeHour = "3h";

        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double H3 { get; set; }

        public Snow() { }

        public Snow(JToken snowData)
        {
            if (snowData.SelectToken(ThreeHour) != null)
                H3 = double.Parse(snowData.SelectToken(ThreeHour).ToString());
        }
    }
}
