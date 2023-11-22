namespace ProductMangement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvProduct = new ListView();
            colID = new ColumnHeader();
            colName = new ColumnHeader();
            colPrice = new ColumnHeader();
            colQuantity = new ColumnHeader();
            gbProduct = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            lbName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            gbProduct.SuspendLayout();
            SuspendLayout();
            // 
            // lvProduct
            // 
            lvProduct.Columns.AddRange(new ColumnHeader[] { colID, colName, colPrice, colQuantity });
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.Location = new Point(12, 50);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(456, 246);
            lvProduct.TabIndex = 0;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            lvProduct.SelectedIndexChanged += lvProduct_SelectedIndexChanged;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 30;
            // 
            // colName
            // 
            colName.Text = "Product Name";
            colName.Width = 200;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 100;
            // 
            // colQuantity
            // 
            colQuantity.Text = "Quantity";
            colQuantity.Width = 100;
            // 
            // gbProduct
            // 
            gbProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbProduct.BackColor = Color.Silver;
            gbProduct.Controls.Add(btnCancel);
            gbProduct.Controls.Add(btnSave);
            gbProduct.Controls.Add(txtPrice);
            gbProduct.Controls.Add(txtQuantity);
            gbProduct.Controls.Add(label2);
            gbProduct.Controls.Add(label1);
            gbProduct.Controls.Add(txtName);
            gbProduct.Controls.Add(lbName);
            gbProduct.Location = new Point(489, 50);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(233, 246);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "New Product";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(120, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(6, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(221, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(6, 142);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(221, 23);
            txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 124);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Quantity";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(6, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 23);
            txtName.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 36);
            lbName.Name = "lbName";
            lbName.Size = new Size(84, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Product Name";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(361, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Location = new Point(276, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 350);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(gbProduct);
            Controls.Add(lvProduct);
            Name = "Form1";
            Text = "Form1";
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvProduct;
        private GroupBox gbProduct;
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colQuantity;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private Label lbName;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
    }
}