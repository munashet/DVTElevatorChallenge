public enum Direction
{
    Up,
    Down,
    Stationary
}

public class Elevator
{
    public int CurrentFloor { get; set; }
    public Direction Direction { get; set; }
    public int PassengerCount { get; set; }
    public int MaxPassengerCount { get; set; }

    public void MoveToFloor(int floor)
    {
        if (floor == CurrentFloor)
        {
            Direction = Direction.Stationary;
        }
        else if (floor > CurrentFloor)
        {
            Direction = Direction.Up;
            CurrentFloor = floor;
        }
        else
        {
            Direction = Direction.Down;
            CurrentFloor = floor;
        }
    }

    public void AddPassengers(int count)
    {
        if (PassengerCount + count > MaxPassengerCount)
        {
            throw new InvalidOperationException("Adding more passengers would exceed the maximum capacity of the elevator.");
        }
        else
        {
            PassengerCount += count;
        }
    }
}