﻿using BLL.Models;
using CL.DALInterface;
using System.Net;
using AutoMapper;


namespace BLL
{
    public class BooksService
    {
        private readonly IBooksRepository _booksDAL;
        private readonly IMapper _mapper;
        public BooksService(IBooksRepository booksDAL, IMapper mapper) 
        { 
            _booksDAL = booksDAL;
            _mapper = mapper;
        }
        public List<Book> GetAllBooks()
        {
            var booksDTO = _booksDAL.GetAllBooks();
            var books = _mapper.Map<List<Book>>(booksDTO);
            //foreach (var Itembook in _booksDAL.GetAllBooks())
            //{
            //    Book book = new Book
            //    {
            //        bookID = Itembook.bookID,
            //        bookName = Itembook.bookName,
            //        bookDescription = Itembook.bookDescription,
            //        bookAuthor = Itembook.bookAuthor,
            //        bookISBN = Itembook.bookISBN,
            //    };
            //    books.Add(book);
            //}
            Console.WriteLine(books);
            return books;
        }
    }
}
