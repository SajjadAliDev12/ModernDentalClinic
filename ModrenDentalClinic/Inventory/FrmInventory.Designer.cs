using System.Windows.Forms;

namespace ModrenDentalClinic.InventoryPage
{
    partial class FrmInventory
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeight = 34;
            this.dgvInventory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInventory.Location = new System.Drawing.Point(12, 180);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.Size = new System.Drawing.Size(650, 338);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            this.dgvInventory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةToolStripMenuItem,
            this.toolStripMenuItem1,
            this.تعديلToolStripMenuItem,
            this.toolStripMenuItem2,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 82);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.إضافةToolStripMenuItem.Text = "إضافة";
            this.إضافةToolStripMenuItem.Click += new System.EventHandler(this.إضافةToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 6);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(101, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::ModrenDentalClinic.Properties.Resources.edit_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(450, 524);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "تعديل          ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ModrenDentalClinic.Properties.Resources.Address_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(340, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "إضافة         ";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncclose
            // 
            this.btncclose.Image = global::ModrenDentalClinic.Properties.Resources.Close_32;
            this.btncclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncclose.Location = new System.Drawing.Point(556, 524);
            this.btncclose.Name = "btncclose";
            this.btncclose.Size = new System.Drawing.Size(104, 38);
            this.btncclose.TabIndex = 40;
            this.btncclose.Text = "اغلاق             ";
            this.btncclose.Click += new System.EventHandler(this.btncclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "أدارة المخزون";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModrenDentalClinic.Properties.Resources.forbidden;
            this.pictureBox1.Location = new System.Drawing.Point(271, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInventory
            // 
            this.ClientSize = new System.Drawing.Size(680, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncclose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FrmInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إدارة المخزون";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem إضافةToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem تعديلToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem حذفToolStripMenuItem;
        private Button button1;
        private Button btncclose;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
