namespace Project1
{
    #region Custom Types
    public enum engine
    {
        Petrol,    // value = 0 default
        Diesel,     // value = 1 default
        Electric   // value = 2 default
    }
    #endregion
    public class Car
    {
        #region Attributes
        public int petrolLevel { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        private bool on { get; set; }
        public engine engineType { get; set; }
        public int speed { get; set; }
        public int maxspeed { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Contructor without parameters
        /// </summary>
        public Car()
        {
            this.petrolLevel = 10;
            this.maxspeed = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="petrolLevel"> car's level of petrol </param>
        /// <param name="brand"> car's brand </param>
        /// <param name="model"> car's model </param>
        /// <param name="color"> car's body color </param>
        /// <param name="on"> check if the car in on or off </param>
        /// <param name="engineType"> car's type of engine </param>
        public Car(int petrolLevel, string brand, string model, string color, bool on, engine engineType, int maxspeed)
        {
            this.petrolLevel = petrolLevel;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.on = on;
            this.engineType = engineType;
            this.maxspeed = maxspeed;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Print of all the characteristics
        /// </summary>
        public void print()
        {
            // print car's characteristics
            Console.WriteLine(this.setDescription());
        }

        /// <summary>
        /// set the output string with all of the car's properties
        /// </summary>
        /// <returns> string with all of the car's properties </returns>
        private string setDescription()
        {
            // declaration variables
            string result;

            // concat of strings in result
            result = "Brand: " + this.brand + "\n";
            result += $"Model: {this.model}\n";
            result += "Color: " + this.color + "\n";
            result += $"Engine Type: {this.engineType}\n";

            // return the result
            return result;
        }

        /// <summary>
        /// Gets the status of the car
        /// </summary>
        /// <returns> return the car status with the petrol level </returns>
        public string carStatus()
        {
            // Check boolean variable "on"
            if (this.on)
                return "\nPetrol Level: " + this.petrolLevel + "\nThe Car is On\n";
            else
                return "\nPetrol Level: " + this.petrolLevel + "\nThe Car is Off\n";
        }

        /// <summary>
        /// Method to start the car's engine
        /// </summary>
        public void start()
        {
            // check the petrol level if it's over 0
            if (this.on)
            {
                if (this.petrolLevel > 2)
                    Console.WriteLine("The " + this.brand + " " + this.model + " is already going");
                else
                {
                    this.on = false;
                    Console.WriteLine("Not enough petrol, please refill your " + this.brand + " " + this.model);
                }
            }
            else
            {
                if (this.petrolLevel > 2)
                {
                    petrolLevel -= 3; // Copyright: Suecomo
                    this.on = true;
                    Console.WriteLine("The " + this.brand + " " + this.model + " started his engine");
                }
                else
                    Console.WriteLine("Not enough petrol, please refill your " + this.brand + " " + this.model);
            }
        }

        /// <summary>
        /// Method to stop the car's engine
        /// </summary>
        public void stop()
        {
            // check the petrol level if it's over 0
            if (this.on)
            {
                this.on = false;
                if (this.petrolLevel > 0)
                    Console.WriteLine("The " + this.brand + " " + this.model + " stopped");
                else
                    Console.WriteLine("The " + this.brand + " " + this.model + " stopped beacause there's no petrol");
            }
            else
            {
                if (this.petrolLevel > 0)
                    Console.WriteLine("The " + this.brand + " " + this.model + " is already off");
                else
                    Console.WriteLine("The " + this.brand + " " + this.model + " is already off but there's no petrol");
            }
        }

        /// <summary>
        /// Method that refills the car petrol
        /// </summary>
        public void refill(int fill)
        {
            // Initialize print variable
            string print = "";

            Console.WriteLine("\nRefill...");

            // Update Petrol Level
            this.petrolLevel += fill;

            // Check if Petrol Level is not over Max (100)
            if (this.petrolLevel >= 100)
            {
                print += " (full)";
                this.petrolLevel = 100;
            }

            // Print Petrol Level & print variable
            Console.WriteLine("Petrol Level = " + this.petrolLevel + print);
        }

        
        public int getValue(string request)
        {
            int n;

            Console.Write(request);
            Int32.TryParse(Console.ReadLine(), out n);

            return n;
        }

        public int slowDown(int minSpeed, int speed, int value)
        {
            // Check if the speed is less than p equal to the minSpeed
            if (speed <= minSpeed)
                return minSpeed;
            else
            {
                // Print the decrement
                Console.WriteLine("Slowing down... " + speed + " Km/h");
                // return the recursive function with the speed slowed
                return slowDown(minSpeed, speed - value, value);
            }
        }
        #endregion
    }
}