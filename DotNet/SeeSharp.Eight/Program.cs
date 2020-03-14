//[?] C# 8.0의 새로운 기능 10가지
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeeSharp.Eight
{
    //[1] 인터페이스(Interface) 만들기 
    public interface IEmployee
    {
        public string Name { get; }
        public decimal Salary { get; }

        //[1][1] C# 8.0: Default interface members
        public string Id { get => $"{Name}[{this.GetHashCode()}]"; }
    }

    //[2] 기본 클래스(Class) 만들기
    public class Person
    {
#nullable disable
        public string Name { get; }
        public Person(string name) => Name = name;

        //[!]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
#nullable enable

        public Person(string first, string last)
        {
            FirstName = first;
            MiddleName = null;
            LastName = last;
        }

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
    }

    //[3] 추상 클래스(Abstract Class) 만들기 
    public abstract class Employee : Person, IEmployee
    {
        public Employee(string name, decimal salary)
            : base(name) => Salary = salary;
        public decimal Salary { get; protected set; }
    }


    public class Professor : Employee, IEmployee
    {
        public string Topic { get; }
        public Professor(string name, decimal salary, string topic)
            : base(name, salary) => Topic = topic;

        // Deconstruct Method: TODO: Deconstruct() Method => C# 7.0 User-Defined Types Deconstructing
        public void Deconstruct(out string name, out string topic)
            => (name, topic) = (Name, Topic);

        // 인덱스 및 범위(Indices and ranges)
        //public string Id => $"{Name}[{Topic[0..3]}]";
        public string Id => $"{Name}[{Topic[..3]}~{Topic[^3..^0]}]";
    }

    public class Administrator : Employee
    {
        public string Department { get; }
        public Administrator(string name, decimal salary, string department)
            : base(name, salary) => Department = department;
    }

    public static class Service
    {
#nullable disable
        static Person[] people = null;
#nullable enable

        static Service()
        {
            //[?] null 병합 할당(Null Coalescing Assignment) Operator: ??= 
            people ??= new Person[]
            {
                new Professor("RedPlus", 1______000, "Computer Science"),
                new Administrator("Taeyo", 2_000, "ABC"),
                new Professor("Itist", 3_000, "Computer Science")
            };
        }

        public static IEnumerable<IEmployee> GetEmployees()
        {
            foreach (var person in people)
            {
                if (person is IEmployee employee)
                {
                    yield return employee;
                }
            }
        }

        //[?] C# 8.0 비동기 스트림(Asynchronous streams)
        public static async IAsyncEnumerable<IEmployee> GetEmployeesAsync()
        {
            foreach (var person in people)
            {
                await Task.Delay(500);
                if (person is IEmployee employee) yield return employee;
            }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            //[?] C# 8.0 - 정적 로컬 함수(Static Local Function)
            static void Print(string message) => Console.WriteLine(message);

            //[A] Synchronous 
            foreach (var employee in Service.GetEmployees())
            {
                Print($"Name: {employee.Name}");
            }
            Print("========================================");
            foreach (var employee in Service.GetEmployees())
            {
                //[?] Pattern Matching: C# 7.0 Type Pattern
                if (employee is Administrator administrator
                    && administrator.Department is "ABC")
                {
                    Print($"Administrator: {administrator.Name}");
                }
            }
            Print("========================================");

            //[B] Asynchronous
            await foreach (var employee in Service.GetEmployeesAsync())
            {
                //[?] 패턴 매칭: C# 8.0 속성 패턴, Var Pattern 
                if (employee is Professor
                {
                    Topic: "Computer Science", Name: var name
                } professor)
                {
                    Print($"Professor: {name} ({professor.Id})");
                }
            }
            await foreach (var employee in Service.GetEmployeesAsync())
            {
                //[?]패턴 매칭: C# 8.0 위치 패턴(Location Pattern)
                if (employee is Professor(var name, "Computer Science") professor)
                {
                    Print($"Professor: {name} ({professor.Id})");
                }
            }

            //[?] C# 8.0 - nullable 참조 형식
            var red = new Person("YJ", "Park");
            var length = GetMiddleNameLength(red);
            Console.WriteLine(length); // 0 

            //[?] Switch 식
            Print("========================================");
            await foreach (var employee in Service.GetEmployeesAsync())
            {
                Console.WriteLine(GetDetails(employee));
            }

            static string GetDetails(IEmployee person)
            {
                return person switch
                {
                    Professor p when p.Salary > 1_000 => $"{p.Name}-{p.Topic}-Big",
                    Professor p => @$"{p.Name} - {p.Topic}",
                    Administrator a => $"{a.Name} - {a.Department}",
                    _ => $@"Who are you?"
                };
            }
        }

        static int GetMiddleNameLength(Person? person)
        {
            //[?] is { } (somthing, 사례)
            if (person?.MiddleName is { } middle) return middle.Length;
            return 0; // is null 
        }
    }
}
