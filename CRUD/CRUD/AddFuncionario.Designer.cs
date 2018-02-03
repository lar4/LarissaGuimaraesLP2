namespace CRUD
{
    partial class AddFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(63, 101);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(157, 20);
            this.textNome.TabIndex = 2;
            this.textNome.Text = "Digite seu nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(63, 127);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(157, 20);
            this.textEmail.TabIndex = 4;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(63, 153);
            this.textTelefone.Mask = "(00)00000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 20);
            this.textTelefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(62, 182);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(100, 20);
            this.textCPF.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesquisar Nome";
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(107, 75);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(141, 20);
            this.textPesquisar.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(92, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(170, 24);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(75, 23);
            this.btnPesq.TabIndex = 13;
            this.btnPesq.Text = "PESQUISAR";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(252, 24);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 23);
            this.btnDelet.TabIndex = 14;
            this.btnDelet.Text = "DELETAR";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(234, 210);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "EDITAR";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Name = "AddFuncionario";
            this.Text = "Funcionario";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textNome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textEmail, 0);
            this.Controls.SetChildIndex(this.textTelefone, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textCPF, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textPesquisar, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnPesq, 0);
            this.Controls.SetChildIndex(this.btnDelet, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnEdit;
    }
}