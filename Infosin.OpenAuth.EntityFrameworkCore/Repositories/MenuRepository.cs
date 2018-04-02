using Infosin.OpenAuth.Domain.Entities;
using Infosin.OpenAuth.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infosin.OpenAuth.EntityFrameworkCore.Repositories
{
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(OpenAuthDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
