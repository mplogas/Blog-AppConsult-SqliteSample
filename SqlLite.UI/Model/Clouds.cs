using Newtonsoft.Json.Linq;
using SqlLite.UI.Data;
using SQLite;

namespace SqlLite.UI.Model
{
    public class Clouds
    {   
        private const string AllSelector = "all";

        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double All { get; set; }

        public Clouds() { }

        public Clouds(JToken cloudsData)
        {
            All = double.Parse(cloudsData.SelectToken(AllSelector).ToString());
        }
    }
}
