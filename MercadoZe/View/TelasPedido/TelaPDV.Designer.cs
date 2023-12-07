namespace MercadoZe.View.TelasPedido
{
    partial class TelaPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPDV));
            label1 = new Label();
            dgv_PDV = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txb_Qtd = new TextBox();
            txb_CodBarras = new TextBox();
            lbl_CodBarras = new Label();
            lbl_Produto = new Label();
            lbl_Qtd = new Label();
            lbl_ValorUnit = new Label();
            label12 = new Label();
            btn_Venda = new Button();
            btn_Confirma = new Button();
            pictureBox1 = new PictureBox();
            lbl_ValorTotalFinal = new Label();
            label8 = new Label();
            button1 = new Button();
            lbl_ValorTotal = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 20);
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 0;
            label1.Text = "PDV Mercado do Zé";
            // 
            // dgv_PDV
            // 
            dgv_PDV.BackgroundColor = SystemColors.Control;
            dgv_PDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PDV.Location = new Point(21, 141);
            dgv_PDV.Name = "dgv_PDV";
            dgv_PDV.RowHeadersVisible = false;
            dgv_PDV.RowTemplate.Height = 25;
            dgv_PDV.Size = new Size(559, 275);
            dgv_PDV.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 102);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 3;
            label3.Text = "Código de Barras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(342, 102);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 4;
            label4.Text = "Quantidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(640, 146);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 5;
            label5.Text = "Código de Barras:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(720, 211);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 6;
            label6.Text = "Produto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(683, 276);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 7;
            label7.Text = "Quantidade:";
            // 
            // txb_Qtd
            // 
            txb_Qtd.Location = new Point(469, 100);
            txb_Qtd.Margin = new Padding(2);
            txb_Qtd.Name = "txb_Qtd";
            txb_Qtd.Size = new Size(111, 26);
            txb_Qtd.TabIndex = 8;
            // 
            // txb_CodBarras
            // 
            txb_CodBarras.Location = new Point(189, 100);
            txb_CodBarras.Margin = new Padding(2);
            txb_CodBarras.Name = "txb_CodBarras";
            txb_CodBarras.Size = new Size(150, 26);
            txb_CodBarras.TabIndex = 9;
            // 
            // lbl_CodBarras
            // 
            lbl_CodBarras.BackColor = SystemColors.Control;
            lbl_CodBarras.Location = new Point(608, 167);
            lbl_CodBarras.Margin = new Padding(2, 0, 2, 0);
            lbl_CodBarras.Name = "lbl_CodBarras";
            lbl_CodBarras.Size = new Size(186, 34);
            lbl_CodBarras.TabIndex = 10;
            // 
            // lbl_Produto
            // 
            lbl_Produto.BackColor = SystemColors.Control;
            lbl_Produto.Location = new Point(608, 232);
            lbl_Produto.Margin = new Padding(2, 0, 2, 0);
            lbl_Produto.Name = "lbl_Produto";
            lbl_Produto.Size = new Size(186, 34);
            lbl_Produto.TabIndex = 11;
            // 
            // lbl_Qtd
            // 
            lbl_Qtd.BackColor = SystemColors.Control;
            lbl_Qtd.Location = new Point(608, 297);
            lbl_Qtd.Margin = new Padding(2, 0, 2, 0);
            lbl_Qtd.Name = "lbl_Qtd";
            lbl_Qtd.Size = new Size(186, 34);
            lbl_Qtd.TabIndex = 12;
            // 
            // lbl_ValorUnit
            // 
            lbl_ValorUnit.BackColor = SystemColors.Control;
            lbl_ValorUnit.Location = new Point(608, 362);
            lbl_ValorUnit.Margin = new Padding(2, 0, 2, 0);
            lbl_ValorUnit.Name = "lbl_ValorUnit";
            lbl_ValorUnit.Size = new Size(186, 34);
            lbl_ValorUnit.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(694, 341);
            label12.Name = "label12";
            label12.Size = new Size(121, 21);
            label12.TabIndex = 13;
            label12.Text = "Valor Unitário:";
            // 
            // btn_Venda
            // 
            btn_Venda.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Venda.Location = new Point(21, 475);
            btn_Venda.Margin = new Padding(2);
            btn_Venda.Name = "btn_Venda";
            btn_Venda.Size = new Size(559, 55);
            btn_Venda.TabIndex = 15;
            btn_Venda.Text = "Fechar Venda";
            btn_Venda.UseVisualStyleBackColor = true;
            // 
            // btn_Confirma
            // 
            btn_Confirma.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirma.Location = new Point(608, 94);
            btn_Confirma.Margin = new Padding(2);
            btn_Confirma.Name = "btn_Confirma";
            btn_Confirma.Size = new Size(186, 39);
            btn_Confirma.TabIndex = 16;
            btn_Confirma.Text = "Buscar";
            btn_Confirma.UseVisualStyleBackColor = true;
            btn_Confirma.Click += btn_Confirma_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lbl_ValorTotalFinal
            // 
            lbl_ValorTotalFinal.BackColor = SystemColors.Control;
            lbl_ValorTotalFinal.Font = new Font("Caviar Dreams", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ValorTotalFinal.Location = new Point(608, 45);
            lbl_ValorTotalFinal.Margin = new Padding(2, 0, 2, 0);
            lbl_ValorTotalFinal.Name = "lbl_ValorTotalFinal";
            lbl_ValorTotalFinal.Size = new Size(186, 34);
            lbl_ValorTotalFinal.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(632, 13);
            label8.Name = "label8";
            label8.Size = new Size(142, 21);
            label8.TabIndex = 18;
            label8.Text = "Valor Total Final:";
            // 
            // button1
            // 
            button1.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(608, 483);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(186, 39);
            button1.TabIndex = 20;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.BackColor = SystemColors.Control;
            lbl_ValorTotal.Location = new Point(610, 427);
            lbl_ValorTotal.Margin = new Padding(2, 0, 2, 0);
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            lbl_ValorTotal.Size = new Size(186, 34);
            lbl_ValorTotal.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(694, 406);
            label10.Name = "label10";
            label10.Size = new Size(100, 21);
            label10.TabIndex = 21;
            label10.Text = "Valor Total:";
            // 
            // TelaPDV
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 541);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(lbl_ValorTotalFinal);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Confirma);
            Controls.Add(btn_Venda);
            Controls.Add(lbl_ValorUnit);
            Controls.Add(label12);
            Controls.Add(lbl_Qtd);
            Controls.Add(lbl_Produto);
            Controls.Add(lbl_CodBarras);
            Controls.Add(txb_CodBarras);
            Controls.Add(txb_Qtd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgv_PDV);
            Controls.Add(label1);
            Font = new Font("Caviar Dreams", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "TelaPDV";
            Text = "TelaPDV";
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_PDV;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txb_Qtd;
        private TextBox txb_CodBarras;
        private Label lbl_CodBarras;
        private Label lbl_Produto;
        private Label lbl_Qtd;
        private Label lbl_ValorUnit;
        private Label label12;
        private Button btn_Venda;
        private Button btn_Confirma;
        private PictureBox pictureBox1;
        private Label lbl_ValorTotalFinal;
        private Label label8;
        private Button button1;
        private Label lbl_ValorTotal;
        private Label label10;
    }
}