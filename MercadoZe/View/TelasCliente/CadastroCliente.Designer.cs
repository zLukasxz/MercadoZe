namespace MercadoZe.View.TelasCliente
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_cadastrar = new Button();
            txb_nome = new TextBox();
            txb_email = new TextBox();
            mtxb_telefone = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 29);
            label1.Name = "label1";
            label1.Size = new Size(224, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
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
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(451, 376);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(133, 40);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(371, 148);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(293, 26);
            txb_nome.TabIndex = 5;
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_email.Location = new Point(371, 236);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(293, 26);
            txb_email.TabIndex = 6;
            // 
            // mtxb_telefone
            // 
            mtxb_telefone.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_telefone.Location = new Point(451, 324);
            mtxb_telefone.Mask = "(99) 0000-0000";
            mtxb_telefone.Name = "mtxb_telefone";
            mtxb_telefone.Size = new Size(133, 26);
            mtxb_telefone.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(733, 447);
            Controls.Add(pictureBox1);
            Controls.Add(mtxb_telefone);
            Controls.Add(txb_email);
            Controls.Add(txb_nome);
            Controls.Add(btn_cadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_cadastrar;
        private TextBox txb_nome;
        private TextBox txb_email;
        private MaskedTextBox mtxb_telefone;
        private PictureBox pictureBox1;
    }
}