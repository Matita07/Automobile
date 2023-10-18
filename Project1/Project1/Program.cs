// Program: Car Model
/* Attributes:
    * brand
    * model
    * engineType (Petrol, Diesel, Electric)
    * color */
// Output: print of all the car's characteristics

using Project1;

// Initialize object "Car" with constructores
InheritCar myCar = new InheritCar(new Random().Next(0, 20), "Fiat", "Panda", "Blue", new Random().Next(0, 20) % 2 == 0 ? true : false, engine.Diesel, 20);

// Call print() method
//myCar.print();

// Call go() method
//Console.WriteLine(myCar.carStatus());

// Call menu() method
//myCar.getFunction();

//call input and output accelerate()
myCar.InputOutput();

//call method accelerate()
myCar.Accelerate(20, 10, 30);

//show method accelerate()
myCar.ShowAccelerate();
