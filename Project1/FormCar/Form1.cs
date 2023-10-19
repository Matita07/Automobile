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
            panelInput.Visible = false;
            lblfuel.Text = "Fuel = " + myCar.petrolLevel.ToString();
        }

        private void stopOption_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = myCar.stop();
            panelInput.Visible = false;
        }

        private void accellerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            lblfuel.Text = "Fuel = " + myCar.petrolLevel.ToString();
        }

        private void slowDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.valueSpeed = Int32.Parse(inputSpeed1.Text);
            this.value = Int32.Parse(inputSpeed2.Text);

            int slowDown = myCar.deaccelerate(this.valueSpeed, myCar.speed, this.value);
            TxtOutput.Text = "Speed = " + slowDown + " Km/h";
        }

        private void Rqsfuel_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = "How much refill you want? ";
        }
    }
}