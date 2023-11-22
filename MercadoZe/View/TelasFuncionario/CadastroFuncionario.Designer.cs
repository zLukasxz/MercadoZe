namespace MercadoZe.View.TelasFuncionario
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_EmailFunci = new TextBox();
            txb_NomeFunci = new TextBox();
            btn_CadastrarFunci = new Button();
            txb_FoneFunci = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 29);
            label1.Name = "label1";
            label1.Size = new Size(271, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(489, 108);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(486, 196);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(477, 284);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // txb_EmailFunci
            // 
            txb_EmailFunci.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_EmailFunci.Location = new Point(371, 236);
            txb_EmailFunci.Name = "txb_EmailFunci";
            txb_EmailFunci.Size = new Size(293, 26);
            txb_EmailFunci.TabIndex = 5;
            // 
            // txb_NomeFunci
            // 
            txb_NomeFunci.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_NomeFunci.Location = new Point(371, 148);
            txb_NomeFunci.Name = "txb_NomeFunci";
            txb_NomeFunci.Size = new Size(293, 26);
            txb_NomeFunci.TabIndex = 6;
            // 
            // btn_CadastrarFunci
            // 
            btn_CadastrarFunci.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadastrarFunci.Location = new Point(451, 376);
            btn_CadastrarFunci.Name = "btn_CadastrarFunci";
            btn_CadastrarFunci.Size = new Size(133, 40);
            btn_CadastrarFunci.TabIndex = 7;
            btn_CadastrarFunci.Text = "Cadastrar";
            btn_CadastrarFunci.UseVisualStyleBackColor = true;
            btn_CadastrarFunci.Click += btn_CadastrarFunci_Click_1;
            // 
            // txb_FoneFunci
            // 
            txb_FoneFunci.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_FoneFunci.Location = new Point(465, 324);
            txb_FoneFunci.Name = "txb_FoneFunci";
            txb_FoneFunci.Size = new Size(105, 26);
            txb_FoneFunci.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txb_FoneFunci);
            Controls.Add(btn_CadastrarFunci);
            Controls.Add(txb_NomeFunci);
            Controls.Add(txb_EmailFunci);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private TextBox txb_EmailFunci;
        private TextBox txb_NomeFunci;
        private Button btn_CadastrarFunci;
        private TextBox txb_FoneFunci;
        private PictureBox pictureBox1;
    }
}