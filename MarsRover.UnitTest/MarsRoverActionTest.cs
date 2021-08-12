using MarsRover.Actions.Interfaces;
using MarsRover.Services.Interfaces;
using System;
using Xunit;
using MarsRover.Services.Services;
using MarsRover.Entities.Entity;
using MarsRover.Actions;
using FakeItEasy;
namespace MarsRover.UnitTest
{
    public class MarsRoverActionTest
    {
        private readonly IMove _move;
        private readonly IAction _action;
        public MarsRoverActionTest() { _move = A.Fake<IMove>(); _action = new RoverAction(); }
        [Fact]
        public void RoverAction_Test()
        {
            var c = MockData.Data.Coordinates();
            A.CallTo(() => _move.Move(A<IExecute>._, A<Coordinates>._)).ReturnsLazily(() => c);
            var result = _action.BringTheAction(_move, MockData.Data.Areas, MockData.Data.Location, MockData.Data.MoveData);

            Assert.Equal(c.Directions, result.Directions);
        }
    }
}
