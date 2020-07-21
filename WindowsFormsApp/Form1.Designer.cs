namespace WindowsFormsApp
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
            this.Clear = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Firstnum = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Secondnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(500, 364);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(140, 40);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(500, 298);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(86, 45);
            this.Sub.TabIndex = 20;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mult.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(628, 298);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(86, 45);
            this.Mult.TabIndex = 19;
            this.Mult.Text = "Mult";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(369, 298);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 45);
            this.Add.TabIndex = 18;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(466, 220);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 34);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(466, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 34);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(466, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 34);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Firstnum
            // 
            this.Firstnum.AutoSize = true;
            this.Firstnum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Firstnum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Firstnum.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Firstnum.Location = new System.Drawing.Point(118, 117);
            this.Firstnum.Name = "Firstnum";
            this.Firstnum.Size = new System.Drawing.Size(280, 36);
            this.Firstnum.TabIndex = 14;
            this.Firstnum.Text = "Enter first Number";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Result.Location = new System.Drawing.Point(118, 220);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(166, 36);
            this.Result.TabIndex = 13;
            this.Result.Text = "The Result";
            // 
            // Secondnum
            // 
            this.Secondnum.AutoSize = true;
            this.Secondnum.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Secondnum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Secondnum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Secondnum.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondnum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Secondnum.Location = new System.Drawing.Point(118, 171);
            this.Secondnum.Name = "Secondnum";
            this.Secondnum.Size = new System.Drawing.Size(326, 36);
            this.Secondnum.TabIndex = 12;
            this.Secondnum.Text = "Enter Second Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(389, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simlpe Calculater";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 592);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Firstnum);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Secondnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULATER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Firstnum;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Secondnum;
        private System.Windows.Forms.Label label1;
    }
}

