using EFCoreSession01.DbContexts;
using EFCoreSession01.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCompanyDbContext dbContext = new MyCompanyDbContext();

            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();

            //dbContext.Database.Migrate();

            //dbContext.Employees.Where(e => e.Salary > 50000).ToList().ForEach(e => Console.WriteLine($"Id: {e.Id}, Name: {e.Name}, Salary: {e.Salary}, Age: {e.Age}"));
            //dbContext.Set<Product>().Where(p => p.Price > 100).ToList().ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}, Description: {p.Description}"));
            //dbContext.Set<Product>()>()
        }
    }
}
