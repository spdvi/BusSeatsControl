
namespace TEstBusControl
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
            this.busSeats1 = new BusSeatsControl.BusSeats();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // busSeats1
            // 
            this.busSeats1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("busSeats1.BackgroundImage")));
            this.busSeats1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.busSeats1.Capacity = 11;
            this.busSeats1.FreeSeats = 11;
            this.busSeats1.Location = new System.Drawing.Point(12, 12);
            this.busSeats1.Name = "busSeats1";
            this.busSeats1.Size = new System.Drawing.Size(837, 412);
            this.busSeats1.TabIndex = 0;
            this.busSeats1.SeatReservedEvent += new System.EventHandler<System.EventArgs>(this.busSeats1_SeatReservedEvent);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Free seats:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.busSeats1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusSeatsControl.BusSeats busSeats1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

