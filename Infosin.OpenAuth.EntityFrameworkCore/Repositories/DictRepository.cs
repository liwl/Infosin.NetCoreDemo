using Infosin.OpenAuth.Domain.Entities;
using Infosin.OpenAuth.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.EntityFrameworkCore.Repositories
{
    public class DictRepository : BaseRepository<Dict>, IDictRepository
    {

        public DictRepository(OpenAuthDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
