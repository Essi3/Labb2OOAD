using System;
using System.Collections.Generic;
using Labb2OOAD.Domain.Entity;
using Labb2OOAD.Domain.Repository;

namespace Labb2OOAD.Presentation
{
    public class ViewModel
    {
        private IRepository Repository;

        public ViewModel(IRepository repository)
        {
            this.Repository = repository;
        }

        public void Load()
        {
            getTodaysAstronauts(Repository.GetAstronauts());
        }

        public void getTodaysAstronauts(List<Astronaut> Astronauts)
        {
            if (Astronauts is null)
            {
                throw new ArgumentNullException(nameof(Astronauts));
            }

            // Display the Astronauts
            //Console.WriteLine("As of " + astronautList.date + " there are " + astronautList.number + " people in space:");
            Console.WriteLine();
            Console.WriteLine("Today there are " + Astronauts.Count + " people in space:");
            Console.WriteLine();

            foreach (Astronaut a in Astronauts)
            {
                // Ternary operator
                string isISS = (a.Craft == "ISS") ? "the International Space Station" : a.Craft;
                Console.WriteLine(a.Name + " is stationed on " + isISS);
            }
        }
    }
}