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
        public int petrolLevel { get; private set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        internal bool on { get; set; } //defines whether the machine is on or off.
        public engine engineType { get; set; }
        public int speed { get; private set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Contructor without parameters
        /// </summary>
        public Car()
        {
            this.petrolLevel = 10;
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
        public Car(int petrolLevel, string brand, string model, string color, bool on, engine engineType, int speed)
        {
            this.petrolLevel = petrolLevel;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.on = on;
            this.engineType = engineType;
            this.speed = speed;
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
                return "\nPetrol Level: " + this.petrolLevel + "\nThe Car is On\nSpeed: " + this.speed + " Km/h\n";
            else
            {
                this.speed = 0;
                return "\nPetrol Level: " + this.petrolLevel + "\nThe Car is Off\nSpeed: " + this.speed + " Km/h\n";
            }
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
                    petrolLevel -= 1; // Copyright: Suecomo
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
                if (this.speed <= 0)
                {
                    this.on = false;
                    if (this.petrolLevel > 0)
                        Console.WriteLine("The " + this.brand + " " + this.model + " stopped");
                    else
                        Console.WriteLine("The " + this.brand + " " + this.model + " stopped beacause there's no petrol");
                }
                else
                {
                    Console.WriteLine("The car is moving, can't stop now");
                }
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

        /// <summary>
        /// Print the speed
        /// </summary>
        public void printPetrolLevel()
        {
            // Print speed
            Console.WriteLine("Petrol level: " + this.petrolLevel);
        }

        /// <summary>
        /// Print the speed
        /// </summary>
        public void printSpeed()
        {
            // Print speed
            Console.WriteLine("You're going at " + this.speed + " Km/h\n");
        }

        /// <summary>
        /// get an integer in input by the request
        /// </summary>
        /// <param name="request"> question for the input </param>
        /// <returns> inserted number </returns>
        public int getValue(string request)
        {
            // Declare n for the input
            int n;

            // Question
            Console.Write(request);
            Int32.TryParse(Console.ReadLine(), out n);
            
            // return the number wrote by the user
            return n;
        }

        /// <summary>
        /// Slow down method
        /// </summary>
        /// <param name="minSpeed"> speed to reach </param>
        /// <param name="speed"> actual speed </param>
        /// <param name="value"> value to decrement the speed </param>
        /// <returns></returns>
        public int deaccelerate(int minSpeed, int speed, int value)
        {
            if (!(this.on))
            {
                return -1;
            }
            else
            {
                // Check if the speed is less than or equal to the minSpeed
                if (speed <= minSpeed)
                    return minSpeed;
                else
                {
                    // Print the decrement
                    Console.WriteLine("Slowing down... " + speed + " Km/h");
                    // return the recursive function with the speed slowed
                    return this.speed = deaccelerate(minSpeed, speed - value, value);
                }
            }
        }

        public int Accelerate(int maxSpeed, int speed, int value)
        {
            // Check if the speed is greater than or equal to the maxSpeed
            if (speed >= maxSpeed)
                return maxSpeed;
            else
            {
                // Print the increment
                Console.WriteLine("Accellerate up... " + speed + " km/h");

                // decremente Petrol Level
                this.petrolLevel -= value;

                if(this.petrolLevel <= 0)
                {
                    Console.WriteLine("\nNo more petrol, please refill!\n");
                    return -1;
                }

                // return the recursive function with the speed augmented
                return this.speed = Accelerate(maxSpeed, speed + value, value);
            }

        }
        #endregion
    }
}