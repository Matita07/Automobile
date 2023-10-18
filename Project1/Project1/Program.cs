// Program: Car Model
/* Attributes:
    * brand
    * model
    * engineType (Petrol, Diesel, Electric)
    * color */
// Output: print of all the car's characteristics

using Project1;

// Initialize object "Car" with constructores
InheritCar myCar = new InheritCar(new Random().Next(50, 100), "Fiat", "Panda", "Blue", false, engine.Diesel, new Random().Next(50, 100));

// Call print() method
//myCar.print();

// Call go() method
//Console.WriteLine(myCar.carStatus());

// Call menu() method
myCar.getFunction();
