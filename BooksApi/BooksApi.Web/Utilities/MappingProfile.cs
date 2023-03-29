using AutoMapper;
using BooksApi.Db.Entities;
using BooksApi.Web.Models.BooksModels;
using BooksApi.Web.Models.CategoriesModels;

namespace BooksApi.Web.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BooksWriteModel, Book>();
            CreateMap<Book, BooksReadModel>();

            CreateMap<CategoriesWriteModel, Category>();
            CreateMap<Category, CategoriesReadModel>();
        }
    }
}
