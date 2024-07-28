using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildanimals.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }

        public void UpdateAnimal(string name, string subtitle, string imagePath, string description)
        {
            Name = name;
            Subtitle = subtitle;
            ImagePath = imagePath;
            Description = description;
        }
    }
}
