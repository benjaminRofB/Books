using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Show Books");
                Console.WriteLine("3.Show Authors");
                Console.WriteLine("4.Show book author's sername");
                Console.WriteLine("5.Delete Book");
                
                string selection = Console.ReadLine();
            
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Insert Sername");
                    string sname = Console.ReadLine();

                    Console.WriteLine("Insert Title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Insert Year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    
                    
                    using (var context = new MyDbContext())
                    {
                        var name = new Name()
                        {
                            SName = sname,
                        };

                        context.Names.Add(name);
                        context.SaveChanges();

                        var book = new Book()
                        {
                            Title = title,
                            Year = year,
                            NameId = name.Id

                        };
                        context.Books.Add(book);
                        context.SaveChanges();
                    }
                    break;

                case "2":
                    using (var context = new MyDbContext())
                    {
                        var books = context.Books;
                        Console.WriteLine("All Book");
                        foreach (var book in books)
                        {
                            Console.WriteLine($"Id: {book.Id} Title: {book.Title} SerId {book.NameId}");
                        }
                    }
                        break;
                case "3":
                    using (var context = new MyDbContext())
                    {
                        var names = context.Names;
                        Console.WriteLine("All Author");
                        foreach (var name in names)
                        {
                            Console.WriteLine($"Id: {name.Id} Name: {name.SName}");

                        }
                    }
                        break;

                case "4":
                    int selectNumber = Convert.ToInt32(Console.ReadLine());
                    using (var context = new MyDbContext())
                    {
                        var books = context.Books;
                        Console.WriteLine("All Book");
                        foreach (var book in books)
                        {
                            if(selectNumber==book.NameId)
                            Console.WriteLine($"Title: {book.Title}");
                        }
                    }
                    break;

                    case "5":
                        int Ndelete = Convert.ToInt32(Console.ReadLine());
                        using (var context = new MyDbContext())
                        {
                            var books = context.Books;
                            foreach (var book in books)
                            {
                                if (Ndelete == book.Id)
                                {
                                    context.Books.Remove(book);
                                    Console.WriteLine("Book Delete");
                                }
                                else
                                    Console.WriteLine("Not Found");
                            }
                            context.SaveChanges();

                        }
                            break;
                }
            }
        }
    }
}
