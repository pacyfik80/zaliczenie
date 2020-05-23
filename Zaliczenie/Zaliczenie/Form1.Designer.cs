namespace Zaliczenie
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sweetDataSet = new Zaliczenie.sweetDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Zaliczenie.sweetDataSetTableAdapters.KlientTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sweetDataSet1 = new Zaliczenie.sweetDataSet1();
            this.pracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracaTableAdapter = new Zaliczenie.sweetDataSet1TableAdapters.PracaTableAdapter();
            this.sweetDataSet2 = new Zaliczenie.sweetDataSet2();
            this.smakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smakTableAdapter = new Zaliczenie.sweetDataSet2TableAdapters.SmakTableAdapter();
            this.idSmakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaSmakuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSmakDataGridViewTextBoxColumn,
            this.nazwaSmakuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.smakBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(137, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sweetDataSet
            // 
            this.sweetDataSet.DataSetName = "sweetDataSet";
            this.sweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.sweetDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sweetDataSet1
            // 
            this.sweetDataSet1.DataSetName = "sweetDataSet1";
            this.sweetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracaBindingSource
            // 
            this.pracaBindingSource.DataMember = "Praca";
            this.pracaBindingSource.DataSource = this.sweetDataSet1;
            // 
            // pracaTableAdapter
            // 
            this.pracaTableAdapter.ClearBeforeFill = true;
            // 
            // sweetDataSet2
            // 
            this.sweetDataSet2.DataSetName = "sweetDataSet2";
            this.sweetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smakBindingSource
            // 
            this.smakBindingSource.DataMember = "Smak";
            this.smakBindingSource.DataSource = this.sweetDataSet2;
            // 
            // smakTableAdapter
            // 
            this.smakTableAdapter.ClearBeforeFill = true;
            // 
            // idSmakDataGridViewTextBoxColumn
            // 
            this.idSmakDataGridViewTextBoxColumn.DataPropertyName = "idSmak";
            this.idSmakDataGridViewTextBoxColumn.HeaderText = "idSmak";
            this.idSmakDataGridViewTextBoxColumn.Name = "idSmakDataGridViewTextBoxColumn";
            this.idSmakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaSmakuDataGridViewTextBoxColumn
            // 
            this.nazwaSmakuDataGridViewTextBoxColumn.DataPropertyName = "NazwaSmaku";
            this.nazwaSmakuDataGridViewTextBoxColumn.HeaderText = "NazwaSmaku";
            this.nazwaSmakuDataGridViewTextBoxColumn.Name = "nazwaSmakuDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sweetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sweetDataSet sweetDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private sweetDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private sweetDataSet1 sweetDataSet1;
        private System.Windows.Forms.BindingSource pracaBindingSource;
        private sweetDataSet1TableAdapters.PracaTableAdapter pracaTableAdapter;
        private sweetDataSet2 sweetDataSet2;
        private System.Windows.Forms.BindingSource smakBindingSource;
        private sweetDataSet2TableAdapters.SmakTableAdapter smakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSmakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaSmakuDataGridViewTextBoxColumn;
    }
}

