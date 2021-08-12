using MarsRover.Entities.Entity;

namespace MarsRover.Services.Interfaces
{
    public interface IMove
    {
        Coordinates Move(IExecute e, Coordinates c);
    }
}
