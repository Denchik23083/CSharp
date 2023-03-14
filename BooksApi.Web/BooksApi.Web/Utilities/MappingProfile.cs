using AutoMapper;
using BookApi.Db.Entities;
using BooksApi.Web.Models;

namespace BooksApi.Web.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookWriteModel, Book>();
            CreateMap<Book, BookReadModel>();

            CreateMap<CategoryWriteModel, Category>();
            CreateMap<Category, CategoryReadModel>();
        }
    }
}
