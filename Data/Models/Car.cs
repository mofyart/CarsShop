
namespace Site_1.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort size { get; set; }
        public string oper { get; set; }
        public string dis { get; set; }
        public string raz { get; set; }
        public string proz { get; set; }
        
        public string ob { get; set; }
        public string color { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
