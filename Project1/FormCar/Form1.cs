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
        private void accellerateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}