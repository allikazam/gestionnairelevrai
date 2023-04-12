namespace gestionnaire
{
    partial class materiel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaireDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaireDataSet = new gestionnaire.gestionnaireDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.produitsTableAdapter = new gestionnaire.gestionnaireDataSetTableAdapters.ProduitsTableAdapter();
            this.gestionnaireDataSet6 = new gestionnaire.gestionnaireDataSet6();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materielTableAdapter = new gestionnaire.gestionnaireDataSet6TableAdapters.MaterielTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteEnStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gestionnaireDataSet7 = new gestionnaire.gestionnaireDataSet7();
            this.materielBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materielTableAdapter1 = new gestionnaire.gestionnaireDataSet7TableAdapters.MaterielTableAdapter();
            this.gestionnaireDataSet8 = new gestionnaire.gestionnaireDataSet8();
            this.listematerielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listematerielTableAdapter = new gestionnaire.gestionnaireDataSet8TableAdapters.listematerielTableAdapter();
            this.gestionnaireDataSet9 = new gestionnaire.gestionnaireDataSet9();
            this.materielBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materielTableAdapter2 = new gestionnaire.gestionnaireDataSet9TableAdapters.MaterielTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listematerielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matériel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(228, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(225, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(492, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantité";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(741, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantité Minimale";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(741, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantité Maximale";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(28, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(571, 79);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(871, 75);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(871, 122);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 22);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "Supprimer\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Rechercher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.Type,
            this.quantiteEnStockDataGridViewTextBoxColumn,
            this.quantiteMinDataGridViewTextBoxColumn,
            this.quantiteMaxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materielBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(806, 195);
            this.dataGridView1.TabIndex = 19;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "Produits";
            this.produitsBindingSource.DataSource = this.gestionnaireDataSetBindingSource;
            // 
            // gestionnaireDataSetBindingSource
            // 
            this.gestionnaireDataSetBindingSource.DataSource = this.gestionnaireDataSet;
            this.gestionnaireDataSetBindingSource.Position = 0;
            // 
            // gestionnaireDataSet
            // 
            this.gestionnaireDataSet.DataSetName = "gestionnaireDataSet";
            this.gestionnaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Retour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // gestionnaireDataSet6
            // 
            this.gestionnaireDataSet6.DataSetName = "gestionnaireDataSet6";
            this.gestionnaireDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielBindingSource
            // 
            this.materielBindingSource.DataMember = "Materiel";
            this.materielBindingSource.DataSource = this.gestionnaireDataSet6;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // quantiteEnStockDataGridViewTextBoxColumn
            // 
            this.quantiteEnStockDataGridViewTextBoxColumn.DataPropertyName = "QuantiteEnStock";
            this.quantiteEnStockDataGridViewTextBoxColumn.HeaderText = "QuantiteEnStock";
            this.quantiteEnStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteEnStockDataGridViewTextBoxColumn.Name = "quantiteEnStockDataGridViewTextBoxColumn";
            this.quantiteEnStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantiteMinDataGridViewTextBoxColumn
            // 
            this.quantiteMinDataGridViewTextBoxColumn.DataPropertyName = "QuantiteMin";
            this.quantiteMinDataGridViewTextBoxColumn.HeaderText = "QuantiteMin";
            this.quantiteMinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteMinDataGridViewTextBoxColumn.Name = "quantiteMinDataGridViewTextBoxColumn";
            this.quantiteMinDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantiteMaxDataGridViewTextBoxColumn
            // 
            this.quantiteMaxDataGridViewTextBoxColumn.DataPropertyName = "QuantiteMax";
            this.quantiteMaxDataGridViewTextBoxColumn.HeaderText = "QuantiteMax";
            this.quantiteMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteMaxDataGridViewTextBoxColumn.Name = "quantiteMaxDataGridViewTextBoxColumn";
            this.quantiteMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listematerielBindingSource, "ListeMateriel", true));
            this.comboBox1.DataSource = this.listematerielBindingSource;
            this.comboBox1.DisplayMember = "ListeMateriel";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.ValueMember = "ListeMateriel";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materielBindingSource1, "Nom", true));
            this.comboBox2.DataSource = this.materielBindingSource2;
            this.comboBox2.DisplayMember = "Nom";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(288, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 24);
            this.comboBox2.TabIndex = 65;
            this.comboBox2.ValueMember = "Nom";
            // 
            // gestionnaireDataSet7
            // 
            this.gestionnaireDataSet7.DataSetName = "gestionnaireDataSet7";
            this.gestionnaireDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielBindingSource1
            // 
            this.materielBindingSource1.DataMember = "Materiel";
            this.materielBindingSource1.DataSource = this.gestionnaireDataSet7;
            // 
            // materielTableAdapter1
            // 
            this.materielTableAdapter1.ClearBeforeFill = true;
            // 
            // gestionnaireDataSet8
            // 
            this.gestionnaireDataSet8.DataSetName = "gestionnaireDataSet8";
            this.gestionnaireDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listematerielBindingSource
            // 
            this.listematerielBindingSource.DataMember = "listemateriel";
            this.listematerielBindingSource.DataSource = this.gestionnaireDataSet8;
            // 
            // listematerielTableAdapter
            // 
            this.listematerielTableAdapter.ClearBeforeFill = true;
            // 
            // gestionnaireDataSet9
            // 
            this.gestionnaireDataSet9.DataSetName = "gestionnaireDataSet9";
            this.gestionnaireDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielBindingSource2
            // 
            this.materielBindingSource2.DataMember = "Materiel";
            this.materielBindingSource2.DataSource = this.gestionnaireDataSet9;
            // 
            // materielTableAdapter2
            // 
            this.materielTableAdapter2.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(850, 169);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 66;
            this.button6.Text = "Retirer";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "materiel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listematerielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestionnaireDataSet gestionnaireDataSet;
        private System.Windows.Forms.BindingSource gestionnaireDataSetBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private gestionnaireDataSetTableAdapters.ProduitsTableAdapter produitsTableAdapter;
        private gestionnaireDataSet6 gestionnaireDataSet6;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private gestionnaireDataSet6TableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEnStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private gestionnaireDataSet7 gestionnaireDataSet7;
        private System.Windows.Forms.BindingSource materielBindingSource1;
        private gestionnaireDataSet7TableAdapters.MaterielTableAdapter materielTableAdapter1;
        private gestionnaireDataSet8 gestionnaireDataSet8;
        private System.Windows.Forms.BindingSource listematerielBindingSource;
        private gestionnaireDataSet8TableAdapters.listematerielTableAdapter listematerielTableAdapter;
        private gestionnaireDataSet9 gestionnaireDataSet9;
        private System.Windows.Forms.BindingSource materielBindingSource2;
        private gestionnaireDataSet9TableAdapters.MaterielTableAdapter materielTableAdapter2;
        private System.Windows.Forms.Button button6;
    }
}