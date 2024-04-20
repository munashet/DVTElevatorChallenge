// Create a building with 10 floors and 2 elevators
Building building = new Building(10, 2);

// Set the maximum passenger count for each elevator
foreach (var elevator in building.Elevators)
{
    elevator.MaxPassengerCount = 10;
}

// Call an elevator to the 1st floor for 3 passengers
building.CallElevator(1, 3);
Console.WriteLine($"Elevator called to floor 1. Current floor of the elevator: {building.Elevators[0].CurrentFloor}");

// Call an elevator to the 5th floor for 5 passengers
building.CallElevator(5, 5);
Console.WriteLine($"Elevator called to floor 5. Current floor of the elevator: {building.Elevators[0].CurrentFloor}");

// Call an elevator to the 10th floor for 2 passengers
building.CallElevator(10, 2);
Console.WriteLine($"Elevator called to floor 10. Current floor of the elevator: {building.Elevators[0].CurrentFloor}");