namespace Calculate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Result_but = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "The Result:";
            // 
            // FirstNum
            // 
            this.FirstNum.Location = new System.Drawing.Point(397, 82);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(214, 27);
            this.FirstNum.TabIndex = 3;
            // 
            // SecondNum
            // 
            this.SecondNum.Location = new System.Drawing.Point(397, 153);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(214, 27);
            this.SecondNum.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(397, 237);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(214, 27);
            this.Result.TabIndex = 5;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(296, 303);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(66, 44);
            this.sum.TabIndex = 6;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(397, 303);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 42);
            this.sub.TabIndex = 7;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(510, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Location = new System.Drawing.Point(608, 303);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(67, 44);
            this.div.TabIndex = 9;
            this.div.Text = "%";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Result_but
            // 
            this.Result_but.BackColor = System.Drawing.Color.Bisque;
            this.Result_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_but.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_but.Location = new System.Drawing.Point(185, 385);
            this.Result_but.Name = "Result_but";
            this.Result_but.Size = new System.Drawing.Size(378, 47);
            this.Result_but.TabIndex = 10;
            this.Result_but.Text = "Show The Result";
            this.Result_but.UseVisualStyleBackColor = false;
            this.Result_but.Click += new System.EventHandler(this.Result_but_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Bisque;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(593, 385);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(116, 50);
            this.Remove.TabIndex = 11;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Result_but);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Result_but;
        private System.Windows.Forms.Button Remove;
    }
}

