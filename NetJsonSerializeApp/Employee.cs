using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetJsonSerializeApp
{
    class Employee
    {
        public string? Name {  get; set; }
        public int Age { get; set; }

        public Company? Company { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Comany: {Company}";
        }
    }

    class Company
    {
        public string Title { set; get; } = "";
        public string City { set; get; } = "";

        //public Company(string? title, string? city)
        //{
        //    Title = title;
        //    City = city;
        //}

        public override string ToString()
        {
            return $"Title: {Title}, City: {City}";
        }
    }
}
