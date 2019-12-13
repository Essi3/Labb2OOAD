using System;
using System.Collections.Generic;
using Labb2OOAD.Domain.Entity;

namespace Labb2OOAD.Domain.Repository
{
    public interface IRepository
    {
        List<Astronaut> GetAstronauts();
    }
}
