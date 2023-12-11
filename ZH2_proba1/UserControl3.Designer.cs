namespace ZH2_proba1
{
    partial class UserControl3
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            rendelesIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            gameBindingSource = new BindingSource(components);
            mennyisegDbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fizetendoFtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendeleBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            buttonRemove = new Button();
            textBoxOsszeg = new TextBox();
            label1 = new Label();
            listBoxRendelesID = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendeleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { rendelesIdDataGridViewTextBoxColumn, gameFkDataGridViewTextBoxColumn, mennyisegDbDataGridViewTextBoxColumn, fizetendoFtDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rendeleBindingSource;
            dataGridView1.Location = new Point(217, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(567, 451);
            dataGridView1.TabIndex = 0;
            // 
            // rendelesIdDataGridViewTextBoxColumn
            // 
            rendelesIdDataGridViewTextBoxColumn.DataPropertyName = "RendelesId";
            rendelesIdDataGridViewTextBoxColumn.HeaderText = "RendelesId";
            rendelesIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            rendelesIdDataGridViewTextBoxColumn.Name = "rendelesIdDataGridViewTextBoxColumn";
            rendelesIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameFkDataGridViewTextBoxColumn
            // 
            gameFkDataGridViewTextBoxColumn.DataPropertyName = "GameFk";
            gameFkDataGridViewTextBoxColumn.DataSource = gameBindingSource;
            gameFkDataGridViewTextBoxColumn.DisplayMember = "Nev";
            gameFkDataGridViewTextBoxColumn.HeaderText = "GameFk";
            gameFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            gameFkDataGridViewTextBoxColumn.Name = "gameFkDataGridViewTextBoxColumn";
            gameFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            gameFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            gameFkDataGridViewTextBoxColumn.ValueMember = "GameSk";
            gameFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameBindingSource
            // 
            gameBindingSource.DataSource = typeof(Models.Game);
            // 
            // mennyisegDbDataGridViewTextBoxColumn
            // 
            mennyisegDbDataGridViewTextBoxColumn.DataPropertyName = "MennyisegDb";
            mennyisegDbDataGridViewTextBoxColumn.HeaderText = "MennyisegDb";
            mennyisegDbDataGridViewTextBoxColumn.MinimumWidth = 6;
            mennyisegDbDataGridViewTextBoxColumn.Name = "mennyisegDbDataGridViewTextBoxColumn";
            mennyisegDbDataGridViewTextBoxColumn.Width = 125;
            // 
            // fizetendoFtDataGridViewTextBoxColumn
            // 
            fizetendoFtDataGridViewTextBoxColumn.DataPropertyName = "FizetendoFt";
            fizetendoFtDataGridViewTextBoxColumn.HeaderText = "FizetendoFt";
            fizetendoFtDataGridViewTextBoxColumn.MinimumWidth = 6;
            fizetendoFtDataGridViewTextBoxColumn.Name = "fizetendoFtDataGridViewTextBoxColumn";
            fizetendoFtDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendeleBindingSource
            // 
            rendeleBindingSource.DataSource = typeof(Models.Rendele);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(810, 26);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(165, 132);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(34, 416);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(150, 49);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "-";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxOsszeg
            // 
            textBoxOsszeg.Location = new Point(810, 450);
            textBoxOsszeg.Name = "textBoxOsszeg";
            textBoxOsszeg.Size = new Size(165, 27);
            textBoxOsszeg.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(810, 427);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Rendelések Összege:";
            // 
            // listBoxRendelesID
            // 
            listBoxRendelesID.FormattingEnabled = true;
            listBoxRendelesID.ItemHeight = 20;
            listBoxRendelesID.Location = new Point(34, 26);
            listBoxRendelesID.Name = "listBoxRendelesID";
            listBoxRendelesID.Size = new Size(150, 384);
            listBoxRendelesID.TabIndex = 5;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(listBoxRendelesID);
            Controls.Add(label1);
            Controls.Add(textBoxOsszeg);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "UserControl3";
            Size = new Size(1003, 507);
            Load += UserControl3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendeleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonRemove;
        private TextBox textBoxOsszeg;
        private Label label1;
        private BindingSource rendeleBindingSource;
        private DataGridViewTextBoxColumn rendelesIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn gameFkDataGridViewTextBoxColumn;
        private BindingSource gameBindingSource;
        private DataGridViewTextBoxColumn mennyisegDbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fizetendoFtDataGridViewTextBoxColumn;
        public ListBox listBoxRendelesID;
    }
}
