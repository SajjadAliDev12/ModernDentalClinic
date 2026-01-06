namespace ModrenDentalClinic.Patients
{
    partial class FrmPatients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatients));
            this.dvgPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضالتفاصيلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.اضافةموعدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.اعادةالتحميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.اضافةمراجعجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxSearch = new System.Windows.Forms.ComboBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPatients
            // 
            this.dvgPatients.AllowUserToAddRows = false;
            this.dvgPatients.AllowUserToDeleteRows = false;
            this.dvgPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPatients.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgPatients.EnableHeadersVisualStyles = false;
            this.dvgPatients.Location = new System.Drawing.Point(12, 429);
            this.dvgPatients.MultiSelect = false;
            this.dvgPatients.Name = "dvgPatients";
            this.dvgPatients.ReadOnly = true;
            this.dvgPatients.RowHeadersWidth = 62;
            this.dvgPatients.RowTemplate.Height = 28;
            this.dvgPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPatients.Size = new System.Drawing.Size(1083, 376);
            this.dvgPatients.TabIndex = 2;
            this.dvgPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPatients_CellDoubleClick);
            this.dvgPatients.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPatients_CellMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالتفاصيلToolStripMenuItem,
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem,
            this.toolStripMenuItem1,
            this.اضافةموعدToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.toolStripMenuItem2,
            this.اعادةالتحميلToolStripMenuItem,
            this.toolStripMenuItem3,
            this.اضافةمراجعجديدToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 176);
            // 
            // عرضالتفاصيلToolStripMenuItem
            // 
            this.عرضالتفاصيلToolStripMenuItem.Name = "عرضالتفاصيلToolStripMenuItem";
            this.عرضالتفاصيلToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.عرضالتفاصيلToolStripMenuItem.Text = "عرض التفاصيل";
            this.عرضالتفاصيلToolStripMenuItem.Click += new System.EventHandler(this.عرضالتفاصيلToolStripMenuItem_Click);
            // 
            // عرضالمواعيدالخاصهبالمراجعToolStripMenuItem
            // 
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem.Name = "عرضالمواعيدالخاصهبالمراجعToolStripMenuItem";
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem.Text = "عرض المواعيد الخاصه بالمراجع";
            this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem.Click += new System.EventHandler(this.عرضالمواعيدالخاصهبالمراجعToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // اضافةموعدToolStripMenuItem
            // 
            this.اضافةموعدToolStripMenuItem.Name = "اضافةموعدToolStripMenuItem";
            this.اضافةموعدToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.اضافةموعدToolStripMenuItem.Text = "اضافة موعد للمراجع المحدد";
            this.اضافةموعدToolStripMenuItem.Click += new System.EventHandler(this.اضافةموعدToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // اعادةالتحميلToolStripMenuItem
            // 
            this.اعادةالتحميلToolStripMenuItem.Name = "اعادةالتحميلToolStripMenuItem";
            this.اعادةالتحميلToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.اعادةالتحميلToolStripMenuItem.Text = "أعادة التحميل";
            this.اعادةالتحميلToolStripMenuItem.Click += new System.EventHandler(this.اعادةالتحميلToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // اضافةمراجعجديدToolStripMenuItem
            // 
            this.اضافةمراجعجديدToolStripMenuItem.Name = "اضافةمراجعجديدToolStripMenuItem";
            this.اضافةمراجعجديدToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.اضافةمراجعجديدToolStripMenuItem.Text = "أضافة مراجع جديد";
            this.اضافةمراجعجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافةمراجعجديدToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "المراجعين";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "بحث  :";
            // 
            // cmbxSearch
            // 
            this.cmbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearch.FormattingEnabled = true;
            this.cmbxSearch.Items.AddRange(new object[] {
            "",
            "الاسم",
            "رقم الهاتف"});
            this.cmbxSearch.Location = new System.Drawing.Point(88, 386);
            this.cmbxSearch.Name = "cmbxSearch";
            this.cmbxSearch.Size = new System.Drawing.Size(170, 24);
            this.cmbxSearch.TabIndex = 6;
            this.cmbxSearch.SelectedIndexChanged += new System.EventHandler(this.cmbxSearch_SelectedIndexChanged);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(283, 386);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(231, 23);
            this.txtbxSearch.TabIndex = 7;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            this.txtbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSearch_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ModrenDentalClinic.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(965, 811);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "أغلاق        ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Image = global::ModrenDentalClinic.Properties.Resources.next__1_;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(375, 811);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 57);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "       التالي";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::ModrenDentalClinic.Properties.Resources.previous;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(511, 811);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 57);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "السابق         ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ModrenDentalClinic.Properties.Resources.Add_Person_72;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(1012, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModrenDentalClinic.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(430, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1107, 880);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.cmbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgPatients);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPatients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المراجعين";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dvgPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عرضالتفاصيلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةمراجعجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem اعادةالتحميلToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxSearch;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ToolStripMenuItem اضافةموعدToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem عرضالمواعيدالخاصهبالمراجعToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}