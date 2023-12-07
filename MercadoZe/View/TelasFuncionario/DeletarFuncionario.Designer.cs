namespace MercadoZe.View.TelasFuncionario
{
    partial class DeletarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarFuncionario));
            btn_Buscar = new Button();
            txb_Fone = new TextBox();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Excluir = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txb_MatriculaFunci = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(564, 91);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(133, 40);
            btn_Buscar.TabIndex = 57;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txb_Fone
            // 
            txb_Fone.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Fone.Location = new Point(477, 286);
            txb_Fone.Name = "txb_Fone";
            txb_Fone.Size = new Size(267, 26);
            txb_Fone.TabIndex = 56;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Email.Location = new Point(477, 240);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(267, 26);
            txb_Email.TabIndex = 55;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Nome.Location = new Point(477, 198);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(267, 26);
            txb_Nome.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(487, 381);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(133, 40);
            btn_Excluir.TabIndex = 52;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(420, 286);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 51;
            label5.Text = "Fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(408, 242);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 50;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(415, 198);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 49;
            label3.Text = "Nome:";
            // 
            // txb_MatriculaFunci
            // 
            txb_MatriculaFunci.Location = new Point(412, 101);
            txb_MatriculaFunci.Name = "txb_MatriculaFunci";
            txb_MatriculaFunci.Size = new Size(130, 23);
            txb_MatriculaFunci.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 100);
            label2.Name = "label2";
            label2.Size = new Size(278, 21);
            label2.TabIndex = 47;
            label2.Text = "Digite a Matrícula do Funcionário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 30);
            label1.Name = "label1";
            label1.Size = new Size(206, 27);
            label1.TabIndex = 46;
            label1.Text = "Excluir Funcionário";
            // 
            // DeletarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_Fone);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Excluir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_MatriculaFunci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeletarFuncionario";
            Text = "DeletarFuncionario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private TextBox txb_Fone;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private PictureBox pictureBox1;
        private Button btn_Excluir;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txb_MatriculaFunci;
        private Label label2;
        private Label label1;
    }
}