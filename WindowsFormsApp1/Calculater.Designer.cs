﻿namespace WindowsFormsApp1
{
    partial class Calculater
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
            this.Clear.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(343, 376);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(140, 35);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.Location = new System.Drawing.Point(356, 298);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(86, 35);
            this.Sub.TabIndex = 20;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(483, 298);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(86, 35);
            this.Mult.TabIndex = 19;
            this.Mult.Text = "Mult";
            this.Mult.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(220, 298);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 35);
            this.Add.TabIndex = 18;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(466, 220);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 34);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(466, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 34);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 34);
            this.textBox1.TabIndex = 15;
            // 
            // Firstnum
            // 
            this.Firstnum.AutoSize = true;
            this.Firstnum.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnum.Location = new System.Drawing.Point(118, 117);
            this.Firstnum.Name = "Firstnum";
            this.Firstnum.Size = new System.Drawing.Size(278, 34);
            this.Firstnum.TabIndex = 14;
            this.Firstnum.Text = "Enter first Number";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(118, 220);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(164, 34);
            this.Result.TabIndex = 13;
            this.Result.Text = "The Result";
            // 
            // Secondnum
            // 
            this.Secondnum.AutoSize = true;
            this.Secondnum.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondnum.Location = new System.Drawing.Point(118, 171);
            this.Secondnum.Name = "Secondnum";
            this.Secondnum.Size = new System.Drawing.Size(324, 34);
            this.Secondnum.TabIndex = 12;
            this.Secondnum.Text = "Enter Second Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simlpe Calculater";
            // 
            // Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Calculater";
            this.Text = "Calculater";
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