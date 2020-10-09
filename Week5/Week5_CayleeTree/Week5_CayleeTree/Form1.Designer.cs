namespace Week5_CayleeTree
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label_Msg = new System.Windows.Forms.Label();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.branchAngle_L = new System.Windows.Forms.TextBox();
            this.branchAngle_R = new System.Windows.Forms.TextBox();
            this.treeBranch_L = new System.Windows.Forms.TextBox();
            this.treeBranch_R = new System.Windows.Forms.TextBox();
            this.tree_height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recursion_depth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Msg.Location = new System.Drawing.Point(16, 413);
            this.label_Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(84, 24);
            this.label_Msg.TabIndex = 15;
            this.label_Msg.Text = "Prompt :";
            this.label_Msg.Visible = false;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(260, 351);
            this.btnSetColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(126, 31);
            this.btnSetColor.TabIndex = 14;
            this.btnSetColor.Text = "Select";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click_1);
            // 
            // branchAngle_L
            // 
            this.branchAngle_L.Location = new System.Drawing.Point(260, 295);
            this.branchAngle_L.Margin = new System.Windows.Forms.Padding(4);
            this.branchAngle_L.Name = "branchAngle_L";
            this.branchAngle_L.Size = new System.Drawing.Size(125, 22);
            this.branchAngle_L.TabIndex = 13;
            this.branchAngle_L.Text = "20";
            // 
            // branchAngle_R
            // 
            this.branchAngle_R.Location = new System.Drawing.Point(260, 239);
            this.branchAngle_R.Margin = new System.Windows.Forms.Padding(4);
            this.branchAngle_R.Name = "branchAngle_R";
            this.branchAngle_R.Size = new System.Drawing.Size(125, 22);
            this.branchAngle_R.TabIndex = 12;
            this.branchAngle_R.Text = "30";
            // 
            // treeBranch_L
            // 
            this.treeBranch_L.Location = new System.Drawing.Point(260, 186);
            this.treeBranch_L.Margin = new System.Windows.Forms.Padding(4);
            this.treeBranch_L.Name = "treeBranch_L";
            this.treeBranch_L.Size = new System.Drawing.Size(125, 22);
            this.treeBranch_L.TabIndex = 11;
            this.treeBranch_L.Text = "0.6";
            // 
            // treeBranch_R
            // 
            this.treeBranch_R.Location = new System.Drawing.Point(260, 131);
            this.treeBranch_R.Margin = new System.Windows.Forms.Padding(4);
            this.treeBranch_R.Name = "treeBranch_R";
            this.treeBranch_R.Size = new System.Drawing.Size(125, 22);
            this.treeBranch_R.TabIndex = 10;
            this.treeBranch_R.Text = "0.7";
            // 
            // tree_height
            // 
            this.tree_height.Location = new System.Drawing.Point(260, 79);
            this.tree_height.Margin = new System.Windows.Forms.Padding(4);
            this.tree_height.Name = "tree_height";
            this.tree_height.Size = new System.Drawing.Size(125, 22);
            this.tree_height.TabIndex = 9;
            this.tree_height.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Color :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Left Branch Angle :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Right Branch Angle :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Left Branch Ratio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Right Branch Ratio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tree Height :";
            // 
            // recursion_depth
            // 
            this.recursion_depth.Location = new System.Drawing.Point(260, 27);
            this.recursion_depth.Margin = new System.Windows.Forms.Padding(4);
            this.recursion_depth.Name = "recursion_depth";
            this.recursion_depth.Size = new System.Drawing.Size(125, 22);
            this.recursion_depth.TabIndex = 2;
            this.recursion_depth.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recursion Depth :";
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDraw.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDraw.Location = new System.Drawing.Point(86, 483);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(237, 50);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Begin Draw Tree";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 584);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Msg);
            this.panel2.Controls.Add(this.btnSetColor);
            this.panel2.Controls.Add(this.branchAngle_L);
            this.panel2.Controls.Add(this.branchAngle_R);
            this.panel2.Controls.Add(this.treeBranch_L);
            this.panel2.Controls.Add(this.treeBranch_R);
            this.panel2.Controls.Add(this.tree_height);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.recursion_depth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDraw);
            this.panel2.Location = new System.Drawing.Point(640, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 567);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.TextBox branchAngle_L;
        private System.Windows.Forms.TextBox branchAngle_R;
        private System.Windows.Forms.TextBox treeBranch_L;
        private System.Windows.Forms.TextBox treeBranch_R;
        private System.Windows.Forms.TextBox tree_height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recursion_depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

