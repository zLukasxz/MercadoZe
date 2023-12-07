namespace MercadoZe.View.TelasCliente
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            pictureBox1 = new PictureBox();
            btn_Alterar = new Button();
            btn_Buscar = new Button();
            txb_MatriculaCliente = new TextBox();
            txb_Fone = new TextBox();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar.Location = new Point(581, 390);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(133, 40);
            btn_Alterar.TabIndex = 30;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(546, 83);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(133, 40);
            btn_Buscar.TabIndex = 29;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txb_MatriculaCliente
            // 
            txb_MatriculaCliente.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_MatriculaCliente.Location = new Point(401, 92);
            txb_MatriculaCliente.Name = "txb_MatriculaCliente";
            txb_MatriculaCliente.Size = new Size(124, 26);
            txb_MatriculaCliente.TabIndex = 28;
            // 
            // txb_Fone
            // 
            txb_Fone.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Fone.Location = new Point(106, 148);
            txb_Fone.Name = "txb_Fone";
            txb_Fone.Size = new Size(227, 26);
            txb_Fone.TabIndex = 25;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Email.Location = new Point(106, 102);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(227, 26);
            txb_Email.TabIndex = 24;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Nome.Location = new Point(106, 56);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(227, 26);
            txb_Nome.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 150);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 20;
            label5.Text = "Fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 104);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 19;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 58);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 18;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 93);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 17;
            label2.Text = "Digite a Matrícula do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 21);
            label1.Name = "label1";
            label1.Size = new Size(161, 27);
            label1.TabIndex = 16;
            label1.Text = "Alterar Cliente";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txb_Nome);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(txb_Fone);
            groupBox1.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(390, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 214);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Cadastro de Cliente";
            // 
            // AlterarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_MatriculaCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarCliente";
            Text = "AlterarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Alterar;
        private Button btn_Buscar;
        private TextBox txb_MatriculaCliente;
        private TextBox txb_Fone;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
    }
}