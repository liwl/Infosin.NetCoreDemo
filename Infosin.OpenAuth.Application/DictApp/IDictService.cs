using Infosin.OpenAuth.Application.DictApp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.Application.DictApp
{
    public interface IDictService
    {
        List<DictDto> GetList(int startPage, int pageSize, out int rowCount);
    }
}
