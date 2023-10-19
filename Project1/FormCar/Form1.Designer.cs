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
            refillOption = new ToolStripMenuItem();
            moveOption = new ToolStripMenuItem();
            accellerateToolStripMenuItem = new ToolStripMenuItem();
            slowDownToolStripMenuItem = new ToolStripMenuItem();
            labelSpeed = new Label();
            labelFuel = new Label();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { startOption, stopOption, refillOption, moveOption });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
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
            // 
            // stopOption
            // 
            stopOption.AutoSize = false;
            stopOption.Name = "stopOption";
            stopOption.Size = new Size(180, 50);
            stopOption.Text = "Stop";
            // 
            // refillOption
            // 
            refillOption.AutoSize = false;
            refillOption.Name = "refillOption";
            refillOption.Size = new Size(180, 50);
            refillOption.Text = "Refill";
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
            accellerateToolStripMenuItem.Size = new Size(224, 26);
            accellerateToolStripMenuItem.Text = "Accellerate";
            // 
            // slowDownToolStripMenuItem
            // 
            slowDownToolStripMenuItem.Name = "slowDownToolStripMenuItem";
            slowDownToolStripMenuItem.Size = new Size(224, 26);
            slowDownToolStripMenuItem.Text = "Slow Down";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpeed.Location = new Point(12, 64);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(173, 30);
            labelSpeed.TabIndex = 1;
            labelSpeed.Text = "Speed = 0 Km/h";
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFuel.Location = new Point(12, 94);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(108, 30);
            labelFuel.TabIndex = 2;
            labelFuel.Text = "Fuel = " +  + " L";
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFuel);
            Controls.Add(labelSpeed);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "FormCar";
            Text = "Form Car";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
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
        private ToolStripMenuItem refillOption;
        private Label labelSpeed;
        private Label labelFuel;
    }
}