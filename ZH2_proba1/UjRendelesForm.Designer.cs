namespace ZH2_proba1
{
    partial class UjRendelesForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            buttonOk = new Button();
            buttonMégse = new Button();
            textBoxDb = new TextBox();
            label2 = new Label();
            rendeleBindingSource = new BindingSource(components);
            gameBindingSource = new BindingSource(components);
            textBoxjatek = new TextBox();
            ((System.ComponentModel.ISupportInitialize)rendeleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Játék:";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(332, 193);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonMégse
            // 
            buttonMégse.Location = new Point(232, 193);
            buttonMégse.Name = "buttonMégse";
            buttonMégse.Size = new Size(94, 29);
            buttonMégse.TabIndex = 2;
            buttonMégse.Text = "&Mégse";
            buttonMégse.UseVisualStyleBackColor = true;
            buttonMégse.Click += buttonMégse_Click;
            // 
            // textBoxDb
            // 
            textBoxDb.Location = new Point(23, 111);
            textBoxDb.Name = "textBoxDb";
            textBoxDb.Size = new Size(243, 27);
            textBoxDb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 4;
            label2.Text = "Mennyiség (db):";
            // 
            // rendeleBindingSource
            // 
            rendeleBindingSource.DataSource = typeof(Models.Rendele);
            // 
            // gameBindingSource
            // 
            gameBindingSource.DataSource = typeof(Models.Game);
            // 
            // textBoxjatek
            // 
            textBoxjatek.Location = new Point(23, 44);
            textBoxjatek.Name = "textBoxjatek";
            textBoxjatek.Size = new Size(243, 27);
            textBoxjatek.TabIndex = 6;
            // 
            // UjRendelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 234);
            Controls.Add(textBoxjatek);
            Controls.Add(textBoxDb);
            Controls.Add(label2);
            Controls.Add(buttonMégse);
            Controls.Add(buttonOk);
            Controls.Add(label1);
            Name = "UjRendelesForm";
            Text = "UjRendelesForm";
            Load += UjRendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)rendeleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOk;
        private Button buttonMégse;
        private Label label2;
        public TextBox textBoxDb;
        private BindingSource gameBindingSource;
        private BindingSource rendeleBindingSource;
        public TextBox textBoxjatek;
    }
}