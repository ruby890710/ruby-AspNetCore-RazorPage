using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetetCore_RazorPage_database_07131331.Models;

namespace AspNetetCore_RazorPage_database_07131331.Data
{
    public class AspNetetCore_RazorPage_database_07131331Context : DbContext
    {
        public AspNetetCore_RazorPage_database_07131331Context (DbContextOptions<AspNetetCore_RazorPage_database_07131331Context> options)
            : base(options)
        {
        }

        public DbSet<AspNetetCore_RazorPage_database_07131331.Models.Cat> Cat { get; set; }
    }
}
