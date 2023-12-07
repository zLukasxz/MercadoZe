namespace MercadoZe.View.Menu
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            label1 = new Label();
            label2 = new Label();
            txb_UsuarioLogin = new TextBox();
            txb_SenhaLogin = new TextBox();
            btn_Entrar = new Button();
            btn_Sair = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(363, 157);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(367, 250);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // txb_UsuarioLogin
            // 
            txb_UsuarioLogin.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_UsuarioLogin.Location = new Point(304, 181);
            txb_UsuarioLogin.Name = "txb_UsuarioLogin";
            txb_UsuarioLogin.Size = new Size(189, 26);
            txb_UsuarioLogin.TabIndex = 2;
            // 
            // txb_SenhaLogin
            // 
            txb_SenhaLogin.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_SenhaLogin.Location = new Point(304, 274);
            txb_SenhaLogin.Name = "txb_SenhaLogin";
            txb_SenhaLogin.PasswordChar = '*';
            txb_SenhaLogin.Size = new Size(189, 26);
            txb_SenhaLogin.TabIndex = 3;
            // 
            // btn_Entrar
            // 
            btn_Entrar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Entrar.Location = new Point(257, 358);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(133, 40);
            btn_Entrar.TabIndex = 4;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += btn_Entrar_Click_1;
            // 
            // btn_Sair
            // 
            btn_Sair.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sair.Location = new Point(404, 358);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(133, 40);
            btn_Sair.TabIndex = 5;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Entrar);
            Controls.Add(txb_SenhaLogin);
            Controls.Add(txb_UsuarioLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaLogin";
            ShowIcon = false;
            Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_UsuarioLogin;
        private TextBox txb_SenhaLogin;
        private Button btn_Entrar;
        private Button btn_Sair;
        private PictureBox pictureBox1;
    }
}