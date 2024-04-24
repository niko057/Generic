namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<Employee> customCollection = new CustomCollection<Employee>();

            string choice;
            do
            {
                Console.WriteLine("1) Employee Elave Etmek");
                Console.WriteLine("2) ID- ye gore Getirsin Melumatlari");
                Console.WriteLine("3) Butun Employeelari cixartsin");
                Console.Write("Seciminizi edin: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string surname = Console.ReadLine();
                        Console.Write("Yas: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Maas: ");
                        double salary = double.Parse(Console.ReadLine());

                        customCollection.Add(new Employee(name, surname, age, salary));
                        break;
                    case 2:
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Employee emp = customCollection.GetById(id);
                        if (emp != null)
                        {
                            Console.WriteLine($"Id: {emp.Id}, Ad: {emp.Name}, Soyad: {emp.Surname}, Yas: {emp.Age}, Maas: {emp.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Istifadeci tapilmadi");
                        }
                        break;
                    case 3:
                        customCollection.PrintAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim.");
                        break;
                }

                Console.Write("Davam etmek isteyirsizmi? (yes/no): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "yes");
        }
    }
}