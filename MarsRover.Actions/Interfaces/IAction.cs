using MarsRover.Entities.Entity;
using MarsRover.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Actions.Interfaces
{
    public interface IAction
    {
        Coordinates BringTheAction(IMove _move, string areaValues, string location, string moveDirection);
    }
}
