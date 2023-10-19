using Project1;

namespace FormCar
{
    public partial class FormCar : Form
    {
        public InheritCar myCar = new InheritCar(new Random().Next(50, 100), "Fiat", "Panda", "Blue", false, engine.Diesel, new Random().Next(50, 100));
        public int valueSpeed;
        public int value;

        public FormCar()
        {
            InitializeComponent();
        }

        private void startOption_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = myCar.start();
        }

        private void stopOption_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = myCar.stop();
        }

        private void accellerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myCar.on)
            {
                // Initialize value for slowing Down & accellerating
                int value = myCar.getValue("Insert Value: ");

                // Initialize minSpeed for slowing Down & accellerating
                int maxSpeed = myCar.getValue("Insert the speed to reach: ");

                Console.WriteLine();

                // Initialize slowDown variable for prograssively slowing down
                int accelerate = myCar.Accelerate(maxSpeed, myCar.speed, value);

                if (accelerate >= 0)
                    TxtOutput.Text = "Accellerate up... " + accelerate + " Km/h";
            }
            else
                TxtOutput.Text = "You can't accellerate, the car in off";

        }

        private void slowDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.valueSpeed = Int32.Parse(inputSpeed1.Text);
            this.value = Int32.Parse(inputSpeed2.Text);
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            lblRqstFuel.Visible = false;
            nmrcFuel.Visible = false;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            lblRqstFuel.Visible = true;
            nmrcFuel.Visible = true;
        }

        private void lvlfuel_Click(object sender, EventArgs e)
        {
            myCar.refill(Int32.Parse(nmrcFuel.Text));
            lblfuel
        }
    }
}