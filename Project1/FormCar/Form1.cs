using Project1;

namespace FormCar
{
    public partial class FormCar : Form
    {
        public InheritCar myCar = new InheritCar(new Random().Next(50, 100), "Fiat", "Panda", "Blue", false, engine.Diesel, new Random().Next(50, 100));

        public FormCar()
        {
            InitializeComponent();
        }

        private void startOption_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = myCar.start();
        }

        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlfuel_Click(object sender, EventArgs e)
        {

        }

        private void Rqsfuel_Click(object sender, EventArgs e)
        {
            TxtOutput.Text = "How much reifl you want? ";
        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }
    }
}