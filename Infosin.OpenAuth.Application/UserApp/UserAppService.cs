using System;
using System.Collections.Generic;
using System.Text;
using Infosin.OpenAuth.Application.UserApp.Dtos;
using Infosin.OpenAuth.Domain.Entities;
using Infosin.OpenAuth.Domain.IRepositories;
using AutoMapper;

namespace Infosin.OpenAuth.Application.UserApp
{
    public class UserAppService : IUserAppService
    { 
        //用户管理仓储接口
        private readonly IUserRepository _repository;

        /// <summary>
        /// 构造函数 实现依赖注入
        /// </summary>
        /// <param name="userRepository">仓储对象</param>
        public UserAppService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }



        public User CheckUser(string userName, string password)
        {
            return _repository.CheckUser(userName, password);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">Id</param>
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
        /// <summary>
        /// 根据Id集合批量删除
        /// </summary>
        /// <param name="ids">Id集合</param>
        public void DeleteBatch(List<Guid> ids)
        {
            _repository.Delete(a => ids.Contains(a.Id));
        }
        /// <summary>
        /// 根据Id获取实体
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        public UserDto Get(Guid id)
        {
            return Mapper.Map<UserDto>(_repository.GetWithRoles(id));
        }

        public List<UserDto> GetUserByDepartment(Guid departmentId, int startPage, int pageSize, out int rowCount)
        {
            return Mapper.Map<List<UserDto>>(_repository.LoadPageList(startPage, pageSize, out rowCount, it => it.DepartmentId == departmentId, it => it.CreateTime));
        }

        public UserDto InsertOrUpdate(UserDto dto)
        {
            if (Get(dto.Id) != null)
                _repository.Delete(dto.Id);
            var user = _repository.InsertOrUpdate(Mapper.Map<User>(dto));
            return Mapper.Map<UserDto>(user);
        }
    }
}
