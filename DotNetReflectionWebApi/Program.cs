using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp.ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StructDemo();
            ExceptionDemo();
            ReflectionReport();

            Console.ReadLine();
        }
        struct Student
        {
            public int Id;
            public string Name;
            public double Gpa;
        }

        static void StructDemo()
        {
            Console.WriteLine("STRUCT DEMO");

            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Eren", Gpa = 2.75 },
                new Student { Id = 2, Name = "Joseph", Gpa = 2.60 },
                new Student { Id = 3, Name = "Stefan", Gpa = 2.80 }
            };

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Gpa}");
            }

            Console.WriteLine();
        }
        static void ExceptionDemo()
        {
            Console.WriteLine("EXCEPTION DEMO");

            try
            {
                Console.Write("Bir sayı gir: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Bir sayı daha gir: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Sonuç: {a / b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("HATA: Sıfıra bölme yapılamaz");
            }
            catch (FormatException)
            {
                Console.WriteLine("HATA: Sayı girmelisin");
            }
            finally
            {
                Console.WriteLine("FINALLY BLOĞU ÇALIŞTI");
            }

            Console.WriteLine();
        }
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
        class DeveloperInfoAttribute : Attribute
        {
            public string Developer { get; }
            public string Version { get; }

            public DeveloperInfoAttribute(string developer, string version)
            {
                Developer = developer;
                Version = version;
            }
        }
        [DeveloperInfo("Eren", "1.0")]
        class SampleService
        {
            [DeveloperInfo("Eren", "1.1")]
            public void MethodA() { }

            [DeveloperInfo("Eren", "1.2")]
            public void MethodB() { }

            [DeveloperInfo("Eren", "2.0")]
            public void MethodC() { }
        }

        static void ReflectionReport()
        {
            Console.WriteLine("REFLECTION ATTRIBUTE RAPORU");

            Type type = typeof(SampleService);
            Console.WriteLine($"Sınıf: {type.Name}");

            foreach (var method in type.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                var attr = method.GetCustomAttribute<DeveloperInfoAttribute>();
                if (attr != null)
                {
                    Console.WriteLine(
                        $"Metot: {method.Name} | Developer: {attr.Developer} | Version: {attr.Version}");
                }
            }

            Console.WriteLine();
        }
    }
}

