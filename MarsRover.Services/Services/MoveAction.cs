using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Entities.Entity;
using MarsRover.Services.Interfaces;
namespace MarsRover.Services.Services
{
    public class MoveAction : IMove
    {
        public Coordinates Move(IExecute e, Coordinates c)
        {
            return e.Execute(c);
        }
    }
}
