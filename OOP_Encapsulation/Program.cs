
using OOP_Encapsulation.Contracts;

Car car = new Car
{
    Brand = "BMW",
    Year = 1994
};

Car2 car2 = new Car2("BMW", 1995);

car2.Year = -1440;

Car3 car3 = new Car3(" ", 1992);

car3.GetYear();

car3.GetBrand();


Car4 car4 = new Car4();

car4.Year = 1994;
car4.Brand = " ";

Car4 car4_1 = new Car4("BMW", 1994);
