namespace ZH2_proba1
{
    partial class UserControl1
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
            label1 = new Label();
            textBoxGameSzures = new TextBox();
            listBoxGame = new ListBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Szűrés";
            // 
            // textBoxGameSzures
            // 
            textBoxGameSzures.Location = new Point(54, 47);
            textBoxGameSzures.Name = "textBoxGameSzures";
            textBoxGameSzures.Size = new Size(221, 27);
            textBoxGameSzures.TabIndex = 1;
            textBoxGameSzures.TextChanged += textBoxGameSzures_TextChanged;
            // 
            // listBoxGame
            // 
            listBoxGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxGame.FormattingEnabled = true;
            listBoxGame.ItemHeight = 20;
            listBoxGame.Location = new Point(54, 80);
            listBoxGame.Name = "listBoxGame";
            listBoxGame.Size = new Size(221, 344);
            listBoxGame.TabIndex = 2;
            listBoxGame.SelectedIndexChanged += listBoxGame_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(607, 377);
            dataGridView1.TabIndex = 3;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(listBoxGame);
            Controls.Add(textBoxGameSzures);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(982, 458);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxGameSzures;
        private ListBox listBoxGame;
        private DataGridView dataGridView1;
    }
}
