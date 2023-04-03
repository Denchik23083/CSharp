﻿using BooksApi.Db;
using BooksApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.WebDb.BooksRepository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksCategories()
        {
            return await _context.Books
                .Where(_ => _.CategoryId == null)
                .ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return (await _context.Books.FirstOrDefaultAsync(b => b.Id == id))!;
        }

        public async Task Create(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Book bookToUpdate, Book book)
        {
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Book bookToDelete)
        {
            _context.Books.Remove(bookToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
