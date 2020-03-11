namespace Project_3___Forces
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.lblW = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.lblD3 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lbN1 = new System.Windows.Forms.Label();
            this.lblMag4 = new System.Windows.Forms.Label();
            this.lblMag3 = new System.Windows.Forms.Label();
            this.lblMag2 = new System.Windows.Forms.Label();
            this.lblMag1 = new System.Windows.Forms.Label();
            this.txtDeg4 = new System.Windows.Forms.TextBox();
            this.txtMag4 = new System.Windows.Forms.TextBox();
            this.txtDeg3 = new System.Windows.Forms.TextBox();
            this.txtMag3 = new System.Windows.Forms.TextBox();
            this.txtDeg2 = new System.Windows.Forms.TextBox();
            this.txtMag2 = new System.Windows.Forms.TextBox();
            this.txtDeg1 = new System.Windows.Forms.TextBox();
            this.txtMag1 = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.BackColor = System.Drawing.Color.White;
            this.pnlDrawing.Location = new System.Drawing.Point(20, 18);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(750, 750);
            this.pnlDrawing.TabIndex = 0;
            this.pnlDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawing_Paint);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.Color.Green;
            this.lblW.Location = new System.Drawing.Point(980, 207);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(0, 13);
            this.lblW.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(923, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 45;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.Location = new System.Drawing.Point(832, 516);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(91, 13);
            this.lblDisp.TabIndex = 65;
            this.lblDisp.Text = "Displacement: ";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(832, 438);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(86, 13);
            this.lblAcc.TabIndex = 64;
            this.lblAcc.Text = "Acceleration: ";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(832, 402);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(68, 13);
            this.lblNet.TabIndex = 63;
            this.lblNet.Text = "Net force: ";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(898, 251);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(112, 13);
            this.lblAdd.TabIndex = 62;
            this.lblAdd.Text = "Add up to 4 forces";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(832, 207);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 61;
            this.lblWeight.Text = "Weight";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(932, 207);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(42, 13);
            this.lblPounds.TabIndex = 60;
            this.lblPounds.Text = "pounds";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(959, 482);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(59, 13);
            this.lblSeconds.TabIndex = 59;
            this.lblSeconds.Text = "seconds ...";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(832, 482);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 13);
            this.lblTime.TabIndex = 58;
            this.lblTime.Text = "After a time of";
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Location = new System.Drawing.Point(1042, 358);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(45, 13);
            this.lblD4.TabIndex = 57;
            this.lblD4.Text = "degrees";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.Location = new System.Drawing.Point(1042, 332);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(45, 13);
            this.lblD3.TabIndex = 56;
            this.lblD3.Text = "degrees";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Location = new System.Drawing.Point(1042, 306);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(45, 13);
            this.lblD2.TabIndex = 55;
            this.lblD2.Text = "degrees";
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.Location = new System.Drawing.Point(1042, 280);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(45, 13);
            this.lblD1.TabIndex = 54;
            this.lblD1.Text = "degrees";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(942, 362);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(41, 13);
            this.lblN4.TabIndex = 53;
            this.lblN4.Text = "N     @";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(942, 332);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(41, 13);
            this.lblN3.TabIndex = 52;
            this.lblN3.Text = "N     @";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(942, 306);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(41, 13);
            this.lblN2.TabIndex = 51;
            this.lblN2.Text = "N     @";
            // 
            // lbN1
            // 
            this.lbN1.AutoSize = true;
            this.lbN1.Location = new System.Drawing.Point(940, 279);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(41, 13);
            this.lbN1.TabIndex = 50;
            this.lbN1.Text = "N     @";
            // 
            // lblMag4
            // 
            this.lblMag4.AutoSize = true;
            this.lblMag4.Location = new System.Drawing.Point(832, 362);
            this.lblMag4.Name = "lblMag4";
            this.lblMag4.Size = new System.Drawing.Size(57, 13);
            this.lblMag4.TabIndex = 49;
            this.lblMag4.Text = "Magnitude";
            // 
            // lblMag3
            // 
            this.lblMag3.AutoSize = true;
            this.lblMag3.Location = new System.Drawing.Point(832, 332);
            this.lblMag3.Name = "lblMag3";
            this.lblMag3.Size = new System.Drawing.Size(57, 13);
            this.lblMag3.TabIndex = 48;
            this.lblMag3.Text = "Magnitude";
            // 
            // lblMag2
            // 
            this.lblMag2.AutoSize = true;
            this.lblMag2.Location = new System.Drawing.Point(832, 306);
            this.lblMag2.Name = "lblMag2";
            this.lblMag2.Size = new System.Drawing.Size(57, 13);
            this.lblMag2.TabIndex = 47;
            this.lblMag2.Text = "Magnitude";
            // 
            // lblMag1
            // 
            this.lblMag1.AutoSize = true;
            this.lblMag1.Location = new System.Drawing.Point(832, 279);
            this.lblMag1.Name = "lblMag1";
            this.lblMag1.Size = new System.Drawing.Size(57, 13);
            this.lblMag1.TabIndex = 46;
            this.lblMag1.Text = "Magnitude";
            // 
            // txtDeg4
            // 
            this.txtDeg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeg4.ForeColor = System.Drawing.Color.Brown;
            this.txtDeg4.Location = new System.Drawing.Point(987, 355);
            this.txtDeg4.Name = "txtDeg4";
            this.txtDeg4.Size = new System.Drawing.Size(49, 20);
            this.txtDeg4.TabIndex = 43;
            this.txtDeg4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeg4.TextChanged += new System.EventHandler(this.txtDeg4_TextChanged_1);
            // 
            // txtMag4
            // 
            this.txtMag4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMag4.ForeColor = System.Drawing.Color.Brown;
            this.txtMag4.Location = new System.Drawing.Point(893, 355);
            this.txtMag4.Name = "txtMag4";
            this.txtMag4.Size = new System.Drawing.Size(49, 20);
            this.txtMag4.TabIndex = 42;
            this.txtMag4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMag4.TextChanged += new System.EventHandler(this.txtMag4_TextChanged_1);
            // 
            // txtDeg3
            // 
            this.txtDeg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeg3.ForeColor = System.Drawing.Color.Indigo;
            this.txtDeg3.Location = new System.Drawing.Point(987, 329);
            this.txtDeg3.Name = "txtDeg3";
            this.txtDeg3.Size = new System.Drawing.Size(49, 20);
            this.txtDeg3.TabIndex = 41;
            this.txtDeg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeg3.TextChanged += new System.EventHandler(this.txtDeg3_TextChanged_1);
            // 
            // txtMag3
            // 
            this.txtMag3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMag3.ForeColor = System.Drawing.Color.Indigo;
            this.txtMag3.Location = new System.Drawing.Point(893, 329);
            this.txtMag3.Name = "txtMag3";
            this.txtMag3.Size = new System.Drawing.Size(49, 20);
            this.txtMag3.TabIndex = 40;
            this.txtMag3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMag3.TextChanged += new System.EventHandler(this.txtMag3_TextChanged_1);
            // 
            // txtDeg2
            // 
            this.txtDeg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeg2.ForeColor = System.Drawing.Color.Red;
            this.txtDeg2.Location = new System.Drawing.Point(987, 303);
            this.txtDeg2.Name = "txtDeg2";
            this.txtDeg2.Size = new System.Drawing.Size(49, 20);
            this.txtDeg2.TabIndex = 39;
            this.txtDeg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeg2.TextChanged += new System.EventHandler(this.txtDeg2_TextChanged_1);
            // 
            // txtMag2
            // 
            this.txtMag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMag2.ForeColor = System.Drawing.Color.Red;
            this.txtMag2.Location = new System.Drawing.Point(893, 303);
            this.txtMag2.Name = "txtMag2";
            this.txtMag2.Size = new System.Drawing.Size(49, 20);
            this.txtMag2.TabIndex = 38;
            this.txtMag2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMag2.TextChanged += new System.EventHandler(this.txtMag2_TextChanged_1);
            // 
            // txtDeg1
            // 
            this.txtDeg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeg1.ForeColor = System.Drawing.Color.Blue;
            this.txtDeg1.Location = new System.Drawing.Point(987, 277);
            this.txtDeg1.Name = "txtDeg1";
            this.txtDeg1.Size = new System.Drawing.Size(49, 20);
            this.txtDeg1.TabIndex = 37;
            this.txtDeg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeg1.TextChanged += new System.EventHandler(this.txtDeg1_TextChanged_1);
            // 
            // txtMag1
            // 
            this.txtMag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMag1.ForeColor = System.Drawing.Color.Blue;
            this.txtMag1.Location = new System.Drawing.Point(893, 277);
            this.txtMag1.Name = "txtMag1";
            this.txtMag1.Size = new System.Drawing.Size(49, 20);
            this.txtMag1.TabIndex = 36;
            this.txtMag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMag1.TextChanged += new System.EventHandler(this.txtMag1_TextChanged_1);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.ForeColor = System.Drawing.Color.Green;
            this.txtWeight.Location = new System.Drawing.Point(877, 204);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(49, 20);
            this.txtWeight.TabIndex = 35;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged_1);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(904, 479);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(49, 20);
            this.txtTime.TabIndex = 44;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged_1);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.BackColor = System.Drawing.Color.White;
            this.lblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(800, 82);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(326, 75);
            this.lblPanel.TabIndex = 67;
            this.lblPanel.Text = resources.GetString("lblPanel.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1147, 780);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.lblD3);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lbN1);
            this.Controls.Add(this.lblMag4);
            this.Controls.Add(this.lblMag3);
            this.Controls.Add(this.lblMag2);
            this.Controls.Add(this.lblMag1);
            this.Controls.Add(this.txtDeg4);
            this.Controls.Add(this.txtMag4);
            this.Controls.Add(this.txtDeg3);
            this.Controls.Add(this.txtMag3);
            this.Controls.Add(this.txtDeg2);
            this.Controls.Add(this.txtMag2);
            this.Controls.Add(this.txtDeg1);
            this.Controls.Add(this.txtMag1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.pnlDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.Label lblD3;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label lblMag4;
        private System.Windows.Forms.Label lblMag3;
        private System.Windows.Forms.Label lblMag2;
        private System.Windows.Forms.Label lblMag1;
        private System.Windows.Forms.TextBox txtDeg4;
        private System.Windows.Forms.TextBox txtMag4;
        private System.Windows.Forms.TextBox txtDeg3;
        private System.Windows.Forms.TextBox txtMag3;
        private System.Windows.Forms.TextBox txtDeg2;
        private System.Windows.Forms.TextBox txtMag2;
        private System.Windows.Forms.TextBox txtDeg1;
        private System.Windows.Forms.TextBox txtMag1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblPanel;
    }
}

