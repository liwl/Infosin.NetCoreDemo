using Infosin.OpenAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.Application.DictApp.Dtos
{
   public class DictDto
    {

        public string DictCode { get; set; }

        public string DictName { get; set; }

        public string DictDescription { get; set; }

        public int SortNum { get; set; }

        public bool IsDel { get; set; }

        public List<DictDetail> DictDetails { get; set; }
    }
}
