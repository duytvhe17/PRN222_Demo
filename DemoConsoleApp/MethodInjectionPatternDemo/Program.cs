﻿using System;
using MethodInjectionPatternDemo.Model;
using MethodInjectionPatternDemo.Model;
using Microsoft.Extensions.DependencyInjection;

namespace MethodInjectionPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IDepartment, Marketing>()
                .AddTransient<Employee>()
                .BuildServiceProvider();

            Employee emp1 = serviceProvider.GetService<Employee>();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "Jack";
            emp1.AssignDepartment(serviceProvider.GetService<IDepartment>());

            Employee emp2 = serviceProvider.GetService<Employee>();
            emp2.AssignDepartment(serviceProvider.GetService<IDepartment>());
            emp2.EmployeeId = 2;
            emp2.EmployeeName = "David";

            Console.WriteLine(emp1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(emp2);
            Console.ReadLine();
        } //end Main
    } //end Program
}
