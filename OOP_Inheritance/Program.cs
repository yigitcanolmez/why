

using OOP_Inheritance.Contracts;

Vehicle vehicle = new Car('D', "CUPRA", 2002, false);

vehicle.GetVehicleDate();
vehicle.GetVehicleIsSecondHand();


Car car = new Car('D', "CUPRA", 2002, false);

car.GetVehicleDate();

car.Dispose();
Console.WriteLine();