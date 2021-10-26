using System.Collections.Generic;

namespace API.Entities
{
    public class Armor
    {
        public int Id { get; set; }
        public string ArmorName { get; set; }
        public string Slug { get; set; }
        public string Rank { get; set; }
        public string Type { get; set; }
        public int SetId { get; set; }
        public int Defense { get; set; }
        public int Rarity { get; set; }
    }
}