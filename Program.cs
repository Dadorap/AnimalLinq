namespace AnimalLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaList = new List<Animal>()
            {
                new Animal("Boby","Dog",5,"Brown", 4, false),
                new Animal("Amora","Dog",2, "Black",4, true),
                new Animal("Sussy","Dog",1, "White",4, true),
                new Animal("Catier","Cat",15, "White",4, true),
                new Animal("Kudde","Cat",10, "Black",4, true),
                new Animal("Birdy","Hawk",18, "Gray",4, false),
            };

            //a
           var totalDogs= animaList.Where(a => a.Species == "Dog").Count();
            Console.WriteLine($"Total dogs in the list: {totalDogs}.");
            //b
            var oldestAnimal= animaList.OrderByDescending(a => a.Species).First();
            Console.WriteLine($"The oldest animal in the list is {oldestAnimal.Name}, " +
                $"aged {oldestAnimal.Age} years.");
            //c
            var vaccinatedAnimals = animaList.Where(v => v.IsVaccinated).ToList();
            vaccinatedAnimals.ForEach(a => Console.WriteLine($"{a.Name} is vaccinated"));
            //d
            var fourLegAndOlderThenThree = animaList.Where(a => a.NumberOfLegs == 4 && a.Age > 3).ToList();
            fourLegAndOlderThenThree.ForEach(a => Console.WriteLine(a.Name));
            //e
            var isThereShadow = animaList.Any(a => a.Name == "Shadow");
            var isShadow = isThereShadow ? "Yes there are animal named Shadow in the list" : "No animal named Shadow was found";
            Console.WriteLine(isShadow);


        }
    }
}
