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
            btnSend.Tag = "1";
        }

        private void slowDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInput.Visible = true;
            btnSend.Tag = "0";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.valueSpeed = Int32.Parse(inputSpeed1.Text);
            this.value = Int32.Parse(inputSpeed2.Text);

            int slowDown;

            if (btnSend.Tag == "0") 
                slowDown = myCar.deaccelerate(this.valueSpeed, myCar.speed, this.value);
            else
                slowDown = myCar.Accelerate(this.valueSpeed, myCar.speed, this.value);


            TxtOutput.Text = "Speed = " + slowDown + " Km/h";

            lblfuel.Text = "fuel: " + myCar.petrolLevel;
        }
        private void FormCar_Load(object sender, EventArgs e)
        {
            lblRqstFuel.Visible = false;
            nmrcFuel.Visible = false;
            lblfuel.Text = "fuel: " + myCar.petrolLevel;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void lvlfuel_Click(object sender, EventArgs e)
        {
            myCar.refill(Int32.Parse(nmrcFuel.Text));
            lblfuel.Text = "good! " + myCar.petrolLevel;
        }
    }
}