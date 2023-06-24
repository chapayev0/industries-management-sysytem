namespace industries_management_sysytem
{
    partial class item_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_stockmaster = new System.Windows.Forms.Panel();
            this.txtitemid = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.cbounit = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblinc = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblmax = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.barcode_box = new System.Windows.Forms.PictureBox();
            this.pnl_stockmaster.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_stockmaster
            // 
            this.pnl_stockmaster.BackColor = System.Drawing.Color.White;
            this.pnl_stockmaster.Controls.Add(this.barcode_box);
            this.pnl_stockmaster.Controls.Add(this.txtitemid);
            this.pnl_stockmaster.Controls.Add(this.Label8);
            this.pnl_stockmaster.Controls.Add(this.cbounit);
            this.pnl_stockmaster.Controls.Add(this.Label7);
            this.pnl_stockmaster.Controls.Add(this.txtqty);
            this.pnl_stockmaster.Controls.Add(this.txtdescription);
            this.pnl_stockmaster.Controls.Add(this.cbotype);
            this.pnl_stockmaster.Controls.Add(this.txtname);
            this.pnl_stockmaster.Controls.Add(this.Label4);
            this.pnl_stockmaster.Controls.Add(this.Label3);
            this.pnl_stockmaster.Controls.Add(this.txtprice);
            this.pnl_stockmaster.Controls.Add(this.Label2);
            this.pnl_stockmaster.Controls.Add(this.Label1);
            this.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_stockmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_stockmaster.Location = new System.Drawing.Point(0, 0);
            this.pnl_stockmaster.Name = "pnl_stockmaster";
            this.pnl_stockmaster.Size = new System.Drawing.Size(709, 157);
            this.pnl_stockmaster.TabIndex = 31;
            // 
            // txtitemid
            // 
            this.txtitemid.Enabled = false;
            this.txtitemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemid.Location = new System.Drawing.Point(110, 18);
            this.txtitemid.Name = "txtitemid";
            this.txtitemid.Size = new System.Drawing.Size(251, 22);
            this.txtitemid.TabIndex = 7;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(47, 21);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(65, 16);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Item Id ::";
            // 
            // cbounit
            // 
            this.cbounit.FormattingEnabled = true;
            this.cbounit.Items.AddRange(new object[] {
            "Metre",
            "Pcs."});
            this.cbounit.Location = new System.Drawing.Point(606, 121);
            this.cbounit.Name = "cbounit";
            this.cbounit.Size = new System.Drawing.Size(87, 21);
            this.cbounit.TabIndex = 6;
            this.cbounit.Text = "Metre";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(373, 125);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity ::";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(443, 122);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(153, 22);
            this.txtqty.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(109, 82);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(253, 62);
            this.txtdescription.TabIndex = 3;
            this.txtdescription.Text = "";
            // 
            // cbotype
            // 
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(441, 60);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(252, 24);
            this.cbotype.TabIndex = 2;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(110, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 22);
            this.txtname.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(392, 96);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Price ::";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(368, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Category ::";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(443, 93);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(250, 22);
            this.txtprice.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Description ::";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(30, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Item Name ::";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(452, 209);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "Search :";
            // 
            // lblinc
            // 
            this.lblinc.AutoSize = true;
            this.lblinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinc.Location = new System.Drawing.Point(47, 206);
            this.lblinc.Name = "lblinc";
            this.lblinc.Size = new System.Drawing.Size(15, 16);
            this.lblinc.TabIndex = 56;
            this.lblinc.Text = "1";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(505, 206);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 20);
            this.txtsearch.TabIndex = 45;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(442, 164);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(106, 30);
            this.btnnew.TabIndex = 47;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(69, 206);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(20, 16);
            this.Label9.TabIndex = 51;
            this.Label9.Text = "of";
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.Transparent;
            this.btnlast.ForeColor = System.Drawing.Color.Black;
            this.btnlast.Location = new System.Drawing.Point(255, 200);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(39, 30);
            this.btnlast.TabIndex = 52;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(332, 164);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 30);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.ForeColor = System.Drawing.Color.Black;
            this.btnnext.Location = new System.Drawing.Point(207, 200);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(39, 30);
            this.btnnext.TabIndex = 53;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.Color.Transparent;
            this.btnprev.ForeColor = System.Drawing.Color.Black;
            this.btnprev.Location = new System.Drawing.Point(161, 200);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(39, 30);
            this.btnprev.TabIndex = 54;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(223, 164);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 30);
            this.btnupdate.TabIndex = 49;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.Transparent;
            this.btnfirst.ForeColor = System.Drawing.Color.Black;
            this.btnfirst.Location = new System.Drawing.Point(116, 200);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(39, 30);
            this.btnfirst.TabIndex = 55;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(111, 164);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 30);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(96, 206);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(15, 16);
            this.lblmax.TabIndex = 57;
            this.lblmax.Text = "1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.dtglist);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 236);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(709, 152);
            this.GroupBox1.TabIndex = 59;
            this.GroupBox1.TabStop = false;
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(3, 16);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(703, 133);
            this.dtglist.TabIndex = 0;
            this.dtglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(606, 171);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 60;
            this.btnadd.Text = "button2";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // barcode_box
            // 
            this.barcode_box.Location = new System.Drawing.Point(440, 7);
            this.barcode_box.Name = "barcode_box";
            this.barcode_box.Size = new System.Drawing.Size(252, 48);
            this.barcode_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcode_box.TabIndex = 9;
            this.barcode_box.TabStop = false;
            // 
            // item_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lblinc);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.pnl_stockmaster);
            this.Name = "item_control";
            this.Size = new System.Drawing.Size(709, 388);
            this.Load += new System.EventHandler(this.item_control_Load);
            this.pnl_stockmaster.ResumeLayout(false);
            this.pnl_stockmaster.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_stockmaster;
        internal System.Windows.Forms.TextBox txtitemid;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cbounit;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtqty;
        internal System.Windows.Forms.RichTextBox txtdescription;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblinc;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnlast;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnnext;
        internal System.Windows.Forms.Button btnprev;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnfirst;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Label lblmax;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dtglist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox barcode_box;
    }
}
