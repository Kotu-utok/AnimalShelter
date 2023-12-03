using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<DALAnimalModel> Animals { get; set; }
        public DbSet<DalExaminationModel> Examinations { get; set; }
        public DbSet<DALPrescriptionModel> Prescriptions { get; set; }

        public MyDbContext()
        {
            
        }
        public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString = "Server=prodanimalshelter.mysql.database.azure.com;UserID=animalshelteruser;Password=Farouk12345$;Database=devanimalshelterdb;";
        //    optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));
        //}
    }
}
