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
            nmrcFuel = new NumericUpDown();
            btnRequest = new Button();
            lblRqstFuel = new Label();
            panel1 = new Panel();
            lblSpeed = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputSpeed1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputSpeed2).BeginInit();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcFuel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { startOption, stopOption, moveOption });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(70, 2, 0, 2);
            Menu.Size = new Size(700, 54);
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
            accellerateToolStripMenuItem.Size = new Size(133, 22);
            accellerateToolStripMenuItem.Text = "Accellerate";
            accellerateToolStripMenuItem.Click += accellerateToolStripMenuItem_Click;
            // 
            // slowDownToolStripMenuItem
            // 
            slowDownToolStripMenuItem.Name = "slowDownToolStripMenuItem";
            slowDownToolStripMenuItem.Size = new Size(133, 22);
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
            // lvlfuel
            // 
            lvlfuel.Location = new Point(590, 297);
            lvlfuel.Margin = new Padding(3, 2, 3, 2);
            lvlfuel.Name = "lvlfuel";
            lvlfuel.Size = new Size(100, 34);
            lvlfuel.TabIndex = 3;
            lvlfuel.Text = "Refill";
            lvlfuel.UseVisualStyleBackColor = true;
            lvlfuel.Click += lvlfuel_Click;
            // 
            // lblfuel
            // 
            lblfuel.AutoSize = true;
            lblfuel.Location = new Point(614, 280);
            lblfuel.Name = "lblfuel";
            lblfuel.Size = new Size(0, 15);
            lblfuel.TabIndex = 6;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(10, 58);
            TxtOutput.Margin = new Padding(3, 2, 3, 2);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(680, 67);
            TxtOutput.TabIndex = 9;
            TxtOutput.Text = "";
            // 
            // inputSpeed1
            // 
            inputSpeed1.Location = new Point(3, 25);
            inputSpeed1.Margin = new Padding(3, 2, 3, 2);
            inputSpeed1.Name = "inputSpeed1";
            inputSpeed1.Size = new Size(169, 23);
            inputSpeed1.TabIndex = 10;
            // 
            // inputSpeed2
            // 
            inputSpeed2.Location = new Point(3, 68);
            inputSpeed2.Margin = new Padding(3, 2, 3, 2);
            inputSpeed2.Name = "inputSpeed2";
            inputSpeed2.Size = new Size(169, 23);
            inputSpeed2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 12;
            label1.Text = "Insert speed to reach: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
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
            panelInput.Location = new Point(10, 135);
            panelInput.Margin = new Padding(3, 2, 3, 2);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(219, 124);
            panelInput.TabIndex = 14;
            panelInput.Visible = false;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(3, 99);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(82, 22);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // nmrcFuel
            // 
            nmrcFuel.Location = new Point(9, 23);
            nmrcFuel.Margin = new Padding(3, 2, 3, 2);
            nmrcFuel.Name = "nmrcFuel";
            nmrcFuel.Size = new Size(59, 23);
            nmrcFuel.TabIndex = 15;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(485, 297);
            btnRequest.Margin = new Padding(3, 2, 3, 2);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(100, 34);
            btnRequest.TabIndex = 16;
            btnRequest.Text = "Request Fuel";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // lblRqstFuel
            // 
            lblRqstFuel.AutoSize = true;
            lblRqstFuel.Location = new Point(3, 2);
            lblRqstFuel.Name = "lblRqstFuel";
            lblRqstFuel.Size = new Size(149, 15);
            lblRqstFuel.TabIndex = 17;
            lblRqstFuel.Text = "How much fuel you want ?";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRqstFuel);
            panel1.Controls.Add(nmrcFuel);
            panel1.Location = new Point(517, 227);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 50);
            panel1.TabIndex = 18;
            panel1.Visible = false;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(12, 386);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(58, 20);
            lblSpeed.TabIndex = 19;
            lblSpeed.Text = "Speed: ";
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblSpeed);
            Controls.Add(panel1);
            Controls.Add(btnRequest);
            Controls.Add(panelInput);
            Controls.Add(TxtOutput);
            Controls.Add(lblfuel);
            Controls.Add(lvlfuel);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCar";
            Text = "Form Car";
            Load += FormCar_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputSpeed1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputSpeed2).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcFuel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private NumericUpDown nmrcFuel;
        private Button btnRequest;
        private Label lblRqstFuel;
        private Panel panel1;
        private Label lblSpeed;
    }
}