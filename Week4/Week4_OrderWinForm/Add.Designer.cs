namespace Week4_OrderWinForm
{
    partial class Add
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
            this.add_text = new System.Windows.Forms.Label();
            this.objID_label = new System.Windows.Forms.Label();
            this.objName_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.buyer_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.unitPrice_text = new System.Windows.Forms.RichTextBox();
            this.buyer_text = new System.Windows.Forms.RichTextBox();
            this.supllier_text = new System.Windows.Forms.RichTextBox();
            this.objName_text = new System.Windows.Forms.RichTextBox();
            this.unitPrice_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.objID_text = new System.Windows.Forms.RichTextBox();
            this.num_text = new System.Windows.Forms.RichTextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_text
            // 
            this.add_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_text.AutoSize = true;
            this.add_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_text.ForeColor = System.Drawing.Color.Black;
            this.add_text.Location = new System.Drawing.Point(259, 41);
            this.add_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_text.Name = "add_text";
            this.add_text.Size = new System.Drawing.Size(186, 32);
            this.add_text.TabIndex = 24;
            this.add_text.Text = "Add an order:";
            this.add_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_text.Click += new System.EventHandler(this.add_text_Click);
            // 
            // objID_label
            // 
            this.objID_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objID_label.AutoSize = true;
            this.objID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objID_label.ForeColor = System.Drawing.Color.Black;
            this.objID_label.Location = new System.Drawing.Point(153, 0);
            this.objID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objID_label.Name = "objID_label";
            this.objID_label.Size = new System.Drawing.Size(85, 20);
            this.objID_label.TabIndex = 15;
            this.objID_label.Text = "Object ID:";
            this.objID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objName_label
            // 
            this.objName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objName_label.AutoSize = true;
            this.objName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName_label.ForeColor = System.Drawing.Color.Black;
            this.objName_label.Location = new System.Drawing.Point(141, 55);
            this.objName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objName_label.Name = "objName_label";
            this.objName_label.Size = new System.Drawing.Size(109, 20);
            this.objName_label.TabIndex = 14;
            this.objName_label.Text = "Object name:";
            this.objName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supplier_label
            // 
            this.supplier_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supplier_label.AutoSize = true;
            this.supplier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_label.ForeColor = System.Drawing.Color.Black;
            this.supplier_label.Location = new System.Drawing.Point(158, 110);
            this.supplier_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(75, 20);
            this.supplier_label.TabIndex = 16;
            this.supplier_label.Text = "Supplier:";
            this.supplier_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyer_label
            // 
            this.buyer_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buyer_label.AutoSize = true;
            this.buyer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer_label.ForeColor = System.Drawing.Color.Black;
            this.buyer_label.Location = new System.Drawing.Point(166, 165);
            this.buyer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyer_label.Name = "buyer_label";
            this.buyer_label.Size = new System.Drawing.Size(58, 20);
            this.buyer_label.TabIndex = 17;
            this.buyer_label.Text = "Buyer:";
            this.buyer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.unitPrice_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buyer_text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.supllier_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.objName_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.objID_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.objName_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplier_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buyer_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.unitPrice_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.num_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.objID_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_text, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 120);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 331);
            this.tableLayoutPanel1.TabIndex = 25;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // unitPrice_text
            // 
            this.unitPrice_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_text.Location = new System.Drawing.Point(395, 224);
            this.unitPrice_text.Margin = new System.Windows.Forms.Padding(4);
            this.unitPrice_text.Name = "unitPrice_text";
            this.unitPrice_text.Size = new System.Drawing.Size(383, 40);
            this.unitPrice_text.TabIndex = 24;
            this.unitPrice_text.Text = "";
            // 
            // buyer_text
            // 
            this.buyer_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyer_text.Location = new System.Drawing.Point(395, 169);
            this.buyer_text.Margin = new System.Windows.Forms.Padding(4);
            this.buyer_text.Name = "buyer_text";
            this.buyer_text.Size = new System.Drawing.Size(383, 40);
            this.buyer_text.TabIndex = 23;
            this.buyer_text.Text = "";
            // 
            // supllier_text
            // 
            this.supllier_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supllier_text.Location = new System.Drawing.Point(395, 114);
            this.supllier_text.Margin = new System.Windows.Forms.Padding(4);
            this.supllier_text.Name = "supllier_text";
            this.supllier_text.Size = new System.Drawing.Size(383, 40);
            this.supllier_text.TabIndex = 22;
            this.supllier_text.Text = "";
            // 
            // objName_text
            // 
            this.objName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objName_text.Location = new System.Drawing.Point(395, 59);
            this.objName_text.Margin = new System.Windows.Forms.Padding(4);
            this.objName_text.Name = "objName_text";
            this.objName_text.Size = new System.Drawing.Size(383, 40);
            this.objName_text.TabIndex = 21;
            this.objName_text.Text = "";
            // 
            // unitPrice_label
            // 
            this.unitPrice_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitPrice_label.AutoSize = true;
            this.unitPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_label.ForeColor = System.Drawing.Color.Black;
            this.unitPrice_label.Location = new System.Drawing.Point(152, 220);
            this.unitPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPrice_label.Name = "unitPrice_label";
            this.unitPrice_label.Size = new System.Drawing.Size(86, 20);
            this.unitPrice_label.TabIndex = 18;
            this.unitPrice_label.Text = "Unit price:";
            this.unitPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_label
            // 
            this.num_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_label.AutoSize = true;
            this.num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.ForeColor = System.Drawing.Color.Black;
            this.num_label.Location = new System.Drawing.Point(159, 275);
            this.num_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(73, 20);
            this.num_label.TabIndex = 19;
            this.num_label.Text = "Number:";
            this.num_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objID_text
            // 
            this.objID_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objID_text.Location = new System.Drawing.Point(395, 4);
            this.objID_text.Margin = new System.Windows.Forms.Padding(4);
            this.objID_text.Name = "objID_text";
            this.objID_text.Size = new System.Drawing.Size(383, 40);
            this.objID_text.TabIndex = 20;
            this.objID_text.Text = "";
            // 
            // num_text
            // 
            this.num_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_text.Location = new System.Drawing.Point(395, 279);
            this.num_text.Margin = new System.Windows.Forms.Padding(4);
            this.num_text.Name = "num_text";
            this.num_text.Size = new System.Drawing.Size(383, 40);
            this.num_text.TabIndex = 25;
            this.num_text.Text = "";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(-106, 480);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(1013, 52);
            this.confirm_btn.TabIndex = 26;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.add_text);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.confirm_btn);
            this.Name = "Add";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_text;
        private System.Windows.Forms.Label objID_label;
        private System.Windows.Forms.Label objName_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label buyer_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox unitPrice_text;
        private System.Windows.Forms.RichTextBox buyer_text;
        private System.Windows.Forms.RichTextBox supllier_text;
        private System.Windows.Forms.RichTextBox objName_text;
        private System.Windows.Forms.Label unitPrice_label;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.RichTextBox objID_text;
        private System.Windows.Forms.RichTextBox num_text;
        private System.Windows.Forms.Button confirm_btn;
    }
}