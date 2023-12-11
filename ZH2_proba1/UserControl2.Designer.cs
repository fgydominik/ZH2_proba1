namespace ZH2_proba1
{
    partial class UserControl2
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
            listBoxKategoria = new ListBox();
            textBoxKategoriaSzures = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBoxJatekok = new ListBox();
            SuspendLayout();
            // 
            // listBoxKategoria
            // 
            listBoxKategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxKategoria.FormattingEnabled = true;
            listBoxKategoria.ItemHeight = 20;
            listBoxKategoria.Location = new Point(153, 101);
            listBoxKategoria.Name = "listBoxKategoria";
            listBoxKategoria.Size = new Size(221, 404);
            listBoxKategoria.TabIndex = 5;
            listBoxKategoria.SelectedIndexChanged += listBoxKategoria_SelectedIndexChanged;
            // 
            // textBoxKategoriaSzures
            // 
            textBoxKategoriaSzures.Location = new Point(153, 68);
            textBoxKategoriaSzures.Name = "textBoxKategoriaSzures";
            textBoxKategoriaSzures.Size = new Size(221, 27);
            textBoxKategoriaSzures.TabIndex = 4;
            textBoxKategoriaSzures.TextChanged += textBoxKategoriaSzures_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Szűrés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "Játékok";
            // 
            // listBoxJatekok
            // 
            listBoxJatekok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxJatekok.FormattingEnabled = true;
            listBoxJatekok.ItemHeight = 20;
            listBoxJatekok.Location = new Point(471, 101);
            listBoxJatekok.Name = "listBoxJatekok";
            listBoxJatekok.Size = new Size(453, 404);
            listBoxJatekok.TabIndex = 7;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(listBoxJatekok);
            Controls.Add(label2);
            Controls.Add(listBoxKategoria);
            Controls.Add(textBoxKategoriaSzures);
            Controls.Add(label1);
            Name = "UserControl2";
            Size = new Size(1104, 553);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxKategoria;
        private TextBox textBoxKategoriaSzures;
        private Label label1;
        private Label label2;
        private ListBox listBoxJatekok;
    }
}
