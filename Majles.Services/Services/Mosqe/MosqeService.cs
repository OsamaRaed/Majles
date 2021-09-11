using Majles.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Services.Services.Mosqe
{
    public class MosqeService : IMosqeService
    {
        private readonly MajlesDbContext dbContext;

        public MosqeService(MajlesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(string name)
        {
            dbContext.Mosqes.FromSqlInterpolated
                ($"insert into Mosqes (Name,CreatedAt,UpdatedAt) values('{name}','{DateTime.Now}');");
        }

        public void Delete(string name)
        {
            dbContext.Mosqes.FromSqlInterpolated
                ($"delete from Mosqes where Name = '{name}'");
        }
    }
}
