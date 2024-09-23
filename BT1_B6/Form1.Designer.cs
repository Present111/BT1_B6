namespace BT1_B6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCows = new System.Windows.Forms.TextBox();
            this.txtSheeps = new System.Windows.Forms.TextBox();
            this.txtGoats = new System.Windows.Forms.TextBox();
            this.txtTotalSheeps = new System.Windows.Forms.TextBox();
            this.txtTotalCows = new System.Windows.Forms.TextBox();
            this.txtTotalMilk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalGoats = new System.Windows.Forms.TextBox();
            this.txtSounds = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSounds);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtGoats);
            this.groupBox1.Controls.Add(this.txtSheeps);
            this.groupBox1.Controls.Add(this.txtCows);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Cows";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Sheeps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Goats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalGoats);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalSheeps);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotalCows);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalMilk);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(99, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUPUT";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Sheeps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Cows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Milk";
            // 
            // txtCows
            // 
            this.txtCows.Location = new System.Drawing.Point(254, 22);
            this.txtCows.Name = "txtCows";
            this.txtCows.Size = new System.Drawing.Size(169, 28);
            this.txtCows.TabIndex = 3;
            this.txtCows.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSheeps
            // 
            this.txtSheeps.Location = new System.Drawing.Point(254, 55);
            this.txtSheeps.Name = "txtSheeps";
            this.txtSheeps.Size = new System.Drawing.Size(169, 28);
            this.txtSheeps.TabIndex = 4;
            // 
            // txtGoats
            // 
            this.txtGoats.Location = new System.Drawing.Point(253, 89);
            this.txtGoats.Name = "txtGoats";
            this.txtGoats.Size = new System.Drawing.Size(169, 28);
            this.txtGoats.TabIndex = 5;
            // 
            // txtTotalSheeps
            // 
            this.txtTotalSheeps.Location = new System.Drawing.Point(253, 89);
            this.txtTotalSheeps.Name = "txtTotalSheeps";
            this.txtTotalSheeps.ReadOnly = true;
            this.txtTotalSheeps.Size = new System.Drawing.Size(169, 28);
            this.txtTotalSheeps.TabIndex = 8;
            // 
            // txtTotalCows
            // 
            this.txtTotalCows.Location = new System.Drawing.Point(254, 55);
            this.txtTotalCows.Name = "txtTotalCows";
            this.txtTotalCows.ReadOnly = true;
            this.txtTotalCows.Size = new System.Drawing.Size(169, 28);
            this.txtTotalCows.TabIndex = 7;
            // 
            // txtTotalMilk
            // 
            this.txtTotalMilk.Location = new System.Drawing.Point(254, 22);
            this.txtTotalMilk.Name = "txtTotalMilk";
            this.txtTotalMilk.ReadOnly = true;
            this.txtTotalMilk.Size = new System.Drawing.Size(169, 28);
            this.txtTotalMilk.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Goats";
            // 
            // txtTotalGoats
            // 
            this.txtTotalGoats.Location = new System.Drawing.Point(253, 133);
            this.txtTotalGoats.Name = "txtTotalGoats";
            this.txtTotalGoats.ReadOnly = true;
            this.txtTotalGoats.Size = new System.Drawing.Size(169, 28);
            this.txtTotalGoats.TabIndex = 10;
            // 
            // txtSounds
            // 
            this.txtSounds.Location = new System.Drawing.Point(438, 89);
            this.txtSounds.Name = "txtSounds";
            this.txtSounds.Size = new System.Drawing.Size(245, 28);
            this.txtSounds.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGoats;
        private System.Windows.Forms.TextBox txtSheeps;
        private System.Windows.Forms.TextBox txtCows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalSheeps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalCows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalMilk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalGoats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSounds;
    }
}

