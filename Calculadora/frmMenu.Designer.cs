
namespace Calculadora
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.lblhappyface = new System.Windows.Forms.Label();
            this.lblsomasimbolo = new System.Windows.Forms.Label();
            this.lblsubsimbolo = new System.Windows.Forms.Label();
            this.lblmultsimbolo = new System.Windows.Forms.Label();
            this.lbldivsimbolo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(97, 27);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(194, 41);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Calculadora";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblsubtitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblsubtitulo.Location = new System.Drawing.Point(55, 93);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(292, 27);
            this.lblsubtitulo.TabIndex = 10;
            this.lblsubtitulo.Text = "Efetue o cálculo que desejar:\r\n";
            // 
            // btnsoma
            // 
            this.btnsoma.AutoSize = true;
            this.btnsoma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsoma.BackColor = System.Drawing.Color.Black;
            this.btnsoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.ForeColor = System.Drawing.Color.Yellow;
            this.btnsoma.Location = new System.Drawing.Point(145, 156);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(89, 43);
            this.btnsoma.TabIndex = 11;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.AutoSize = true;
            this.btnsubtracao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsubtracao.BackColor = System.Drawing.Color.Black;
            this.btnsubtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubtracao.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtracao.ForeColor = System.Drawing.Color.Red;
            this.btnsubtracao.Location = new System.Drawing.Point(122, 219);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(141, 43);
            this.btnsubtracao.TabIndex = 12;
            this.btnsubtracao.Text = "Subtração";
            this.btnsubtracao.UseVisualStyleBackColor = true;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.AutoSize = true;
            this.btnmultiplicacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmultiplicacao.BackColor = System.Drawing.Color.Black;
            this.btnmultiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmultiplicacao.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacao.ForeColor = System.Drawing.Color.Aqua;
            this.btnmultiplicacao.Location = new System.Drawing.Point(104, 287);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(181, 43);
            this.btnmultiplicacao.TabIndex = 13;
            this.btnmultiplicacao.Text = "Multiplicação";
            this.btnmultiplicacao.UseVisualStyleBackColor = true;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.AutoSize = true;
            this.btndivisao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndivisao.BackColor = System.Drawing.Color.Black;
            this.btndivisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndivisao.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisao.ForeColor = System.Drawing.Color.Lime;
            this.btndivisao.Location = new System.Drawing.Point(136, 360);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(110, 43);
            this.btndivisao.TabIndex = 14;
            this.btndivisao.Text = "Divisão";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // lblhappyface
            // 
            this.lblhappyface.AutoSize = true;
            this.lblhappyface.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblhappyface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblhappyface.Location = new System.Drawing.Point(12, 499);
            this.lblhappyface.Name = "lblhappyface";
            this.lblhappyface.Size = new System.Drawing.Size(19, 19);
            this.lblhappyface.TabIndex = 15;
            this.lblhappyface.Text = ":)";
            // 
            // lblsomasimbolo
            // 
            this.lblsomasimbolo.AutoSize = true;
            this.lblsomasimbolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblsomasimbolo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsomasimbolo.ForeColor = System.Drawing.Color.Yellow;
            this.lblsomasimbolo.Location = new System.Drawing.Point(251, 169);
            this.lblsomasimbolo.Name = "lblsomasimbolo";
            this.lblsomasimbolo.Size = new System.Drawing.Size(21, 21);
            this.lblsomasimbolo.TabIndex = 16;
            this.lblsomasimbolo.Text = "+";
            // 
            // lblsubsimbolo
            // 
            this.lblsubsimbolo.AutoSize = true;
            this.lblsubsimbolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblsubsimbolo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubsimbolo.ForeColor = System.Drawing.Color.Red;
            this.lblsubsimbolo.Location = new System.Drawing.Point(281, 233);
            this.lblsubsimbolo.Name = "lblsubsimbolo";
            this.lblsubsimbolo.Size = new System.Drawing.Size(16, 21);
            this.lblsubsimbolo.TabIndex = 17;
            this.lblsubsimbolo.Text = "-";
            // 
            // lblmultsimbolo
            // 
            this.lblmultsimbolo.AutoSize = true;
            this.lblmultsimbolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblmultsimbolo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultsimbolo.Location = new System.Drawing.Point(303, 301);
            this.lblmultsimbolo.Name = "lblmultsimbolo";
            this.lblmultsimbolo.Size = new System.Drawing.Size(17, 21);
            this.lblmultsimbolo.TabIndex = 18;
            this.lblmultsimbolo.Text = "*";
            // 
            // lbldivsimbolo
            // 
            this.lbldivsimbolo.AutoSize = true;
            this.lbldivsimbolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbldivsimbolo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldivsimbolo.ForeColor = System.Drawing.Color.Lime;
            this.lbldivsimbolo.Location = new System.Drawing.Point(269, 374);
            this.lbldivsimbolo.Name = "lbldivsimbolo";
            this.lbldivsimbolo.Size = new System.Drawing.Size(17, 21);
            this.lbldivsimbolo.TabIndex = 19;
            this.lbldivsimbolo.Text = "/";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSair.Location = new System.Drawing.Point(288, 488);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 37);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(37, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "developed by Edu";
            // 
            // frmMenu
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(396, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbldivsimbolo);
            this.Controls.Add(this.lblmultsimbolo);
            this.Controls.Add(this.lblsubsimbolo);
            this.Controls.Add(this.lblsomasimbolo);
            this.Controls.Add(this.lblhappyface);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Calculadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsubtracao;
        private System.Windows.Forms.Button btnmultiplicacao;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Label lblhappyface;
        private System.Windows.Forms.Label lblsomasimbolo;
        private System.Windows.Forms.Label lblsubsimbolo;
        private System.Windows.Forms.Label lblmultsimbolo;
        private System.Windows.Forms.Label lbldivsimbolo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
    }
}

