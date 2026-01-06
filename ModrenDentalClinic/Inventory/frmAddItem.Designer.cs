namespace ModrenDentalClinic.Inventory
{
    partial class frmAddItem
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.dtpBuy = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btncclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 22);
            this.txtName.TabIndex = 14;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(151, 153);
            this.numQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(133, 22);
            this.numQty.TabIndex = 15;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(151, 202);
            this.numMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(133, 22);
            this.numMin.TabIndex = 16;
            // 
            // dtpExp
            // 
            this.dtpExp.Location = new System.Drawing.Point(457, 153);
            this.dtpExp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(265, 22);
            this.dtpExp.TabIndex = 17;
            // 
            // dtpBuy
            // 
            this.dtpBuy.Location = new System.Drawing.Point(457, 202);
            this.dtpBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBuy.Name = "dtpBuy";
            this.dtpBuy.Size = new System.Drawing.Size(265, 22);
            this.dtpBuy.TabIndex = 18;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(17, 106);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(133, 28);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "اسم المادة:";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(17, 155);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(133, 28);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "الكمية:";
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(17, 204);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(133, 28);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "الحد الأدنى:";
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(324, 155);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(133, 28);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "تاريخ الانتهاء:";
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(324, 204);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(133, 28);
            this.lbl5.TabIndex = 23;
            this.lbl5.Text = "تاريخ الشراء:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "أضافة عنصر جديد";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ModrenDentalClinic.Properties.Resources.Address_32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(492, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "إضافة         ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btncclose
            // 
            this.btncclose.Image = global::ModrenDentalClinic.Properties.Resources.Close_32;
            this.btncclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncclose.Location = new System.Drawing.Point(602, 272);
            this.btncclose.Name = "btncclose";
            this.btncclose.Size = new System.Drawing.Size(104, 38);
            this.btncclose.TabIndex = 26;
            this.btncclose.Text = "اغلاق             ";
            this.btncclose.Click += new System.EventHandler(this.btncclose_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 322);
            this.Controls.Add(this.btncclose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.dtpExp);
            this.Controls.Add(this.dtpBuy);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة مادة";
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.DateTimePicker dtpBuy;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btncclose;
    }
}