using System;
namespace Labb2OOAD.Domain.Entity
{
    public class Astronaut
    {
        //constructors
        public Astronaut() { }
        public Astronaut(string astronautName, string spaceship)
        {
            Name = astronautName;
            Craft = spaceship;
        }

        //properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Craft { get; set; }
    }
}
