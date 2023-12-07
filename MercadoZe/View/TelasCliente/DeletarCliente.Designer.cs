namespace MercadoZe.View.TelasCliente
{
    partial class DeletarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarCliente));
            pictureBox1 = new PictureBox();
            btn_Excluir = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txb_MatriculaCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txb_Nome = new TextBox();
            txb_Email = new TextBox();
            txb_Fone = new TextBox();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(481, 377);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(133, 40);
            btn_Excluir.TabIndex = 40;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(414, 282);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 34;
            label5.Text = "Fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(402, 238);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 33;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(409, 194);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 32;
            label3.Text = "Nome:";
            // 
            // txb_MatriculaCliente
            // 
            txb_MatriculaCliente.Location = new Point(406, 97);
            txb_MatriculaCliente.Name = "txb_MatriculaCliente";
            txb_MatriculaCliente.Size = new Size(130, 23);
            txb_MatriculaCliente.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 97);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 29;
            label2.Text = "Digite a Matrícula do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 26);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 28;
            label1.Text = "Excluir Cliente";
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Nome.Location = new Point(471, 194);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(267, 26);
            txb_Nome.TabIndex = 42;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Email.Location = new Point(471, 236);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(267, 26);
            txb_Email.TabIndex = 43;
            // 
            // txb_Fone
            // 
            txb_Fone.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Fone.Location = new Point(471, 282);
            txb_Fone.Name = "txb_Fone";
            txb_Fone.Size = new Size(267, 26);
            txb_Fone.TabIndex = 44;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(558, 87);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(133, 40);
            btn_Buscar.TabIndex = 45;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // DeletarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 435);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_Fone);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Excluir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_MatriculaCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeletarCliente";
            Text = "DeletarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Excluir;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_BuscarUsuario;
        private TextBox txb_MatriculaCliente;
        private Label label2;
        private Label label1;
        private TextBox txb_Nome;
        private TextBox txb_Email;
        private TextBox txb_Fone;
        private Button btn_Buscar;
    }
}