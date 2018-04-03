using System;
using System.Collections.Generic;
using System.Text;
using Infosin.OpenAuth.Application.DictApp.Dtos;
using Infosin.OpenAuth.Domain.IRepositories;
using AutoMapper;

namespace Infosin.OpenAuth.Application.DictApp
{
    public class DictService : IDictService
    {

        private readonly IDictRepository _repository;
        public DictService(IDictRepository repository)
        {
            _repository = repository;
        }


        public List<DictDto> GetList(int startPage, int pageSize, out int rowCount)
        {
            var results = _repository.LoadPageList(startPage, pageSize, out rowCount, null, a => a.SortNum);
            return Mapper.Map<List<DictDto>>(results);
        }
    }
}
