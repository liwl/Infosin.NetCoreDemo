using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.Domain.Entities
{
    /// <summary>
    /// 字典表
    /// </summary>
    public class Dict : Entity
    {
        public string DictCode { get; set; }

        public string DictName { get; set; }

        public string DictDescription { get; set; }

        public int SortNum { get; set; }

        public bool IsDel { get; set; }

        public virtual ICollection<DictDetail> DictDetails { get; set; }
    }
}
