using System.Collections.Generic;

namespace MySqlEF6.Model
{
    public class Publisher
    {
        public Publisher()
        {
            Titles = new HashSet<Titles>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Titles> Titles { get; set; }
    }
}