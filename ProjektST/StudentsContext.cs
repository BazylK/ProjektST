using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjektST
{
    public class StudentsContext: DbContext
    {
        public StudentsContext(): base("SchoolDBConnectionString")
        {
            Database.SetInitializer<StudentsContext>(new CreateDatabaseIfNotExists<StudentsContext>());
        }

        public DbSet<Student> Students { get; set; }
    }
}
