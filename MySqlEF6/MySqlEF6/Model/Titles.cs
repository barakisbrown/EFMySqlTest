using System;


namespace MySqlEF6.Model
{
    public class Titles
    {
        public Titles()
        {
            
        }

        public int TitlesId { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}