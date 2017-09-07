using Layer1.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.DATA
{
    public class CStudentContext: DbContext
    {
        public CStudentContext() : base("dbCStudentEntities")
        {
            Database.SetInitializer<CStudentContext>(null);
        }
        public virtual int Commit()
        {
            return base.SaveChanges();
        }
        public DbSet<CStudent> CStudents { get; set; }

    }
}
