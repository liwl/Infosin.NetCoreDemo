using AutoMapper;
using Infosin.OpenAuth.Application.DepartmentApp.Dtos;
using Infosin.OpenAuth.Application.DictApp.Dtos;
using Infosin.OpenAuth.Application.MenuApp.Dtos;
using Infosin.OpenAuth.Application.RoleApp.Dtos;
using Infosin.OpenAuth.Application.UserApp.Dtos;
using Infosin.OpenAuth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infosin.OpenAuth.Application.Mappings
{
   public class MapperInitialize
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<MenuDto, Menu>();
                cfg.CreateMap<Department, DepartmentDto>();
                cfg.CreateMap<DepartmentDto, Department>();
                cfg.CreateMap<RoleDto, Role>();
                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleMenuDto, RoleMenu>();
                cfg.CreateMap<RoleMenu, RoleMenuDto>();
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserRoleDto, UserRole>();
                cfg.CreateMap<UserRole, UserRoleDto>();
                cfg.CreateMap<Dict, DictDto>();
                cfg.CreateMap<DictDetail, DictDetailDto>();
            });
        }
    }
}
