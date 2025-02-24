
namespace MusicShop
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowStaff = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSO = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 331);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowStaff
            // 
            this.ShowStaff.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStaff.Location = new System.Drawing.Point(27, 213);
            this.ShowStaff.Name = "ShowStaff";
            this.ShowStaff.Size = new System.Drawing.Size(81, 61);
            this.ShowStaff.TabIndex = 3;
            this.ShowStaff.Text = "Show Staff";
            this.ShowStaff.UseVisualStyleBackColor = true;
            this.ShowStaff.Click += new System.EventHandler(this.ShowStaff_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(27, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSO
            // 
            this.buttonSO.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSO.Image = global::MusicShop.Properties.Resources.special_customer_thumb1;
            this.buttonSO.Location = new System.Drawing.Point(574, 19);
            this.buttonSO.Name = "buttonSO";
            this.buttonSO.Size = new System.Drawing.Size(141, 61);
            this.buttonSO.TabIndex = 6;
            this.buttonSO.Text = "Special Orders";
            this.buttonSO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSO.UseVisualStyleBackColor = true;
            this.buttonSO.Click += new System.EventHandler(this.buttonSO_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Image = global::MusicShop.Properties.Resources.customers_thumb2;
            this.buttonC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonC.Location = new System.Drawing.Point(114, 19);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(149, 61);
            this.buttonC.TabIndex = 5;
            this.buttonC.Text = "Customers";
            this.buttonC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMC.Image = ((System.Drawing.Image)(resources.GetObject("buttonMC.Image")));
            this.buttonMC.Location = new System.Drawing.Point(349, 19);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(142, 61);
            this.buttonMC.TabIndex = 4;
            this.buttonMC.Text = "Music Collection";
            this.buttonMC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(752, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSO);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.ShowStaff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowStaff;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSO;
        private System.Windows.Forms.Button button5;
    }
}