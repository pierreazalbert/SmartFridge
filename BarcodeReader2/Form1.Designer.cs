namespace BarcodeReader2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.l_title = new System.Windows.Forms.Label();
            this.l_lifetime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_saturates = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_energy = new System.Windows.Forms.Label();
            this.l_sugars = new System.Windows.Forms.Label();
            this.l_fat = new System.Windows.Forms.Label();
            this.l_salt = new System.Windows.Forms.Label();
            this.l_saturatesGDA = new System.Windows.Forms.Label();
            this.l_energyGDA = new System.Windows.Forms.Label();
            this.l_sugarsGDA = new System.Windows.Forms.Label();
            this.l_fatGDA = new System.Windows.Forms.Label();
            this.l_saltGDA = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input EAN Code:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(258, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 38);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.l_title.Location = new System.Drawing.Point(525, 14);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(0, 24);
            this.l_title.TabIndex = 5;
            // 
            // l_lifetime
            // 
            this.l_lifetime.AutoSize = true;
            this.l_lifetime.Location = new System.Drawing.Point(15, 213);
            this.l_lifetime.Name = "l_lifetime";
            this.l_lifetime.Size = new System.Drawing.Size(120, 13);
            this.l_lifetime.TabIndex = 6;
            this.l_lifetime.Text = "ESTIMATED LIFETIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sugars: ";
            // 
            // l_saturates
            // 
            this.l_saturates.AutoSize = true;
            this.l_saturates.Location = new System.Drawing.Point(587, 105);
            this.l_saturates.Name = "l_saturates";
            this.l_saturates.Size = new System.Drawing.Size(0, 13);
            this.l_saturates.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fat: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saturates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Energy: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salt: ";
            // 
            // l_energy
            // 
            this.l_energy.AutoSize = true;
            this.l_energy.Location = new System.Drawing.Point(587, 66);
            this.l_energy.Name = "l_energy";
            this.l_energy.Size = new System.Drawing.Size(0, 13);
            this.l_energy.TabIndex = 13;
            // 
            // l_sugars
            // 
            this.l_sugars.AutoSize = true;
            this.l_sugars.Location = new System.Drawing.Point(587, 79);
            this.l_sugars.Name = "l_sugars";
            this.l_sugars.Size = new System.Drawing.Size(0, 13);
            this.l_sugars.TabIndex = 13;
            // 
            // l_fat
            // 
            this.l_fat.AutoSize = true;
            this.l_fat.Location = new System.Drawing.Point(587, 92);
            this.l_fat.Name = "l_fat";
            this.l_fat.Size = new System.Drawing.Size(0, 13);
            this.l_fat.TabIndex = 13;
            // 
            // l_salt
            // 
            this.l_salt.AutoSize = true;
            this.l_salt.Location = new System.Drawing.Point(587, 118);
            this.l_salt.Name = "l_salt";
            this.l_salt.Size = new System.Drawing.Size(0, 13);
            this.l_salt.TabIndex = 13;
            // 
            // l_saturatesGDA
            // 
            this.l_saturatesGDA.AutoSize = true;
            this.l_saturatesGDA.Location = new System.Drawing.Point(667, 105);
            this.l_saturatesGDA.Name = "l_saturatesGDA";
            this.l_saturatesGDA.Size = new System.Drawing.Size(0, 13);
            this.l_saturatesGDA.TabIndex = 8;
            // 
            // l_energyGDA
            // 
            this.l_energyGDA.AutoSize = true;
            this.l_energyGDA.Location = new System.Drawing.Point(667, 66);
            this.l_energyGDA.Name = "l_energyGDA";
            this.l_energyGDA.Size = new System.Drawing.Size(0, 13);
            this.l_energyGDA.TabIndex = 13;
            // 
            // l_sugarsGDA
            // 
            this.l_sugarsGDA.AutoSize = true;
            this.l_sugarsGDA.Location = new System.Drawing.Point(667, 79);
            this.l_sugarsGDA.Name = "l_sugarsGDA";
            this.l_sugarsGDA.Size = new System.Drawing.Size(0, 13);
            this.l_sugarsGDA.TabIndex = 13;
            // 
            // l_fatGDA
            // 
            this.l_fatGDA.AutoSize = true;
            this.l_fatGDA.Location = new System.Drawing.Point(667, 92);
            this.l_fatGDA.Name = "l_fatGDA";
            this.l_fatGDA.Size = new System.Drawing.Size(0, 13);
            this.l_fatGDA.TabIndex = 13;
            // 
            // l_saltGDA
            // 
            this.l_saltGDA.AutoSize = true;
            this.l_saltGDA.Location = new System.Drawing.Point(667, 118);
            this.l_saltGDA.Name = "l_saltGDA";
            this.l_saltGDA.Size = new System.Drawing.Size(0, 13);
            this.l_saltGDA.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lstatus
            // 
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(39, 17);
            this.lstatus.Text = "Ready";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 274);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fridge Contents:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.l_saltGDA);
            this.Controls.Add(this.l_salt);
            this.Controls.Add(this.l_fatGDA);
            this.Controls.Add(this.l_fat);
            this.Controls.Add(this.l_sugarsGDA);
            this.Controls.Add(this.l_sugars);
            this.Controls.Add(this.l_energyGDA);
            this.Controls.Add(this.l_energy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_saturatesGDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_saturates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_lifetime);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "SmartFridge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Label l_lifetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_saturates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_energy;
        private System.Windows.Forms.Label l_sugars;
        private System.Windows.Forms.Label l_fat;
        private System.Windows.Forms.Label l_salt;
        private System.Windows.Forms.Label l_saturatesGDA;
        private System.Windows.Forms.Label l_energyGDA;
        private System.Windows.Forms.Label l_sugarsGDA;
        private System.Windows.Forms.Label l_fatGDA;
        private System.Windows.Forms.Label l_saltGDA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lstatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}

