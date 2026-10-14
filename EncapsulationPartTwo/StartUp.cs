namespace EncapsulationPartTwo
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people that gets a bonus: ");
            var lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter full name, age, and salary for each person: ");
            var persons = new List<Person>();
            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(
                    cmdArgs[0], cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]
                    ));

                    persons.Add(person);
                }
                Console.WriteLine("Enter the bonus: ");
                var bonus = decimal.Parse(Console.ReadLine());
                persons.ForEach(p => p.IncreaseSalary(bonus));
                persons.ForEach(p => Console.WriteLine(p.ToString()));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}