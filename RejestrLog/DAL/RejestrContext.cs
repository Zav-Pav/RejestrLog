using RejestrLog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RejestrLog.DAL
{
    public class RejestrContext:DbContext
    {

        public RejestrContext(): base ("connectionString")
        {


        }
        public DbSet <RejestrModel>RejestrModels { get; set; }

    }
}