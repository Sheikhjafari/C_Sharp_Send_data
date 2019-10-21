namespace basic_send_data
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btn_connect);
            this.groupBox2.Location = new System.Drawing.Point(27, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(352, 58);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(83, 25);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 28);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btn_write);
            this.groupBox3.Location = new System.Drawing.Point(27, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(352, 136);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LCD 16x2 Control";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(177, 88);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 29);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(36, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 16;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(36, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 16;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 30);
            this.textBox1.TabIndex = 2;
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(83, 88);
            this.btn_write.Margin = new System.Windows.Forms.Padding(2);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(90, 29);
            this.btn_write.TabIndex = 4;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 240);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Smart Rabbit Computer to Arduino";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_write;
    }
}

