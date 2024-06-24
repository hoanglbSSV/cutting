namespace DemoLinearCut
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportInput = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowRstl = new System.Windows.Forms.Button();
            this.txtRslt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.groupBox1.Controls.Add(this.dgvParts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách part cần cắt";
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.Quantity,
            this.Length});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParts.Location = new System.Drawing.Point(6, 25);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(432, 428);
            this.dgvParts.TabIndex = 1;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "PARTNAME";
            this.PartName.Name = "PartName";
            // 
            // Quantity
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity.HeaderText = "QUANTITY (Int)";
            this.Quantity.Name = "Quantity";
            // 
            // Length
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Length.DefaultCellStyle = dataGridViewCellStyle3;
            this.Length.HeaderText = "LENGTH (IN)";
            this.Length.Name = "Length";
            // 
            // btnImportInput
            // 
            this.btnImportInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnImportInput.Location = new System.Drawing.Point(324, 49);
            this.btnImportInput.Name = "btnImportInput";
            this.btnImportInput.Size = new System.Drawing.Size(321, 38);
            this.btnImportInput.TabIndex = 17;
            this.btnImportInput.Text = "Import excel";
            this.btnImportInput.UseVisualStyleBackColor = true;
            this.btnImportInput.Click += new System.EventHandler(this.btnImportInput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(585, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "INPUT Có thể nhập hoặc Import Excel";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.groupBox2.Controls.Add(this.dgvStocks);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(480, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 459);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các chiều dài có sẵn trong stock";
            // 
            // dgvStocks
            // 
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.QuantityStock,
            this.LengthStock});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStocks.Location = new System.Drawing.Point(6, 25);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.Size = new System.Drawing.Size(423, 428);
            this.dgvStocks.TabIndex = 2;
            // 
            // Serial
            // 
            this.Serial.FillWeight = 71.03047F;
            this.Serial.HeaderText = "SERIAL";
            this.Serial.Name = "Serial";
            // 
            // QuantityStock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuantityStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.QuantityStock.FillWeight = 76.68526F;
            this.QuantityStock.HeaderText = "QUANTITY (Int)";
            this.QuantityStock.Name = "QuantityStock";
            // 
            // LengthStock
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LengthStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.LengthStock.FillWeight = 152.2843F;
            this.LengthStock.HeaderText = "LENGTH (IN)";
            this.LengthStock.Name = "LengthStock";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnReset.Location = new System.Drawing.Point(212, 558);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(193, 38);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "RESET FORM";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowRstl
            // 
            this.btnShowRstl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnShowRstl.Location = new System.Drawing.Point(13, 558);
            this.btnShowRstl.Name = "btnShowRstl";
            this.btnShowRstl.Size = new System.Drawing.Size(193, 38);
            this.btnShowRstl.TabIndex = 19;
            this.btnShowRstl.Text = "SHOW RESULTS";
            this.btnShowRstl.UseVisualStyleBackColor = true;
            this.btnShowRstl.Click += new System.EventHandler(this.btnShowRstl_Click);
            // 
            // txtRslt
            // 
            this.txtRslt.Location = new System.Drawing.Point(17, 610);
            this.txtRslt.Multiline = true;
            this.txtRslt.Name = "txtRslt";
            this.txtRslt.Size = new System.Drawing.Size(891, 344);
            this.txtRslt.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 978);
            this.Controls.Add(this.txtRslt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowRstl);
            this.Controls.Add(this.btnImportInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cutting-Stock Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnImportInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowRstl;
        private System.Windows.Forms.TextBox txtRslt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthStock;
    }
}

