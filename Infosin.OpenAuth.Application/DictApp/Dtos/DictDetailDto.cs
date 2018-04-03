using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.Application.DictApp.Dtos
{
   public class DictDetailDto
    {
        public string DictDetailsCode { get; set; }

        public string DictDetailsName { get; set; }

        public string DictDetailsDescription { get; set; }

        public int SortNum { get; set; }

        public bool IsDel { get; set; }


    }
}
