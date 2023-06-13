using BlackBooksApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackBooksApp.DAL
{
    public class BookshopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookshopContext>
    {
        protected override void Seed(BookshopContext context)
        {
            var types = new List<Models.Type>
            {
                new Models.Type { Category = "Fiction", Description = "Novels and Stories" },
                new Models.Type { Category = "Non-fiction", Description = "Biographies" },
                new Models.Type { Category = "Thriller", Description = "Suspense and Action" },
                new Models.Type { Category = "Romance", Description = "Love and Relationships" },
                new Models.Type { Category = "Mystery", Description = "Detective and Crime" },
                new Models.Type { Category = "Science Fiction", Description = "Fantasy and Futuristic" },
                new Models.Type { Category = "Self-help", Description = "Personal Development" },
                new Models.Type { Category = "History", Description = "Past Events and Civilizations" },
                new Models.Type { Category = "Biography", Description = "Life Stories of Individuals" },
                new Models.Type { Category = "Cooking", Description = "Recipes and Culinary Arts" }
            };
            types.ForEach(s => context.Types.Add(s));
            context.SaveChanges();

            var publhouses = new List<PublishingHouse>
            {
                new PublishingHouse { Name = "ABC Publishing", Address = "123 Main Street, Manila, Philippines", Phone = "+63 1234567890" },
                new PublishingHouse { Name = "XYZ Publishers", Address = "456 Elm Avenue, Cebu City, Philippines", Phone = "+63 9876543210" },
                new PublishingHouse { Name = "Sunrise Books", Address = "789 Oak Lane, Quezon City, Philippines", Phone = "+63 8765432109" },
                new PublishingHouse { Name = "Golden Publishing", Address = "321 Pine Road, Makati City, Philippines", Phone = "+63 7654321098" },
                new PublishingHouse { Name = "Rainbow Press", Address = "555 Maple Street, Davao City, Philippines", Phone = "+63 6543210987" },
                new PublishingHouse { Name = "Silver Publications", Address = "777 Birch Avenue, Pasig City, Philippines", Phone = "+63 5432109876" },
                new PublishingHouse { Name = "Globe Books", Address = "222 Cedar Lane, Mandaluyong City, Philippines", Phone = "+63 4321098765" },
                new PublishingHouse { Name = "Star Publishing", Address = "888 Ash Street, Taguig City, Philippines", Phone = "+63 3210987654" },
                new PublishingHouse { Name = "Pacific Publishers", Address = "999 Willow Road, Caloocan City, Philippines", Phone = "+63 2109876543" },
                new PublishingHouse { Name = "Sunset Books", Address = "444 Elm Street, Parañaque City, Philippines", Phone = "+63 1098765432" }
            };
            publhouses.ForEach(s => context.PublishingHouses.Add(s));
            context.SaveChanges();

            var suppliers = new List<Supplier>
            {
                new Supplier { Name = "ABC Books Supplier", ContactPerson = "John Doe", Position = "Sales Manager", Address = "123 Main Street, Manila, Philippines", Phone = "+63 1234567890", AboutCompany = "ABC Books Supplier is a leading distributor of educational books in the Philippines, providing a wide range of textbooks, reference materials, and learning resources to schools and institutions." },
                new Supplier { Name = "XYZ Publishers and Distributors", ContactPerson = "Jane Smith", Position = "Sales Representative", Address = "456 Elm Avenue, Cebu City, Philippines", Phone = "+63 9876543210", AboutCompany = "XYZ Publishers and Distributors is a reputable supplier of fiction and non-fiction books, catering to various genres and interests. We pride ourselves on delivering high-quality books to bookstores and online retailers." },
                new Supplier { Name = "Rainbow Bookstore", ContactPerson = "David Lee", Position = "Owner", Address = "789 Oak Lane, Quezon City, Philippines", Phone = "+63 8765432109", AboutCompany = "Rainbow Bookstore is a local independent bookstore dedicated to promoting local authors and showcasing a diverse collection of books. We support the Philippine publishing industry by partnering with local publishers and authors." },
                new Supplier { Name = "Sunrise Publishing House", ContactPerson = "Maria Garcia", Position = "Procurement Manager", Address = "321 Pine Road, Makati City, Philippines", Phone = "+63 7654321098", AboutCompany = "Sunrise Publishing House is a well-established publishing company in the Philippines. We collaborate with local and international authors to produce high-quality books across various genres, including literature, history, and self-help." },
                new Supplier { Name = "Golden Book Distributors", ContactPerson = "Michael Tan", Position = "Sales Executive", Address = "555 Maple Street, Davao City, Philippines", Phone = "+63 6543210987", AboutCompany = "Golden Book Distributors is a reliable supplier of children's books and educational materials. We work closely with schools, libraries, and retailers to provide engaging and educational resources that inspire young readers." },
                new Supplier { Name = "Silver Publications", ContactPerson = "Anna Reyes", Position = "Business Development Manager", Address = "777 Birch Avenue, Pasig City, Philippines", Phone = "+63 5432109876", AboutCompany = "Silver Publications is a renowned publisher and distributor of academic and professional books. We specialize in delivering high-quality textbooks, research materials, and reference books to universities, colleges, and professionals in various fields." },
                new Supplier { Name = "Globe Books and Stationery", ContactPerson = "Robert Santos", Position = "Operations Manager", Address = "222 Cedar Lane, Mandaluyong City, Philippines", Phone = "+63 4321098765", AboutCompany = "Globe Books and Stationery offers a wide range of books, stationery items, and school supplies. We supply educational materials to schools, colleges, and offices, ensuring access to essential resources for learning and productivity." },
                new Supplier { Name = "Star Publishing Company", ContactPerson = "Linda Cruz", Position = "Marketing Coordinator", Address = "888 Ash Street, Taguig City, Philippines", Phone = "+63 3210987654", AboutCompany = "Star Publishing Company is a leading provider of academic books and reference materials for universities and libraries. We collaborate with renowned authors and scholars to publish authoritative and comprehensive resources." },
                new Supplier { Name = "Pacific Books and More", ContactPerson = "Joseph Lim", Position = "Sales and Marketing Director", Address = "999 Willow Road, Caloocan City, Philippines", Phone = "+63 2109876543", AboutCompany = "Pacific Books and More is a supplier of a wide range of books, from bestsellers to niche genres. We offer competitive prices and timely delivery, catering to the needs of bookstores, online retailers, and individual customers." },
                new Supplier { Name = "Sunset Publishers", ContactPerson = "Mary Torres", Position = "Business Manager", Address = "444 Elm Street, Parañaque City, Philippines", Phone = "+63 1098765432", AboutCompany = "Sunset Publishers is a publishing company committed to promoting local literature and supporting Filipino authors. We publish books across various genres, including fiction, poetry, and regional literature." }
            };
            suppliers.ForEach(s => context.Suppliers.Add(s));
            context.SaveChanges();

            var books = new List<Book>
            {
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var deliveries = new List<Delivery>
            {
                new Delivery { Name = "BoxBerry", Phone = "+63 800 222 8000", Cost = 201 },
                new Delivery { Name = "Swift Delivery", Phone = "+63 877 123 4567", Cost = 150 },
                new Delivery { Name = "Book Express", Phone = "+63 900 987 6543", Cost = 180 },
                new Delivery { Name = "Bookworm Delivery", Phone = "+63 955 543 2109", Cost = 220 },
                new Delivery { Name = "Speedy Books", Phone = "+63 933 654 3210", Cost = 190 },
                new Delivery { Name = "Literary Logistics", Phone = "+63 977 876 5432", Cost = 205 },
                new Delivery { Name = "Book Courier", Phone = "+63 922 345 6789", Cost = 175 },
                new Delivery { Name = "Rapid Readers", Phone = "+63 988 987 6543", Cost = 195 },
                new Delivery { Name = "Novel Dispatch", Phone = "+63 966 432 1098", Cost = 210 },
                new Delivery { Name = "PageTurner Delivery", Phone = "+63 977 210 9876", Cost = 215 }
            };
            deliveries.ForEach(s => context.Deliveries.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { Name = "John Smith", Birthday = "17.07.1963", Address = "123 Main Street, Manila, Philippines", Phone = "+63 1234567890", Position = "Delivery Driver" },
                new Employee { Name = "Jane Doe", Birthday = "05.12.1978", Address = "456 Elm Avenue, Cebu City, Philippines", Phone = "+63 9876543210", Position = "Dispatch Coordinator" },
                new Employee { Name = "Michael Johnson", Birthday = "28.03.1985", Address = "789 Oak Lane, Quezon City, Philippines", Phone = "+63 8765432109", Position = "Operations Manager" },
                new Employee { Name = "Maria Garcia", Birthday = "10.09.1990", Address = "321 Pine Road, Makati City, Philippines", Phone = "+63 7654321098", Position = "Customer Service Representative" },
                new Employee { Name = "David Lee", Birthday = "21.06.1982", Address = "555 Maple Street, Davao City, Philippines", Phone = "+63 6543210987", Position = "Warehouse Supervisor" },
                new Employee { Name = "Anna Reyes", Birthday = "12.02.1975", Address = "777 Birch Avenue, Pasig City, Philippines", Phone = "+63 5432109876", Position = "Logistics Coordinator" },
                new Employee { Name = "Robert Santos", Birthday = "08.11.1987", Address = "222 Cedar Lane, Mandaluyong City, Philippines", Phone = "+63 4321098765", Position = "Fleet Manager" },
                new Employee { Name = "Linda Cruz", Birthday = "19.09.1993", Address = "888 Ash Street, Taguig City, Philippines", Phone = "+63 3210987654", Position = "Route Planner" },
                new Employee { Name = "Joseph Lim", Birthday = "03.04.1980", Address = "999 Willow Road, Caloocan City, Philippines", Phone = "+63 2109876543", Position = "Operations Supervisor" },
                new Employee { Name = "Mary Torres", Birthday = "14.01.1988", Address = "444 Elm Street, Parañaque City, Philippines", Phone = "+63 1098765432", Position = "Delivery Coordinator" }
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var clients = new List<Client>
            {
                new Client { Name = "John Smith", Birthday = "11.01.1998", Address = "123 Main Street, Manila, Philippines", Phone = "+63 1234567890" },
                new Client { Name = "Jane Doe", Birthday = "22.03.1985", Address = "456 Elm Avenue, Cebu City, Philippines", Phone = "+63 9876543210" },
                new Client { Name = "Michael Johnson", Birthday = "07.07.1990", Address = "789 Oak Lane, Quezon City, Philippines", Phone = "+63 8765432109" },
                new Client { Name = "Maria Garcia", Birthday = "15.09.1982", Address = "321 Pine Road, Makati City, Philippines", Phone = "+63 7654321098" },
                new Client { Name = "David Lee", Birthday = "30.05.1995", Address = "555 Maple Street, Davao City, Philippines", Phone = "+63 6543210987" },
                new Client { Name = "Anna Reyes", Birthday = "12.11.1988", Address = "777 Birch Avenue, Pasig City, Philippines", Phone = "+63 5432109876" },
                new Client { Name = "Robert Santos", Birthday = "03.04.1993", Address = "222 Cedar Lane, Mandaluyong City, Philippines", Phone = "+63 4321098765" },
                new Client { Name = "Linda Cruz", Birthday = "17.08.1980", Address = "888 Ash Street, Taguig City, Philippines", Phone = "+63 3210987654" },
                new Client { Name = "Joseph Lim", Birthday = "26.12.1997", Address = "999 Willow Road, Caloocan City, Philippines", Phone = "+63 2109876543" },
                new Client { Name = "Mary Torres", Birthday = "09.06.1986", Address = "444 Elm Street, Parañaque City, Philippines", Phone = "+63 1098765432" }
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();

            var orders = new List<Purchase>
            {
            };
            orders.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var ordered = new List<Purchased>
            {
            };
            ordered.ForEach(s => context.PurchasedBooks.Add(s));
            context.SaveChanges();
        }
    }
}