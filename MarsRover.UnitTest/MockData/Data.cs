using MarsRover.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.UnitTest.MockData
{
    public static class Data
    {
        public static string Areas = "5 5";
        public static string Location = "1 2 N";
        public static string MoveData = "LMLMLMLMM";
        public static Coordinates Coordinates()
        {
            return new Coordinates
            {
                X = 1,
                Y = 2,
                Directions = Entities.Enums.Directions.N
            };
        }
    }
}
