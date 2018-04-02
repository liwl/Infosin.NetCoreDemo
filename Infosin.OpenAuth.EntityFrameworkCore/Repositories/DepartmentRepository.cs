using Infosin.OpenAuth.Domain.Entities;
using Infosin.OpenAuth.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infosin.OpenAuth.EntityFrameworkCore.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(OpenAuthDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
