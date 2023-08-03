namespace WetterApp
{
    partial class MainWindow
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
            formsPlot1 = new ScottPlot.FormsPlot();
            checkTemp30 = new CheckBox();
            checkTemp200 = new CheckBox();
            checkTemp5 = new CheckBox();
            checkTemp20 = new CheckBox();
            checkFeucht200 = new CheckBox();
            checkFeucht30 = new CheckBox();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(78, 37);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(467, 346);
            formsPlot1.TabIndex = 0;
            // 
            // checkTemp30
            // 
            checkTemp30.AutoSize = true;
            checkTemp30.Enabled = false;
            checkTemp30.Location = new Point(566, 63);
            checkTemp30.Name = "checkTemp30";
            checkTemp30.Size = new Size(79, 19);
            checkTemp30.TabIndex = 1;
            checkTemp30.Text = "l_temp_30";
            checkTemp30.UseVisualStyleBackColor = true;
            checkTemp30.CheckedChanged += AnyCheckedChanged;
            // 
            // checkTemp200
            // 
            checkTemp200.AutoSize = true;
            checkTemp200.Enabled = false;
            checkTemp200.Location = new Point(566, 88);
            checkTemp200.Name = "checkTemp200";
            checkTemp200.Size = new Size(85, 19);
            checkTemp200.TabIndex = 2;
            checkTemp200.Text = "l_temp_200";
            checkTemp200.UseVisualStyleBackColor = true;
            checkTemp200.CheckedChanged += AnyCheckedChanged;
            // 
            // checkTemp5
            // 
            checkTemp5.AutoSize = true;
            checkTemp5.Location = new Point(566, 128);
            checkTemp5.Name = "checkTemp5";
            checkTemp5.Size = new Size(77, 19);
            checkTemp5.TabIndex = 3;
            checkTemp5.Text = "b_temp_5";
            checkTemp5.TextAlign = ContentAlignment.MiddleCenter;
            checkTemp5.UseVisualStyleBackColor = true;
            checkTemp5.CheckedChanged += AnyCheckedChanged;
            // 
            // checkTemp20
            // 
            checkTemp20.AutoSize = true;
            checkTemp20.Enabled = false;
            checkTemp20.Location = new Point(566, 153);
            checkTemp20.Name = "checkTemp20";
            checkTemp20.Size = new Size(83, 19);
            checkTemp20.TabIndex = 4;
            checkTemp20.Text = "b_temp_20";
            checkTemp20.TextAlign = ContentAlignment.MiddleCenter;
            checkTemp20.UseVisualStyleBackColor = true;
            checkTemp20.CheckedChanged += AnyCheckedChanged;
            // 
            // checkFeucht200
            // 
            checkFeucht200.AutoSize = true;
            checkFeucht200.Enabled = false;
            checkFeucht200.Location = new Point(566, 224);
            checkFeucht200.Name = "checkFeucht200";
            checkFeucht200.Size = new Size(91, 19);
            checkFeucht200.TabIndex = 6;
            checkFeucht200.Text = "l_feucht_200";
            checkFeucht200.UseVisualStyleBackColor = true;
            checkFeucht200.CheckedChanged += AnyCheckedChanged;
            // 
            // checkFeucht30
            // 
            checkFeucht30.AutoSize = true;
            checkFeucht30.Enabled = false;
            checkFeucht30.Location = new Point(564, 199);
            checkFeucht30.Name = "checkFeucht30";
            checkFeucht30.Size = new Size(85, 19);
            checkFeucht30.TabIndex = 7;
            checkFeucht30.Text = "l_feucht_30";
            checkFeucht30.UseVisualStyleBackColor = true;
            checkFeucht30.CheckedChanged += AnyCheckedChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkFeucht30);
            Controls.Add(checkFeucht200);
            Controls.Add(checkTemp20);
            Controls.Add(checkTemp5);
            Controls.Add(checkTemp200);
            Controls.Add(checkTemp30);
            Controls.Add(formsPlot1);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private CheckBox checkTemp30;
        private CheckBox checkTemp200;
        private CheckBox checkTemp5;
        private CheckBox checkTemp20;
        private CheckBox checkFeucht200;
        private CheckBox checkFeucht30;
    }
}