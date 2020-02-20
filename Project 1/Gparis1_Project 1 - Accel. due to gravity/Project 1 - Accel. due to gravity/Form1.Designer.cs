namespace Project_1___Accel.due_to_gravity
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
            this.Begin = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.myClock = new System.Windows.Forms.Timer(this.components);
            this.pnlDrawing.SuspendLayout();
            this.SuspendLayout();
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(251, 34);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(75, 23);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(251, 34);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.BackColor = System.Drawing.Color.White;
            this.pnlDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDrawing.Controls.Add(this.pnlSample);
            this.pnlDrawing.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(150, 500);
            this.pnlDrawing.TabIndex = 2;
            // 
            // pnlSample
            // 
            this.pnlSample.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSample.BackgroundImage")));
            this.pnlSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSample.Location = new System.Drawing.Point(65, 0);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(20, 20);
            this.pnlSample.TabIndex = 7;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(280, 85);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(46, 20);
            this.txtDistance.TabIndex = 3;
            this.txtDistance.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height of Ball Drop\r\n(Given in metres)";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(156, 126);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(37, 13);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Result";
            this.lblResults.Visible = false;
            // 
            // myClock
            // 
            this.myClock.Interval = 30;
            this.myClock.Tick += new System.EventHandler(this.myClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 507);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.pnlDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlDrawing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Timer myClock;
    }
}

