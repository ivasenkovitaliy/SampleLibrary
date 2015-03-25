using System;
using System.Linq;
using Data.Repositories;

namespace Client__Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            var categoryRepository = new CategoryRepository();

            var categories = categoryRepository.All().ToList();

            foreach (var category in categories)
            {
                Console.WriteLine(category.Name);
            }

            Console.ReadLine();
        }
    }
}
