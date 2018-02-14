using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Entreprise.Models 
{
    public class SeedData 
    {
        public static void SeedDatabase(DataContext context) 
        {
            context.Database.Migrate();
            if (context.Leads.Count() == 0) {
                context.SaveChanges();
            }
        }
    }
}