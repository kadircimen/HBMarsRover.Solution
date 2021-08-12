using Microsoft.Extensions.DependencyInjection;
using System;
using MarsRover.Actions;
using MarsRover.Actions.Interfaces;
using MarsRover.Services.Interfaces;
using MarsRover.Services.Services;
using MarsRover.Entities.Entity;
namespace MarsRover.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var areas = Console.ReadLine();
            var location = Console.ReadLine();
            var moveDirection = Console.ReadLine();

            var services = new ServiceCollection();
            services.AddSingleton<IAction, RoverAction>();
            services.AddSingleton<IMove, MoveAction>();
            var servicePr = services.BuildServiceProvider(true);
            var _appService = servicePr.GetService<IAction>();
            var _mover = servicePr.GetService<IMove>();

            var coordinates = _appService.BringTheAction(_mover, areas, location, moveDirection);



            Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.Directions);


        }
    }
}
