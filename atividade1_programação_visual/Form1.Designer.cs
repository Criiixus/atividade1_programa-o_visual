namespace atividade1_programação_visual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            btnSaudacao = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(124, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Digite seu Nome:";
            lblNome.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // btnSaudacao
            // 
            btnSaudacao.Location = new Point(273, 22);
            btnSaudacao.Name = "btnSaudacao";
            btnSaudacao.Size = new Size(157, 29);
            btnSaudacao.TabIndex = 2;
            btnSaudacao.Text = "Exibir Saudação";
            btnSaudacao.UseVisualStyleBackColor = true;
            btnSaudacao.Click += btnSaudacao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaudacao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnSaudacao;
    }
}
