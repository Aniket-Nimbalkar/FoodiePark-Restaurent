namespace FoodiePark
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getPayment = new System.Windows.Forms.Button();
            this.getCustomer = new System.Windows.Forms.Button();
            this.getOrder = new System.Windows.Forms.Button();
            this.getAvailableDishes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOODIE PARK RESTAURANT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.getPayment);
            this.panel2.Controls.Add(this.getCustomer);
            this.panel2.Controls.Add(this.getOrder);
            this.panel2.Controls.Add(this.getAvailableDishes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 601);
            this.panel2.TabIndex = 1;
            // 
            // getPayment
            // 
            this.getPayment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPayment.Location = new System.Drawing.Point(28, 244);
            this.getPayment.Name = "getPayment";
            this.getPayment.Size = new System.Drawing.Size(274, 56);
            this.getPayment.TabIndex = 3;
            this.getPayment.Text = "Payment";
            this.getPayment.UseVisualStyleBackColor = false;
            // 
            // getCustomer
            // 
            this.getCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCustomer.Location = new System.Drawing.Point(28, 97);
            this.getCustomer.Name = "getCustomer";
            this.getCustomer.Size = new System.Drawing.Size(274, 55);
            this.getCustomer.TabIndex = 2;
            this.getCustomer.Text = "Customer";
            this.getCustomer.UseVisualStyleBackColor = false;
            this.getCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // getOrder
            // 
            this.getOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getOrder.Location = new System.Drawing.Point(28, 172);
            this.getOrder.Name = "getOrder";
            this.getOrder.Size = new System.Drawing.Size(274, 50);
            this.getOrder.TabIndex = 1;
            this.getOrder.Text = "Order";
            this.getOrder.UseVisualStyleBackColor = false;
            // 
            // getAvailableDishes
            // 
            this.getAvailableDishes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getAvailableDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAvailableDishes.Location = new System.Drawing.Point(28, 27);
            this.getAvailableDishes.Name = "getAvailableDishes";
            this.getAvailableDishes.Size = new System.Drawing.Size(274, 54);
            this.getAvailableDishes.TabIndex = 0;
            this.getAvailableDishes.Text = "Available Dishes";
            this.getAvailableDishes.UseVisualStyleBackColor = false;
            this.getAvailableDishes.Click += new System.EventHandler(this.getAvailableDishes_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodiePark.Properties.Resources.loginpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1514, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Main";
            this.Text = "FoodiePark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button getPayment;
        private System.Windows.Forms.Button getCustomer;
        private System.Windows.Forms.Button getOrder;
        private System.Windows.Forms.Button getAvailableDishes;
    }
}