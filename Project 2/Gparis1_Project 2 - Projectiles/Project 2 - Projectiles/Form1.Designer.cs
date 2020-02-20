namespace Project_2___Projectiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Fire = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.txtDtoWall = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.pnlGround = new System.Windows.Forms.Panel();
            this.pnlSplat = new System.Windows.Forms.Panel();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.lblResults = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(903, 53);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(75, 23);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Location = new System.Drawing.Point(903, 82);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // txtDtoWall
            // 
            this.txtDtoWall.Location = new System.Drawing.Point(701, 85);
            this.txtDtoWall.Name = "txtDtoWall";
            this.txtDtoWall.Size = new System.Drawing.Size(100, 20);
            this.txtDtoWall.TabIndex = 2;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(364, 84);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 0;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(533, 85);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Distance to Wall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Angle";
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Controls.Add(this.pnlGround);
            this.pnlDraw.Controls.Add(this.pnlSplat);
            this.pnlDraw.Controls.Add(this.pnlSample);
            this.pnlDraw.Location = new System.Drawing.Point(13, 111);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(1255, 535);
            this.pnlDraw.TabIndex = 8;
            // 
            // pnlGround
            // 
            this.pnlGround.BackColor = System.Drawing.Color.Red;
            this.pnlGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGround.Location = new System.Drawing.Point(1002, 515);
            this.pnlGround.Name = "pnlGround";
            this.pnlGround.Size = new System.Drawing.Size(25, 4);
            this.pnlGround.TabIndex = 10;
            this.pnlGround.Visible = false;
            // 
            // pnlSplat
            // 
            this.pnlSplat.BackColor = System.Drawing.Color.Red;
            this.pnlSplat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSplat.Location = new System.Drawing.Point(1237, 324);
            this.pnlSplat.Name = "pnlSplat";
            this.pnlSplat.Size = new System.Drawing.Size(4, 25);
            this.pnlSplat.TabIndex = 9;
            this.pnlSplat.Visible = false;
            // 
            // pnlSample
            // 
            this.pnlSample.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSample.BackgroundImage")));
            this.pnlSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSample.Location = new System.Drawing.Point(0, 517);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(10, 10);
            this.pnlSample.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1264, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 535);
            this.panel2.TabIndex = 9;
            // 
            // clock
            // 
            this.clock.Interval = 30;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.White;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(298, 649);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(656, 28);
            this.lblResults.TabIndex = 10;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(361, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(440, 32);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "This is a simulation of a paintball being shot towards an (infinitely tall) wall." +
    "\r\nAdjust the initial velocity, angle of elevation and distance to the wall.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1324, 682);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtDtoWall);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Fire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox txtDtoWall;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel pnlGround;
        private System.Windows.Forms.Panel pnlSplat;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblDescription;
    }
}

