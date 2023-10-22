using System.Drawing;

namespace Bank
{
    partial class Bank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLayout = new System.Windows.Forms.TextBox();
            this.lblNumCams = new System.Windows.Forms.Label();
            this.nupNumCams = new System.Windows.Forms.NumericUpDown();
            this.lblNumBoxes = new System.Windows.Forms.Label();
            this.nupNumBoxes = new System.Windows.Forms.NumericUpDown();
            this.nupDrillers = new System.Windows.Forms.NumericUpDown();
            this.lblNumDrillers = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHackTime = new System.Windows.Forms.Label();
            this.nupHackTime = new System.Windows.Forms.NumericUpDown();
            this.lblDrillTime = new System.Windows.Forms.Label();
            this.nupDrillTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumCams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDrillers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHackTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDrillTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLayout
            // 
            this.txtLayout.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLayout.Location = new System.Drawing.Point(50, 12);
            this.txtLayout.Multiline = true;
            this.txtLayout.Name = "txtLayout";
            this.txtLayout.ReadOnly = true;
            this.txtLayout.Size = new System.Drawing.Size(1183, 620);
            this.txtLayout.TabIndex = 0;
            this.txtLayout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLayout_KeyDown);
            // 
            // lblNumCams
            // 
            this.lblNumCams.AutoSize = true;
            this.lblNumCams.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCams.Location = new System.Drawing.Point(1239, 50);
            this.lblNumCams.Name = "lblNumCams";
            this.lblNumCams.Size = new System.Drawing.Size(214, 22);
            this.lblNumCams.TabIndex = 1;
            this.lblNumCams.Text = "Number of Cameras";
            // 
            // nupNumCams
            // 
            this.nupNumCams.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumCams.Location = new System.Drawing.Point(1269, 75);
            this.nupNumCams.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupNumCams.Name = "nupNumCams";
            this.nupNumCams.Size = new System.Drawing.Size(120, 30);
            this.nupNumCams.TabIndex = 2;
            // 
            // lblNumBoxes
            // 
            this.lblNumBoxes.AutoSize = true;
            this.lblNumBoxes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoxes.Location = new System.Drawing.Point(1241, 125);
            this.lblNumBoxes.Name = "lblNumBoxes";
            this.lblNumBoxes.Size = new System.Drawing.Size(286, 22);
            this.lblNumBoxes.TabIndex = 3;
            this.lblNumBoxes.Text = "Number of Deposit Boxes";
            // 
            // nupNumBoxes
            // 
            this.nupNumBoxes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumBoxes.Location = new System.Drawing.Point(1269, 150);
            this.nupNumBoxes.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupNumBoxes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumBoxes.Name = "nupNumBoxes";
            this.nupNumBoxes.Size = new System.Drawing.Size(120, 30);
            this.nupNumBoxes.TabIndex = 4;
            this.nupNumBoxes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupDrillers
            // 
            this.nupDrillers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDrillers.Location = new System.Drawing.Point(1269, 225);
            this.nupDrillers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupDrillers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDrillers.Name = "nupDrillers";
            this.nupDrillers.Size = new System.Drawing.Size(120, 30);
            this.nupDrillers.TabIndex = 5;
            this.nupDrillers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumDrillers
            // 
            this.lblNumDrillers.AutoSize = true;
            this.lblNumDrillers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDrillers.Location = new System.Drawing.Point(1241, 200);
            this.lblNumDrillers.Name = "lblNumDrillers";
            this.lblNumDrillers.Size = new System.Drawing.Size(226, 22);
            this.lblNumDrillers.TabIndex = 6;
            this.lblNumDrillers.Text = "Number of Drillers";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(1245, 493);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1239, 526);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 22);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time:";
            // 
            // lblHackTime
            // 
            this.lblHackTime.AutoSize = true;
            this.lblHackTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHackTime.Location = new System.Drawing.Point(1241, 275);
            this.lblHackTime.Name = "lblHackTime";
            this.lblHackTime.Size = new System.Drawing.Size(250, 22);
            this.lblHackTime.TabIndex = 9;
            this.lblHackTime.Text = "Hack Time in seconds";
            // 
            // nupHackTime
            // 
            this.nupHackTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHackTime.Location = new System.Drawing.Point(1269, 300);
            this.nupHackTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupHackTime.Name = "nupHackTime";
            this.nupHackTime.Size = new System.Drawing.Size(120, 30);
            this.nupHackTime.TabIndex = 10;
            // 
            // lblDrillTime
            // 
            this.lblDrillTime.AutoSize = true;
            this.lblDrillTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrillTime.Location = new System.Drawing.Point(1241, 350);
            this.lblDrillTime.Name = "lblDrillTime";
            this.lblDrillTime.Size = new System.Drawing.Size(262, 22);
            this.lblDrillTime.TabIndex = 11;
            this.lblDrillTime.Text = "Drill Time in seconds";
            // 
            // nupDrillTime
            // 
            this.nupDrillTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDrillTime.Location = new System.Drawing.Point(1269, 375);
            this.nupDrillTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupDrillTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDrillTime.Name = "nupDrillTime";
            this.nupDrillTime.Size = new System.Drawing.Size(120, 30);
            this.nupDrillTime.TabIndex = 12;
            this.nupDrillTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 673);
            this.Controls.Add(this.nupDrillTime);
            this.Controls.Add(this.lblDrillTime);
            this.Controls.Add(this.nupHackTime);
            this.Controls.Add(this.lblHackTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNumDrillers);
            this.Controls.Add(this.nupDrillers);
            this.Controls.Add(this.nupNumBoxes);
            this.Controls.Add(this.lblNumBoxes);
            this.Controls.Add(this.nupNumCams);
            this.Controls.Add(this.lblNumCams);
            this.Controls.Add(this.txtLayout);
            this.KeyPreview = true;
            this.Name = "Bank";
            this.Text = "Console";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumCams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDrillers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHackTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDrillTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLayout;
        private System.Windows.Forms.Label lblNumCams;
        private System.Windows.Forms.NumericUpDown nupNumCams;
        private System.Windows.Forms.Label lblNumBoxes;
        private System.Windows.Forms.NumericUpDown nupNumBoxes;
        private System.Windows.Forms.NumericUpDown nupDrillers;
        private System.Windows.Forms.Label lblNumDrillers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHackTime;
        private System.Windows.Forms.NumericUpDown nupHackTime;
        private System.Windows.Forms.Label lblDrillTime;
        private System.Windows.Forms.NumericUpDown nupDrillTime;
    }
}

