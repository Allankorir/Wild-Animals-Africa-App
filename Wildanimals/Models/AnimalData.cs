using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildanimals.Models
{
    public class AnimalData
    {
        public List<Animal> Animals { get; set; }
        public Animal SelectedAnimal { get; set; }

        public AnimalData()
        {
            Animals = new List<Animal>
        {
            new Animal { Name = "Gorilla", Subtitle = "Great Ape", ImagePath = "Assets/gorilla.jpg", Description = "Gorillas are ground-dwelling, predominantly herbivorous apes." },
            new Animal { Name = "Giraffe", Subtitle = "Tall Mammal", ImagePath = "Assets/giraffe.jpg", Description = "Giraffes are the tallest living terrestrial animals and the largest ruminants." },
            new Animal { Name = "Buffalo", Subtitle = "Large Bovine", ImagePath = "Assets/buffalo.jpg", Description = "Buffalo are large, even-toed ungulates native to Africa and Asia." }
        };
        }

        public Animal GetAnimalByName(string name)
        {
            return Animals.FirstOrDefault(a => a.Name == name);
        }
    }
}
