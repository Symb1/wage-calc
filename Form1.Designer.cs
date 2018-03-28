namespace WindowsFormsApplication1
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hodiny = new System.Windows.Forms.Label();
            this.mzda = new System.Windows.Forms.Label();
            this.workHours = new System.Windows.Forms.TextBox();
            this.workWageH = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hodiny
            // 
            this.hodiny.AutoSize = true;
            this.hodiny.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hodiny.Location = new System.Drawing.Point(31, 43);
            this.hodiny.Name = "hodiny";
            this.hodiny.Size = new System.Drawing.Size(193, 18);
            this.hodiny.TabIndex = 0;
            this.hodiny.Text = "Pocet odpracovanych hodin:";
            // 
            // mzda
            // 
            this.mzda.AutoSize = true;
            this.mzda.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzda.Location = new System.Drawing.Point(31, 86);
            this.mzda.Name = "mzda";
            this.mzda.Size = new System.Drawing.Size(119, 18);
            this.mzda.TabIndex = 1;
            this.mzda.Text = "Hodinova mzda:";
            // 
            // workHours
            // 
            this.workHours.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workHours.ForeColor = System.Drawing.SystemColors.WindowText;
            this.workHours.Location = new System.Drawing.Point(262, 43);
            this.workHours.MaxLength = 6;
            this.workHours.Name = "workHours";
            this.workHours.Size = new System.Drawing.Size(100, 23);
            this.workHours.TabIndex = 2;
            // 
            // workWageH
            // 
            this.workWageH.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workWageH.Location = new System.Drawing.Point(262, 86);
            this.workWageH.MaxLength = 3;
            this.workWageH.Name = "workWageH";
            this.workWageH.Size = new System.Drawing.Size(100, 23);
            this.workWageH.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(23, 249);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(194, 96);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Vypocitat";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(392, 192);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 72);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(392, 270);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 75);
            this.exit.TabIndex = 6;
            this.exit.Text = "Zrusit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(31, 165);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(103, 18);
            this.suma.TabIndex = 7;
            this.suma.Text = "Celkova suma:";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(262, 160);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VypocetMzdy.Properties.Resources.backround;
            this.ClientSize = new System.Drawing.Size(500, 355);
            this.Controls.Add(this.result);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.workWageH);
            this.Controls.Add(this.workHours);
            this.Controls.Add(this.mzda);
            this.Controls.Add(this.hodiny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vypocet Mzdy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hodiny;
        private System.Windows.Forms.Label mzda;
        private System.Windows.Forms.TextBox workHours;
        private System.Windows.Forms.TextBox workWageH;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label suma;
        private System.Windows.Forms.TextBox result;
    }
}

