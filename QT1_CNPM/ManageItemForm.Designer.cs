namespace QT1_CNPM
{
    partial class ManageItemForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.iItemPrice = new System.Windows.Forms.TextBox();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iItemSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iItemName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // iItemPrice
            // 
            this.iItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iItemPrice.Location = new System.Drawing.Point(12, 223);
            this.iItemPrice.Name = "iItemPrice";
            this.iItemPrice.Size = new System.Drawing.Size(333, 38);
            this.iItemPrice.TabIndex = 20;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemAdd.Location = new System.Drawing.Point(12, 295);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(179, 52);
            this.btnItemAdd.TabIndex = 19;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size";
            // 
            // iItemSize
            // 
            this.iItemSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iItemSize.Location = new System.Drawing.Point(9, 133);
            this.iItemSize.Name = "iItemSize";
            this.iItemSize.Size = new System.Drawing.Size(333, 38);
            this.iItemSize.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // iItemName
            // 
            this.iItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iItemName.Location = new System.Drawing.Point(9, 46);
            this.iItemName.Name = "iItemName";
            this.iItemName.Size = new System.Drawing.Size(333, 38);
            this.iItemName.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 335);
            this.dataGridView1.TabIndex = 14;
            // 
            // ManageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iItemPrice);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iItemSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iItemName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageItemForm";
            this.Text = "Manage Item";
            this.Load += new System.EventHandler(this.ManageItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iItemPrice;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iItemSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iItemName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}