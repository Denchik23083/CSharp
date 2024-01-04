using AutoMapper;
using IdentityApp.Db.Entities;
using IdentityApp.Web.Models;

namespace IdentityApp.Web.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, RegisterViewModel>()
                .ForMember(_ => _.UserName, _ => _.MapFrom(_ => _.UserName))
                .ForMember(_ => _.Email, _ => _.MapFrom(_ => _.Email));
        }
    }
}
