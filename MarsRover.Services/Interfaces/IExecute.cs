using MarsRover.Entities.Entity;
using System.Collections.Generic;

namespace MarsRover.Services.Interfaces
{
    public interface IExecute
    {
        Coordinates Execute(Coordinates c);
    }
}
