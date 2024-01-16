using AutoMapper;
using Caching.Db.Entities;
using Caching.Web.Models;

namespace Caching.Web.Utilities
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
