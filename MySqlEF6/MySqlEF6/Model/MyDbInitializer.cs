using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MySqlEF6.Model
{
    public class MyDbInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            var P = new Publisher();
            P.Name = "Image";

            var T = new Titles();
            T.Name = "Spawn";
            T.Year = DateTime.Now;

            P.Titles = new List<Titles>();
            P.Titles.Add(T);

            context.Pub.Add(P);
            context.SaveChanges();
        }
    }
}