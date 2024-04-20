using NUnit.Framework;

[TestFixture]
public class BuildingTests
{
    [Test]
    public void CallElevator_MovesElevatorToRequestedFloor()
    {
        Building building = new Building(10, 1);
        building.CallElevator(5, 3);
        Assert.Equals(5, building.Elevators[0].CurrentFloor);
    }

    [Test]
    public void CallElevator_ThrowsExceptionWhenNoAvailableElevator()
    {
        Building building = new Building(10, 1);
        building.Elevators[0].AddPassengers(10);
        Assert.Throws<InvalidOperationException>(() => building.CallElevator(5, 3));
    }
}