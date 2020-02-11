using LibraryManagementAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI
{
    public class ApiContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        public ApiContext(DbContextOptions options) : base(options)
        {
            LoadBooks();
        }

        public void LoadBooks()
        {
            Books book = new Books()
            {
                bookName = "Good Crooks series",
                AuthorName = "Megan Frazer Blakemore",
                BookCategory = "Bloomsbury Kids",
                Edition = "First Edition",
                Price = 800,
            };
            Books.Add(book);
            Books.Add(book = new Books()
            {
                bookName = "The Spy Catchers of Maple Hill",
                AuthorName = "Megan Frazer Blakemore",
                BookCategory = "Kids",
                Edition = "Second Edition",
                Price = 700,
            });

            Books.Add(book = new Books()
            {
                bookName = "Jane, the Fox and Me",
                AuthorName = "Megan Frazer Blakemore",
                BookCategory = "Forest",
                Edition = "Third Edition",
                Price = 600,
            });


            Books.Add(book = new Books()
            {
                bookName = "Sing Sweet Nightingale",
                AuthorName = "Erica Cameron",
                BookCategory = "Songs",
                Edition = "Final Edition",
                Price = 400,
            });


            Books.Add(book = new Books()
            {
                bookName = "Breakfast Served Anytime",
                AuthorName = "Sarah Combs",
                BookCategory = "Food",
                Edition = "Seventh Edition",
                Price = 1000,
            });
        }

        public void LoadUser()
        {
            Users user = new Users()
            {
                UserName = "Thavmani",
                Email = "thavamani.90@gmail.com",
                Password = "User123",
                IsActive = true,
                IsDeleted = false
            };
            Users.Add(user);

            Users.Add(user = new Users()
            {
                UserName = "Dilip",
                Email = "dilip@gmail.com",
                Password = "User302",
                IsActive = true,
                IsDeleted = false
            });

            Users.Add(user = new Users()
            {
                UserName = "Marimuthu",
                Email = "mari@gmail.com",
                Password = "User890",
                IsActive = true,
                IsDeleted = false
            });

            Users.Add(user = new Users()
            {
                UserName = "siva",
                Email = "siva@gmail.com",
                Password = "Siva123",
                IsActive = true,
                IsDeleted = false
            });
        }


        public void LoadUserRole()
        {
          
        }

        public void LoadRole()
        {
            Roles role = new Roles()
            {
                RoleName = "Admin",
                IsActive = true,
                IsDeleted = false
            };
            Roles.Add(role);

            Roles.Add(role = new Roles()
            {
                RoleName = "User",
                IsActive = true,
                IsDeleted = false
            });

          
        }
    }
}
