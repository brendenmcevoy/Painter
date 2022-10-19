
namespace Painter
{
    partial class PainterForm
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.canvas = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.black = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.large = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.small = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            this.colorBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.canvas.Location = new System.Drawing.Point(278, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(522, 450);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.black);
            this.colorBox.Controls.Add(this.green);
            this.colorBox.Controls.Add(this.blue);
            this.colorBox.Controls.Add(this.red);
            this.colorBox.Location = new System.Drawing.Point(56, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(130, 216);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Color";
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(7, 137);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(52, 17);
            this.black.TabIndex = 3;
            this.black.TabStop = true;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            this.black.CheckedChanged += new System.EventHandler(this.black_CheckedChanged);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(7, 103);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(54, 17);
            this.green.TabIndex = 2;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(7, 67);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(46, 17);
            this.blue.TabIndex = 1;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(7, 33);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(45, 17);
            this.red.TabIndex = 0;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.CheckedChanged += new System.EventHandler(this.red_CheckedChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.large);
            this.sizeBox.Controls.Add(this.medium);
            this.sizeBox.Controls.Add(this.small);
            this.sizeBox.Location = new System.Drawing.Point(56, 259);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(130, 166);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(7, 119);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(52, 17);
            this.large.TabIndex = 2;
            this.large.TabStop = true;
            this.large.Text = "Large";
            this.large.UseVisualStyleBackColor = true;
            this.large.CheckedChanged += new System.EventHandler(this.large_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(7, 79);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 1;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Location = new System.Drawing.Point(7, 40);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(50, 17);
            this.small.TabIndex = 0;
            this.small.TabStop = true;
            this.small.Text = "Small";
            this.small.UseVisualStyleBackColor = true;
            this.small.CheckedChanged += new System.EventHandler(this.small_CheckedChanged);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.canvas);
            this.Name = "PainterForm";
            this.Text = "Painter";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton small;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
    }
}

