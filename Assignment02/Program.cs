namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Person[] persons = new Person[3]
            //{
            //new Person { Name = "Ahmed", Age = 20 },
            //new Person { Name = "Khalid", Age = 40 },
            //new Person { Name = "Aliaa", Age = 30 }
            //};
            //Console.WriteLine("Details of persons:");
            //foreach (var person in persons)Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            #endregion

            #region Q2
            //Console.WriteLine("Enter Point 1:");
            //Point p1 = new Point { X = double.Parse(Console.ReadLine()), Y = double.Parse(Console.ReadLine()) };
            //Console.WriteLine("Enter Point 2:");
            //Point p2 = new Point { X = double.Parse(Console.ReadLine()), Y = double.Parse(Console.ReadLine()) };
            //double d = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine($"The distance between the points is: {d:F}");
            #endregion

            #region Q3
            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Name and Age for Person {i + 1}:");
            //    persons[i].Name = Console.ReadLine();
            //    persons[i].Age = int.Parse(Console.ReadLine());
            //}
            //Person old = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > old.Age)
            //        old = person;
            //}
            //Console.WriteLine($"The oldest person is {old.Name}, Age: {old.Age}");
            #endregion

            #region Q4
            //Rectangle rect = new Rectangle();
            //Console.WriteLine("Enter width:");
            //rect.Width = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter height:");
            //rect.Height = double.Parse(Console.ReadLine());
            //rect.Display();
            #endregion
        }
    }
}
