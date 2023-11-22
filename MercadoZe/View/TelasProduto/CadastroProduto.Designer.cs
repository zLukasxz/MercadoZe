namespace MercadoZe.View.TelasProduto
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            label1 = new Label();
            lbl_nomeProduto = new Label();
            lbl_marcaProduto = new Label();
            lbl_valorProduto = new Label();
            pictureBox1 = new PictureBox();
            btn_CadastroProduto = new Button();
            txb_nomeProduto = new TextBox();
            txb_marcaProduto = new TextBox();
            txb_valorProduto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 30);
            label1.Name = "label1";
            label1.Size = new Size(231, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // lbl_nomeProduto
            // 
            lbl_nomeProduto.AutoSize = true;
            lbl_nomeProduto.BackColor = Color.Transparent;
            lbl_nomeProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nomeProduto.Location = new Point(486, 107);
            lbl_nomeProduto.Name = "lbl_nomeProduto";
            lbl_nomeProduto.Size = new Size(56, 21);
            lbl_nomeProduto.TabIndex = 1;
            lbl_nomeProduto.Text = "Nome:";
            // 
            // lbl_marcaProduto
            // 
            lbl_marcaProduto.AutoSize = true;
            lbl_marcaProduto.BackColor = Color.Transparent;
            lbl_marcaProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_marcaProduto.Location = new Point(482, 195);
            lbl_marcaProduto.Name = "lbl_marcaProduto";
            lbl_marcaProduto.Size = new Size(65, 21);
            lbl_marcaProduto.TabIndex = 2;
            lbl_marcaProduto.Text = "Marca:";
            // 
            // lbl_valorProduto
            // 
            lbl_valorProduto.AutoSize = true;
            lbl_valorProduto.BackColor = Color.Transparent;
            lbl_valorProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valorProduto.Location = new Point(487, 283);
            lbl_valorProduto.Name = "lbl_valorProduto";
            lbl_valorProduto.Size = new Size(55, 21);
            lbl_valorProduto.TabIndex = 3;
            lbl_valorProduto.Text = "Valor:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_CadastroProduto
            // 
            btn_CadastroProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadastroProduto.Location = new Point(448, 376);
            btn_CadastroProduto.Name = "btn_CadastroProduto";
            btn_CadastroProduto.Size = new Size(133, 40);
            btn_CadastroProduto.TabIndex = 5;
            btn_CadastroProduto.Text = "Cadastrar";
            btn_CadastroProduto.UseVisualStyleBackColor = true;
            btn_CadastroProduto.Click += btn_CadastroProduto_Click;
            // 
            // txb_nomeProduto
            // 
            txb_nomeProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nomeProduto.Location = new Point(368, 148);
            txb_nomeProduto.Name = "txb_nomeProduto";
            txb_nomeProduto.Size = new Size(293, 26);
            txb_nomeProduto.TabIndex = 6;
            // 
            // txb_marcaProduto
            // 
            txb_marcaProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_marcaProduto.Location = new Point(368, 236);
            txb_marcaProduto.Name = "txb_marcaProduto";
            txb_marcaProduto.Size = new Size(293, 26);
            txb_marcaProduto.TabIndex = 7;
            // 
            // txb_valorProduto
            // 
            txb_valorProduto.Font = new Font("Caviar Dreams", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_valorProduto.Location = new Point(462, 320);
            txb_valorProduto.Name = "txb_valorProduto";
            txb_valorProduto.Size = new Size(105, 26);
            txb_valorProduto.TabIndex = 8;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txb_valorProduto);
            Controls.Add(txb_marcaProduto);
            Controls.Add(txb_nomeProduto);
            Controls.Add(btn_CadastroProduto);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_valorProduto);
            Controls.Add(lbl_marcaProduto);
            Controls.Add(lbl_nomeProduto);
            Controls.Add(label1);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_nomeProduto;
        private Label lbl_marcaProduto;
        private Label lbl_valorProduto;
        private PictureBox pictureBox1;
        private Button btn_CadastroProduto;
        private TextBox txb_nomeProduto;
        private TextBox txb_marcaProduto;
        private TextBox txb_valorProduto;
    }
}