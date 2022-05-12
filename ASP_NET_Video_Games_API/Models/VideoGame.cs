using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Video_Games_API.Models
{
    public class VideoGame
    {
        //C# Properties
        [Key]//<- this KEY inside an array needs to be here to use the ID property and allows the ID property to be used as the Primary Key and auot increment
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        // ? after a datatype means it is nullable(set to 0)
        public int? Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        // double means- allows the integers to be decimal type up to 15 digits
        public double NorthAmericaSales { get; set; }
        public double EuropeSales { get; set; }
        public double JapanSales { get; set; }
        public double OtherSales { get; set; }
        public double GlobalSales { get; set; }
    }
}
