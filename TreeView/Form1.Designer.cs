namespace TreeView
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.AddNodes = new System.Windows.Forms.Button();
            this.AddCildNodes = new System.Windows.Forms.Button();
            this.RemoveNode = new System.Windows.Forms.Button();
            this.DeletTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Info;
            this.treeView.Location = new System.Drawing.Point(299, 145);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(210, 367);
            this.treeView.TabIndex = 0;
            // 
            // AddNodes
            // 
            this.AddNodes.BackColor = System.Drawing.SystemColors.Info;
            this.AddNodes.Location = new System.Drawing.Point(567, 167);
            this.AddNodes.Name = "AddNodes";
            this.AddNodes.Size = new System.Drawing.Size(161, 34);
            this.AddNodes.TabIndex = 1;
            this.AddNodes.Text = "Add Nodes";
            this.AddNodes.UseVisualStyleBackColor = false;
            this.AddNodes.Click += new System.EventHandler(this.AddNodes_Click);
            // 
            // AddCildNodes
            // 
            this.AddCildNodes.BackColor = System.Drawing.SystemColors.Info;
            this.AddCildNodes.Location = new System.Drawing.Point(567, 253);
            this.AddCildNodes.Name = "AddCildNodes";
            this.AddCildNodes.Size = new System.Drawing.Size(161, 34);
            this.AddCildNodes.TabIndex = 2;
            this.AddCildNodes.Text = "Add Cild Nodes";
            this.AddCildNodes.UseVisualStyleBackColor = false;
            this.AddCildNodes.Click += new System.EventHandler(this.AddCildNodes_Click);
            // 
            // RemoveNode
            // 
            this.RemoveNode.BackColor = System.Drawing.SystemColors.Info;
            this.RemoveNode.Location = new System.Drawing.Point(567, 343);
            this.RemoveNode.Name = "RemoveNode";
            this.RemoveNode.Size = new System.Drawing.Size(161, 34);
            this.RemoveNode.TabIndex = 3;
            this.RemoveNode.Text = "Remove Node";
            this.RemoveNode.UseVisualStyleBackColor = false;
            this.RemoveNode.Click += new System.EventHandler(this.RemoveNode_Click);
            // 
            // DeletTree
            // 
            this.DeletTree.BackColor = System.Drawing.SystemColors.Info;
            this.DeletTree.Location = new System.Drawing.Point(567, 430);
            this.DeletTree.Name = "DeletTree";
            this.DeletTree.Size = new System.Drawing.Size(161, 34);
            this.DeletTree.TabIndex = 4;
            this.DeletTree.Text = "Delet Tree";
            this.DeletTree.UseVisualStyleBackColor = false;
            this.DeletTree.Click += new System.EventHandler(this.DeletTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(813, 712);
            this.Controls.Add(this.DeletTree);
            this.Controls.Add(this.RemoveNode);
            this.Controls.Add(this.AddCildNodes);
            this.Controls.Add(this.AddNodes);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button AddNodes;
        private System.Windows.Forms.Button AddCildNodes;
        private System.Windows.Forms.Button RemoveNode;
        private System.Windows.Forms.Button DeletTree;
    }
}

