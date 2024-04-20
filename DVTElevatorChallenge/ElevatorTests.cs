using NUnit.Framework;

[TestFixture]
public class ElevatorTests
{
    [Test]
    public void MoveToFloor_ChangesCurrentFloorAndDirection()
    {
        Elevator elevator = new Elevator();
        elevator.MoveToFloor(5);
        Assert.Equals(5, elevator.CurrentFloor);
        Assert.Equals(Direction.Up, elevator.Direction);
    }

    [Test]
    public void AddPassengers_IncreasesPassengerCount()
    {
        Elevator elevator = new Elevator();
        elevator.AddPassengers(3);
        Assert.Equals(3, elevator.PassengerCount);
    }

    [Test]
    public void AddPassengers_ThrowsExceptionWhenOverCapacity()
    {
        Elevator elevator = new Elevator { MaxPassengerCount = 5 };
        Assert.Throws<InvalidOperationException>(() => elevator.AddPassengers(6));
    }
}
