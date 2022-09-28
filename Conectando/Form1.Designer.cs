namespace Conectando
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMAil = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(57, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(57, 100);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 18);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblMAil
            // 
            this.lblMAil.AutoSize = true;
            this.lblMAil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMAil.Location = new System.Drawing.Point(61, 160);
            this.lblMAil.Name = "lblMAil";
            this.lblMAil.Size = new System.Drawing.Size(47, 18);
            this.lblMAil.TabIndex = 2;
            this.lblMAil.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 31);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(552, 23);
            this.txtNome.TabIndex = 3;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(141, 92);
            this.txtFone.Multiline = true;
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(546, 23);
            this.txtFone.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(141, 157);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(546, 23);
            this.txtMail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(57, 250);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(224, 133);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMAil);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblTelefone;
        private Label lblMAil;
        private TextBox txtNome;
        private TextBox txtFone;
        private TextBox txtMail;
        private Button btnSalvar;
    }
}