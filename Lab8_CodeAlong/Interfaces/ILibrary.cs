using System;
using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary.Interfaces
{

    public interface ILibrary : IReadOnlyCollection<Book>
    {

        void Add(string title, string firstName, string lastName, int numberOfPages);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found.</returns>
        Book Borrow(string title);

        /// <summary>
        /// Return a Book to the library.
        /// </summary>
        void Return(Book book);


    }

    public class Library : ILibrary
    {
        private readonly Dictionary<string, Book> books = new Dictionary<string, Book>();
        // public int Count {get; set;} = 0;
        public int Count => books.Count;

        public void Add(string title, string firstname, string lastname, int numberOfPages)
        {
            Book book = new Book
            {
                Title = title,
                Author = new Author
                {
                    FirstName = firstname,
                    LastName = lastname
                },
                NumPages = numberOfPages,
            };
            //book is added to dictionary
            books.Add(title, book); //adding book to dictionary

        }

        public Book Borrow(string title)
        {

            if (!books.ContainsKey(title))
            {
                return null;
            }
            Book book = books[title]; //finds the book that matches the title
            books.Remove(title); //obj.Remove (removes book from library)
            return book; //returns book that was borrowed
        }

        //return book to library
        public void Return(Book book)
        {
            books.Add(book.Title, book);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in books.Values)
            {
                yield return book;
            }
        }

            IEnumerator IEnumerable.GetEnumerator()
        {
                return GetEnumerator();
            }

        }//end of Book Borrow
    }

