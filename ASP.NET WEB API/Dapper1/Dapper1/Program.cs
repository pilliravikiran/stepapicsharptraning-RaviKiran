using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace RetrieveAll
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Server=localhost;Database=EmployeeDB;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var cars = con.Query<Car>("SELECT * FROM cars").ToList();

            cars.ForEach(car => Console.WriteLine(car));
        }
    }
}