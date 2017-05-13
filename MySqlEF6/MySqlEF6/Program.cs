using MySqlEF6.Model;
using System;
using System.Data.Entity;

namespace MySqlEF6
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (var db = new MyContext())
            {
                db.Pub.Load();
                Console.WriteLine("Number of Publishers = {0}", db.Pub.Local.Count);

                foreach (var P in db.Pub.Local)
                {
                    Console.WriteLine("Number of Titles from this Publisher = {0}", P.Titles.Count);
                    foreach (var T in P.Titles)
                    {
                        Console.WriteLine("Name of Comic is {0} and Year Published is {1}", T.Name, T.Year);
                    }
                }

                Console.ReadKey();

            }
        }
    }
}
