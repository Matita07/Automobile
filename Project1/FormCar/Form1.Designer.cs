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
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            fuelToolStripMenuItem = new ToolStripMenuItem();
            refillToolStripMenuItem = new ToolStripMenuItem();
            viewFuelLevelToolStripMenuItem = new ToolStripMenuItem();
            moveToolStripMenuItem = new ToolStripMenuItem();
            accellerateToolStripMenuItem = new ToolStripMenuItem();
            slowDownToolStripMenuItem = new ToolStripMenuItem();
            viewSpeedKmhToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, fuelToolStripMenuItem, moveToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(800, 54);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.AutoSize = false;
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(180, 50);
            startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.AutoSize = false;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(180, 50);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // fuelToolStripMenuItem
            // 
            fuelToolStripMenuItem.AutoSize = false;
            fuelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refillToolStripMenuItem, viewFuelLevelToolStripMenuItem });
            fuelToolStripMenuItem.Name = "fuelToolStripMenuItem";
            fuelToolStripMenuItem.Size = new Size(180, 50);
            fuelToolStripMenuItem.Text = "Fuel";
            // 
            // refillToolStripMenuItem
            // 
            refillToolStripMenuItem.Name = "refillToolStripMenuItem";
            refillToolStripMenuItem.Size = new Size(224, 26);
            refillToolStripMenuItem.Text = "Refill";
            // 
            // viewFuelLevelToolStripMenuItem
            // 
            viewFuelLevelToolStripMenuItem.Name = "viewFuelLevelToolStripMenuItem";
            viewFuelLevelToolStripMenuItem.Size = new Size(224, 26);
            viewFuelLevelToolStripMenuItem.Text = "View Fuel Level";
            // 
            // moveToolStripMenuItem
            // 
            moveToolStripMenuItem.AutoSize = false;
            moveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accellerateToolStripMenuItem, slowDownToolStripMenuItem, viewSpeedKmhToolStripMenuItem });
            moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            moveToolStripMenuItem.Size = new Size(180, 50);
            moveToolStripMenuItem.Text = "Move";
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
            // viewSpeedKmhToolStripMenuItem
            // 
            viewSpeedKmhToolStripMenuItem.Name = "viewSpeedKmhToolStripMenuItem";
            viewSpeedKmhToolStripMenuItem.Size = new Size(224, 26);
            viewSpeedKmhToolStripMenuItem.Text = "View Speed (Km/h)";
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem fuelToolStripMenuItem;
        private ToolStripMenuItem refillToolStripMenuItem;
        private ToolStripMenuItem viewFuelLevelToolStripMenuItem;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripMenuItem accellerateToolStripMenuItem;
        private ToolStripMenuItem slowDownToolStripMenuItem;
        private ToolStripMenuItem viewSpeedKmhToolStripMenuItem;
    }
}