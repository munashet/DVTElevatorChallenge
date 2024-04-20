public class Building
{
    public List<Elevator> Elevators { get; set; }
    public int Floors { get; set; }

    public Building(int floors, int elevatorCount)
    {
        Floors = floors;
        Elevators = new List<Elevator>(elevatorCount);
        for (int i = 0; i < elevatorCount; i++)
        {
            Elevators.Add(new Elevator());
        }
    }

    public void CallElevator(int floor, int passengers)
    {
        // Find the nearest available elevator
        Elevator nearestElevator = null;
        int shortestDistance = int.MaxValue;

        foreach (var elevator in Elevators)
        {
            if (elevator.PassengerCount + passengers <= elevator.MaxPassengerCount)
            {
                int distance = Math.Abs(elevator.CurrentFloor - floor);
                if (distance < shortestDistance)
                {
                    nearestElevator = elevator;
                    shortestDistance = distance;
                }
            }
        }

        // If no elevator is available, throw an exception
        if (nearestElevator == null)
        {
            throw new InvalidOperationException("No available elevator can accommodate the number of passengers.");
        }

        // Send the nearest elevator to the requested floor
        nearestElevator.MoveToFloor(floor);
        nearestElevator.AddPassengers(passengers);
    }
}