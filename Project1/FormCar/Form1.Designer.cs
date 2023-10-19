namespace FormCar
{
    partial class FormCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            startOption = new ToolStripMenuItem();
            stopOption = new ToolStripMenuItem();
            moveOption = new ToolStripMenuItem();
            accellerateToolStripMenuItem = new ToolStripMenuItem();
            slowDownToolStripMenuItem = new ToolStripMenuItem();
            labelSpeed = new Label();
            labelFuel = new Label();
            lvlfuel = new Button();
            lblfuel = new Label();
            TxtOutput = new RichTextBox();
            inputSpeed1 = new NumericUpDown();
            inputSpeed2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            panelInput = new Panel();
            btnSend = new Button();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputSpeed1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputSpeed2).BeginInit();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { startOption, stopOption, moveOption });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(80, 2, 0, 2);
            Menu.Size = new Size(800, 54);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // startOption
            // 
            startOption.AutoSize = false;
            startOption.Name = "startOption";
            startOption.Size = new Size(180, 50);
            startOption.Text = "Start";
            startOption.Click += startOption_Click;
            // 
            // stopOption
            // 
            stopOption.AutoSize = false;
            stopOption.Name = "stopOption";
            stopOption.Size = new Size(180, 50);
            stopOption.Text = "Stop";
            stopOption.Click += stopOption_Click;
            // 
            // moveOption
            // 
            moveOption.AutoSize = false;
            moveOption.DropDownItems.AddRange(new ToolStripItem[] { accellerateToolStripMenuItem, slowDownToolStripMenuItem });
            moveOption.Name = "moveOption";
            moveOption.Size = new Size(180, 50);
            moveOption.Text = "Move";
            // 
            // accellerateToolStripMenuItem
            // 
            accellerateToolStripMenuItem.Name = "accellerateToolStripMenuItem";
            accellerateToolStripMenuItem.Size = new Size(167, 26);
            accellerateToolStripMenuItem.Text = "Accellerate";
            accellerateToolStripMenuItem.Click += accellerateToolStripMenuItem_Click;
            // 
            // slowDownToolStripMenuItem
            // 
            slowDownToolStripMenuItem.Name = "slowDownToolStripMenuItem";
            slowDownToolStripMenuItem.Size = new Size(167, 26);
            slowDownToolStripMenuItem.Text = "Slow Down";
            slowDownToolStripMenuItem.Click += slowDownToolStripMenuItem_Click;
            // 
            // labelSpeed
            // 
            labelSpeed.Location = new Point(0, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(100, 23);
            labelSpeed.TabIndex = 0;
            // 
            // labelFuel
            // 
            labelFuel.Location = new Point(0, 0);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(100, 23);
            labelFuel.TabIndex = 0;
            // 
            // labelSpeed
            // 
            labelSpeed.Location = new Point(0, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(100, 23);
            labelSpeed.TabIndex = 0;
            // 
            // labelFuel
            // 
            labelFuel.Location = new Point(0, 0);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(100, 23);
            labelFuel.TabIndex = 0;
            // 
            // lvlfuel
            // 
            lvlfuel.Location = new Point(674, 396);
            lvlfuel.Name = "lvlfuel";
            lvlfuel.Size = new Size(114, 45);
            lvlfuel.TabIndex = 3;
            lvlfuel.Text = "Refill";
            lvlfuel.UseVisualStyleBackColor = true;
            lvlfuel.Click += lvlfuel_Click;
            // 
            // lblfuel
            // 
            lblfuel.AutoSize = true;
            lblfuel.Location = new Point(702, 373);
            lblfuel.Name = "lblfuel";
            lblfuel.Size = new Size(0, 20);
            lblfuel.TabIndex = 6;
            lblfuel.Text = "Fuel = " + myCar.petrolLevel;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(12, 77);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(776, 88);
            TxtOutput.TabIndex = 9;
            TxtOutput.Text = "";
            // 
            // inputSpeed1
            // 
            inputSpeed1.Location = new Point(3, 33);
            inputSpeed1.Name = "inputSpeed1";
            inputSpeed1.Size = new Size(193, 27);
            inputSpeed1.TabIndex = 10;
            // 
            // inputSpeed2
            // 
            inputSpeed2.Location = new Point(3, 90);
            inputSpeed2.Name = "inputSpeed2";
            inputSpeed2.Size = new Size(193, 27);
            inputSpeed2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 12;
            label1.Text = "Insert speed to reach: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 13;
            label2.Text = "Insert the step for speeding:";
            // 
            // panelInput
            // 
            panelInput.BackColor = SystemColors.Control;
            panelInput.Controls.Add(btnSend);
            panelInput.Controls.Add(label1);
            panelInput.Controls.Add(label2);
            panelInput.Controls.Add(inputSpeed1);
            panelInput.Controls.Add(inputSpeed2);
            panelInput.Location = new Point(12, 180);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(250, 165);
            panelInput.TabIndex = 14;
            panelInput.Visible = false;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(3, 132);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelInput);
            Controls.Add(TxtOutput);
            Controls.Add(lblfuel);
            Controls.Add(lvlfuel);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "FormCar";
            Text = "Form Car";
            Load += FormCar_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputSpeed1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputSpeed2).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem startOption;
        private ToolStripMenuItem stopOption;
        private ToolStripMenuItem moveOption;
        private ToolStripMenuItem accellerateToolStripMenuItem;
        private ToolStripMenuItem slowDownToolStripMenuItem;
        private Label labelSpeed;
        private Label labelFuel;
        private Button lvlfuel;
        private Label lblfuel;
        private RichTextBox TxtOutput;
        private NumericUpDown inputSpeed1;
        private NumericUpDown inputSpeed2;
        private Label label1;
        private Label label2;
        private Panel panelInput;
        private Button btnSend;
    }
}