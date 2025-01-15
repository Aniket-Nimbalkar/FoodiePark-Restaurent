namespace FoodiePark
{
    partial class availablefood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.getFoodId = new System.Windows.Forms.Label();
            this.getFoodName = new System.Windows.Forms.Label();
            this.getPrice = new System.Windows.Forms.Label();
            this.getQuantity = new System.Windows.Forms.Label();
            this.getAvailabillity = new System.Windows.Forms.Label();
            this.foodid = new System.Windows.Forms.TextBox();
            this.foodname = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.availabillity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panellabel = new System.Windows.Forms.Label();
            this.saveFood = new System.Windows.Forms.Button();
            this.addFood = new System.Windows.Forms.Button();
            this.newFood = new System.Windows.Forms.Button();
            this.updateFood = new System.Windows.Forms.Button();
            this.deleteFood = new System.Windows.Forms.Button();
            this.displayFood = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chickenwings = new System.Windows.Forms.PictureBox();
            this.availabledishimg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenwings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabledishimg)).BeginInit();
            this.SuspendLayout();
            // 
            // getFoodId
            // 
            this.getFoodId.AutoSize = true;
            this.getFoodId.Location = new System.Drawing.Point(232, 131);
            this.getFoodId.Name = "getFoodId";
            this.getFoodId.Size = new System.Drawing.Size(60, 20);
            this.getFoodId.TabIndex = 0;
            this.getFoodId.Text = "FoodId";
            // 
            // getFoodName
            // 
            this.getFoodName.AutoSize = true;
            this.getFoodName.Location = new System.Drawing.Point(232, 199);
            this.getFoodName.Name = "getFoodName";
            this.getFoodName.Size = new System.Drawing.Size(88, 20);
            this.getFoodName.TabIndex = 1;
            this.getFoodName.Text = "FoodName";
            // 
            // getPrice
            // 
            this.getPrice.AutoSize = true;
            this.getPrice.Location = new System.Drawing.Point(232, 258);
            this.getPrice.Name = "getPrice";
            this.getPrice.Size = new System.Drawing.Size(44, 20);
            this.getPrice.TabIndex = 2;
            this.getPrice.Text = "Price";
            // 
            // getQuantity
            // 
            this.getQuantity.AutoSize = true;
            this.getQuantity.Location = new System.Drawing.Point(232, 331);
            this.getQuantity.Name = "getQuantity";
            this.getQuantity.Size = new System.Drawing.Size(68, 20);
            this.getQuantity.TabIndex = 3;
            this.getQuantity.Text = "Quantity";
            // 
            // getAvailabillity
            // 
            this.getAvailabillity.AutoSize = true;
            this.getAvailabillity.Location = new System.Drawing.Point(232, 407);
            this.getAvailabillity.Name = "getAvailabillity";
            this.getAvailabillity.Size = new System.Drawing.Size(84, 20);
            this.getAvailabillity.TabIndex = 4;
            this.getAvailabillity.Text = "Availabillity";
            this.getAvailabillity.Click += new System.EventHandler(this.getAvailabillity_Click);
            // 
            // foodid
            // 
            this.foodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodid.ForeColor = System.Drawing.SystemColors.Info;
            this.foodid.Location = new System.Drawing.Point(442, 121);
            this.foodid.Name = "foodid";
            this.foodid.Size = new System.Drawing.Size(259, 35);
            this.foodid.TabIndex = 5;
            // 
            // foodname
            // 
            this.foodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodname.Location = new System.Drawing.Point(442, 189);
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(259, 35);
            this.foodname.TabIndex = 6;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(442, 248);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(259, 35);
            this.price.TabIndex = 7;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(442, 321);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(259, 35);
            this.quantity.TabIndex = 8;
            // 
            // availabillity
            // 
            this.availabillity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabillity.Location = new System.Drawing.Point(442, 397);
            this.availabillity.Name = "availabillity";
            this.availabillity.Size = new System.Drawing.Size(259, 35);
            this.availabillity.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panellabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1823, 62);
            this.panel1.TabIndex = 11;
            // 
            // panellabel
            // 
            this.panellabel.AutoSize = true;
            this.panellabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panellabel.Location = new System.Drawing.Point(554, 9);
            this.panellabel.Name = "panellabel";
            this.panellabel.Size = new System.Drawing.Size(245, 37);
            this.panellabel.TabIndex = 0;
            this.panellabel.Text = "Available Dishes";
            // 
            // saveFood
            // 
            this.saveFood.Location = new System.Drawing.Point(620, 483);
            this.saveFood.Name = "saveFood";
            this.saveFood.Size = new System.Drawing.Size(134, 57);
            this.saveFood.TabIndex = 13;
            this.saveFood.Text = "Save";
            this.saveFood.UseVisualStyleBackColor = true;
            this.saveFood.Click += new System.EventHandler(this.saveFood_Click);
            // 
            // addFood
            // 
            this.addFood.Location = new System.Drawing.Point(837, 483);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(148, 57);
            this.addFood.TabIndex = 14;
            this.addFood.Text = "Add";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // newFood
            // 
            this.newFood.Location = new System.Drawing.Point(422, 483);
            this.newFood.Name = "newFood";
            this.newFood.Size = new System.Drawing.Size(132, 57);
            this.newFood.TabIndex = 15;
            this.newFood.Text = "New";
            this.newFood.UseVisualStyleBackColor = true;
            this.newFood.Click += new System.EventHandler(this.newFood_Click);
            // 
            // updateFood
            // 
            this.updateFood.Location = new System.Drawing.Point(1078, 483);
            this.updateFood.Name = "updateFood";
            this.updateFood.Size = new System.Drawing.Size(135, 57);
            this.updateFood.TabIndex = 16;
            this.updateFood.Text = "Update";
            this.updateFood.UseVisualStyleBackColor = true;
            this.updateFood.Click += new System.EventHandler(this.updateFood_Click);
            // 
            // deleteFood
            // 
            this.deleteFood.Location = new System.Drawing.Point(1309, 483);
            this.deleteFood.Name = "deleteFood";
            this.deleteFood.Size = new System.Drawing.Size(134, 57);
            this.deleteFood.TabIndex = 17;
            this.deleteFood.Text = "Delete";
            this.deleteFood.UseVisualStyleBackColor = true;
            this.deleteFood.Click += new System.EventHandler(this.deleteFood_Click);
            // 
            // displayFood
            // 
            this.displayFood.Location = new System.Drawing.Point(1568, 483);
            this.displayFood.Name = "displayFood";
            this.displayFood.Size = new System.Drawing.Size(134, 57);
            this.displayFood.TabIndex = 18;
            this.displayFood.Text = "Display";
            this.displayFood.UseVisualStyleBackColor = true;
            this.displayFood.Click += new System.EventHandler(this.displayFood_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(0, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1823, 286);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chickenwings
            // 
            this.chickenwings.BackgroundImage = global::FoodiePark.Properties.Resources.chickenwing;
            this.chickenwings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chickenwings.Location = new System.Drawing.Point(814, 62);
            this.chickenwings.Name = "chickenwings";
            this.chickenwings.Size = new System.Drawing.Size(603, 405);
            this.chickenwings.TabIndex = 12;
            this.chickenwings.TabStop = false;
            this.chickenwings.Click += new System.EventHandler(this.chickenwings_Click);
            // 
            // availabledishimg
            // 
            this.availabledishimg.BackgroundImage = global::FoodiePark.Properties.Resources.food_image;
            this.availabledishimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.availabledishimg.Location = new System.Drawing.Point(1414, 62);
            this.availabledishimg.Name = "availabledishimg";
            this.availabledishimg.Size = new System.Drawing.Size(406, 405);
            this.availabledishimg.TabIndex = 10;
            this.availabledishimg.TabStop = false;
            // 
            // availablefood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1823, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displayFood);
            this.Controls.Add(this.deleteFood);
            this.Controls.Add(this.updateFood);
            this.Controls.Add(this.newFood);
            this.Controls.Add(this.addFood);
            this.Controls.Add(this.saveFood);
            this.Controls.Add(this.chickenwings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.availabillity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.foodname);
            this.Controls.Add(this.foodid);
            this.Controls.Add(this.getAvailabillity);
            this.Controls.Add(this.getQuantity);
            this.Controls.Add(this.getPrice);
            this.Controls.Add(this.getFoodName);
            this.Controls.Add(this.getFoodId);
            this.Controls.Add(this.availabledishimg);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "availablefood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodiePark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.availableDishes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenwings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabledishimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getFoodId;
        private System.Windows.Forms.Label getFoodName;
        private System.Windows.Forms.Label getPrice;
        private System.Windows.Forms.Label getQuantity;
        private System.Windows.Forms.Label getAvailabillity;
        private System.Windows.Forms.TextBox foodid;
        private System.Windows.Forms.TextBox foodname;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox availabillity;
        private System.Windows.Forms.PictureBox availabledishimg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panellabel;
        private System.Windows.Forms.PictureBox chickenwings;
        private System.Windows.Forms.Button saveFood;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.Button newFood;
        private System.Windows.Forms.Button updateFood;
        private System.Windows.Forms.Button deleteFood;
        private System.Windows.Forms.Button displayFood;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}