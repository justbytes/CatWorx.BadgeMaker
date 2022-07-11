using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void PrintEmployees(List<Employee> employees)
    {
        Util.PrintEmployees(employees);
       
    }
    static void Main(string[] args)
    {
        List<Employee> employees = PeopleFetcher.GetFromApi();
        Util.PrintEmployees(employees);
        Util.MakeCSV(employees);
        Util.MakeBadges(employees);
        PrintEmployees(employees);
    }
  }
}

    