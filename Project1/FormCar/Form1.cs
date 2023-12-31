using Project1;

namespace FormCar
{
    public partial class FormCar : Form
    {
        public InheritCar myCar = new InheritCar(new Random().Next(50, 100), "Fiat", "Panda", "Blue", false, engine.Diesel, 0);
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

            int speed;

            if (btnSend.Tag == "0")
                speed = myCar.deaccelerate(this.valueSpeed, myCar.speed, this.value);
            else
                speed = myCar.Accelerate(this.valueSpeed, myCar.speed, this.value);

            TxtOutput.Text = "Speed = " + this.valueSpeed + " Km/h";

            if (myCar.petrolLevel <= 0)
                myCar.petrolLevel = 0;

            lblfuel.Text = "fuel: " + myCar.petrolLevel;

            Speed.Text = "Speed: " + this.valueSpeed;
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblfuel.Text = "fuel: " + myCar.petrolLevel;
        }

        private void lvlfuel_Click(object sender, EventArgs e)
        {
            myCar.refill(Int32.Parse(nmrcFuel.Text));
            if (myCar.petrolLevel >= 100)
                lblfuel.Text = "fuel: " + myCar.petrolLevel + " (Full)";
            else if (myCar.petrolLevel <= 0)
            {
                myCar.petrolLevel = 0;
                lblfuel.Text = "fuel: " + myCar.petrolLevel;
            }
            else  
				lblfuel.Text = "fuel: " + myCar.petrolLevel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //decreas that car have beacuese the driver it's not accelerating
            int decrease = 1;

            if ((myCar.speed >= 0) && (myCar.petrolLevel >= 0) && (myCar.on))
            {
                
            }

            Speed.Text = "Speed: ";
        }

        private void FormCar_Load_1(object sender, EventArgs e)
        {
            Speed.Text = "Speed: " + myCar.speed;
            lblfuel.Text = "Fuel = " + myCar.petrolLevel.ToString();
            panel1.Visible = false;
        }
    }
}