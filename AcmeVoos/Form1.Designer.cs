
namespace AcmeVoos
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
            this.groupEditIncluir = new System.Windows.Forms.Panel();
            this.numNivelDor = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.rdSim = new System.Windows.Forms.RadioButton();
            this.rdNao = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.panelListViewOptions = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupEditIncluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNivelDor)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelListViewOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupEditIncluir
            // 
            this.groupEditIncluir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupEditIncluir.Controls.Add(this.numNivelDor);
            this.groupEditIncluir.Controls.Add(this.txtDistancia);
            this.groupEditIncluir.Controls.Add(this.txtCusto);
            this.groupEditIncluir.Controls.Add(this.mskData);
            this.groupEditIncluir.Controls.Add(this.rdSim);
            this.groupEditIncluir.Controls.Add(this.rdNao);
            this.groupEditIncluir.Controls.Add(this.btnCancelar);
            this.groupEditIncluir.Controls.Add(this.btnSalvar);
            this.groupEditIncluir.Controls.Add(this.label5);
            this.groupEditIncluir.Controls.Add(this.label4);
            this.groupEditIncluir.Controls.Add(this.label3);
            this.groupEditIncluir.Controls.Add(this.label2);
            this.groupEditIncluir.Controls.Add(this.label1);
            this.groupEditIncluir.Enabled = false;
            this.groupEditIncluir.Location = new System.Drawing.Point(386, 81);
            this.groupEditIncluir.Name = "groupEditIncluir";
            this.groupEditIncluir.Size = new System.Drawing.Size(290, 298);
            this.groupEditIncluir.TabIndex = 0;
            // 
            // numNivelDor
            // 
            this.numNivelDor.Location = new System.Drawing.Point(83, 193);
            this.numNivelDor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNivelDor.Name = "numNivelDor";
            this.numNivelDor.ReadOnly = true;
            this.numNivelDor.Size = new System.Drawing.Size(183, 20);
            this.numNivelDor.TabIndex = 16;
            this.numNivelDor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numNivelDor_KeyPress);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(83, 101);
            this.txtDistancia.MaxLength = 10;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(184, 20);
            this.txtDistancia.TabIndex = 15;
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(83, 66);
            this.txtCusto.MaxLength = 10;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(184, 20);
            this.txtCusto.TabIndex = 14;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(83, 28);
            this.mskData.Mask = "00/00/0000 90:00";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(184, 20);
            this.mskData.TabIndex = 13;
            this.mskData.ValidatingType = typeof(System.DateTime);
            this.mskData.Enter += new System.EventHandler(this.mskData_Enter);
            // 
            // rdSim
            // 
            this.rdSim.AutoSize = true;
            this.rdSim.Location = new System.Drawing.Point(151, 150);
            this.rdSim.Name = "rdSim";
            this.rdSim.Size = new System.Drawing.Size(42, 17);
            this.rdSim.TabIndex = 12;
            this.rdSim.TabStop = true;
            this.rdSim.Text = "Sim";
            this.rdSim.UseVisualStyleBackColor = true;
            // 
            // rdNao
            // 
            this.rdNao.AutoSize = true;
            this.rdNao.Location = new System.Drawing.Point(88, 150);
            this.rdNao.Name = "rdNao";
            this.rdNao.Size = new System.Drawing.Size(45, 17);
            this.rdNao.TabIndex = 11;
            this.rdNao.TabStop = true;
            this.rdNao.Text = "Nao";
            this.rdNao.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 20);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(31, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel Dor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Captura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distância:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExluir);
            this.panel2.Controls.Add(this.btnIncluir);
            this.panel2.Location = new System.Drawing.Point(386, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 46);
            this.panel2.TabIndex = 1;
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(80, 13);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(64, 20);
            this.btnExluir.TabIndex = 1;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(10, 13);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(64, 20);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listView);
            this.panel3.Controls.Add(this.panelListViewOptions);
            this.panel3.Location = new System.Drawing.Point(10, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 360);
            this.panel3.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(354, 319);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // panelListViewOptions
            // 
            this.panelListViewOptions.Controls.Add(this.btnExportar);
            this.panelListViewOptions.Controls.Add(this.btnLimpar);
            this.panelListViewOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListViewOptions.Location = new System.Drawing.Point(0, 319);
            this.panelListViewOptions.Name = "panelListViewOptions";
            this.panelListViewOptions.Size = new System.Drawing.Size(354, 39);
            this.panelListViewOptions.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(80, 10);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(64, 20);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(10, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupEditIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupEditIncluir.ResumeLayout(false);
            this.groupEditIncluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNivelDor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelListViewOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupEditIncluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSim;
        private System.Windows.Forms.RadioButton rdNao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panelListViewOptions;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.NumericUpDown numNivelDor;
    }
}

