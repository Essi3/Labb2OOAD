using System;
using System.Collections.Generic;
using Labb2OOAD.Domain.Entity;
using Labb2OOAD.Domain.Repository;

namespace Labb2OOAD.Data.Repository
{
    
    public class TodaysAstronauts : IRepository
    {
        public List<Astronaut> People { get; set; }
        public int Number { get; set; }
        public IRepository repository;

        //constructors
        public TodaysAstronauts(IRepository repository)
        {
            this.repository = repository;
            People = repository.GetAstronauts();
        }

        public TodaysAstronauts()
        {
        }

        //properties
        private string _date = DateTime.Today.ToString("D");

        public string date
        {
            get
            {
                return _date;
            }
        }

        public List<Astronaut> GetAstronauts()
        {
            return People;
        }
    }
}
