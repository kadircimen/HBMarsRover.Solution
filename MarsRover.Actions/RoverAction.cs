using MarsRover.Actions.Interfaces;
using MarsRover.Entities.Entity;
using MarsRover.Entities.Enums;
using MarsRover.Services.Interfaces;
using MarsRover.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Actions
{
    public class RoverAction : IAction
    {
        public Coordinates BringTheAction(IMove move, string areaValues, string location, string moveDirection)
        {
            var coordinates = new Coordinates();
            try
            {
                var areas = new List<int>();
                areaValues.Split(' ').ToList().ForEach(x => { areas.Add(int.Parse(x)); });
                var locations = location.Split(' ').ToList();
                coordinates.X = int.Parse(locations.First().Trim());
                coordinates.Y = int.Parse(locations[1].Trim());
                coordinates.Directions = locations.Last().ToEnumValue<Directions>();
                IExecute e;

                foreach (var md in moveDirection)
                {
                    switch (md)
                    {
                        default:
                            return null;
                        case 'L':
                            e = new TurnLeft();
                            break;
                        case 'R':
                            e = new TurnRight();
                            break;
                        case 'M':
                            e = new MoveNext(areas);
                            break;
                    }
                    var cr = move.Move(e, coordinates);
                    coordinates.Directions = cr.Directions;
                    coordinates.X = cr.X;
                    coordinates.Y = cr.Y;
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
            return coordinates;
        }
    }
}
