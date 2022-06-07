using ConsoleApp6.Models;
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDBContext db = new SampleDBContext();
            Tblsample tblsample = new Tblsample();
            tblsample.Text = "Vikash Verma";
            db.Tblsamples.Add(tblsample);
            db.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
