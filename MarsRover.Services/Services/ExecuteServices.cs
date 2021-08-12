using MarsRover.Entities.Entity;
using MarsRover.Entities.Enums;
using MarsRover.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Services.Services
{
    public class TurnLeft : IExecute
    {
        public Coordinates Execute(Coordinates c)
        {
            try
            {
                switch (c.Directions)
                {
                    case Directions.N:
                        c.Directions = Directions.W;
                        break;
                    case Directions.E:
                        c.Directions = Directions.N;
                        break;
                    case Directions.S:
                        c.Directions = Directions.E;
                        break;
                    case Directions.W:
                        c.Directions = Directions.S;
                        break;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return c;
        }
    }
    public class TurnRight : IExecute
    {
        public Coordinates Execute(Coordinates c)
        {
            try
            {
                switch (c.Directions)
                {
                    case Directions.N:
                        c.Directions = Directions.E;
                        break;

                    case Directions.E:
                        c.Directions = Directions.S;
                        break;

                    case Directions.S:
                        c.Directions = Directions.W;
                        break;

                    case Directions.W:
                        c.Directions = Directions.N;
                        break;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return c;
        }
    }
    public class MoveNext : IExecute
    {
        private List<int> _areaValues = new List<int>();
        public MoveNext(List<int> areaValues) { _areaValues = areaValues; }
        public Coordinates Execute(Coordinates c)
        {
            try
            {
                switch (c.Directions)
                {
                    case Directions.N:
                        if (c.Y >= _areaValues[1])
                            c = null;
                        else
                            c.Y += 1;
                        break;
                    case Directions.S:
                        if (c.Y != 0)
                            c.Y -= 1;
                        else
                            c = null;
                        break;
                    case Directions.E:
                        if (c.X >= _areaValues[0])
                            c = null;
                        else
                            c.X += 1;
                        break;
                    case Directions.W:
                        if (c.X != 0)
                            c.X -= 1;
                        else
                            c = null;
                        break;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return c;
        }
    }
}
