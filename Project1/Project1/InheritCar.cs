namespace Project1
{
    internal class InheritCar : Car
    {
        #region Constructors
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public InheritCar() { }

        /// <summary>
        /// Constructors with superclass parameters
        /// </summary>
        /// <param name="petrolLevel"> car's level of petrol </param>
        /// <param name="brand"> car's brand </param>
        /// <param name="model"> car's model </param>
        /// <param name="color"> car's body color </param>
        /// <param name="on"> check if the car in on or off </param>
        /// <param name="engineType"> car's type of engine </param>
        public InheritCar(int petrolLevel, string brand, string model, string color, bool on, engine engineType, int speed) : base(petrolLevel, brand, model, color, on, engineType, speed) {}
        #endregion

        #region Methods
        /// <summary>
        /// Creating and printing the menu
        /// </summary>
        private void menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Start");
            Console.WriteLine("2 - Stop");
            Console.WriteLine("3 - Refill");
            Console.WriteLine("4 - Accellerate");
            Console.WriteLine("5 - Slow Down");
            Console.WriteLine("N - Exit");
        }

        /// <summary>
        /// Method that calls the method chosen by input with numbers (menu())
        /// </summary>
        public void getFunction()
        {
            // Call menu() method
            this.menu();

            // Choice variable
            int choice;

            // Do-While cicle for choice check
            do
            {
                // Choice input
                Console.Write("\nChoose: ");
                Int32.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine();

                // Switch for options
                switch (choice)
                {
                    case 1:
                        // Starting the vehicle
                        this.start();
                        break;
                    case 2:
                        // Stopping the vehicle
                        this.stop();
                        break;
                    case 3:
                        // Check if Petrol Level is full
                        if (this.petrolLevel == 100)
                            Console.WriteLine("\nPetrol Level is already full!");
                        else
                            // Refill the vehicle with refill(...) method calling getFillChoice()
                            this.refill(this.getFillChoice());
                        break;
                    case 4:

                        break;
                    case 5:
                        this.printSpeed();

                        // Initialize value for slowing Down & accellerating
                        int value = this.getValue("Insert Value: ");

                        // Initialize minSpeed for slowing Down & accellerating
                        int minSpeed = this.getValue("Insert the speed to reach: ");

                        Console.WriteLine();

                        // Initialize slowDown variable for prograssively slowing down
                        int slowDown = this.slowDown(minSpeed, this.speed, value);
                        Console.WriteLine("Slowing down... " + slowDown + " Km/h");
                        break;
                    default:
                        // Exit the program
                        Console.WriteLine("Closing...");
                        Environment.Exit(0);
                        break;
                }
            }
            while (choice == 1 || choice == 2 || choice == 3);
        }

        /// <summary>
        /// Ask how much petrol the user want to insert
        /// </summary>
        /// <returns> Petrol level selected by user </returns>
        private int getFillChoice()
        {
            // Initialize fillChoice variable
            int fillChoice;

            // Get the user input
            do
            {
                Console.Write("How much petrol you want to insert (Min = 1 & Max = 30)? ");
                Int32.TryParse(Console.ReadLine(), out fillChoice);
            }
            while (!(fillChoice >= 1 && fillChoice <= 30));

            // Return fillChoice
            return fillChoice;
        }
        #endregion
    }
}
