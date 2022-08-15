
namespace Calculadora
{
    partial class frmDivisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisao));
            this.btnlimpardiv = new System.Windows.Forms.Button();
            this.lblresultdiv = new System.Windows.Forms.Label();
            this.btnvoltardiv = new System.Windows.Forms.Button();
            this.lbldivigual = new System.Windows.Forms.Label();
            this.btnefedivisao = new System.Windows.Forms.Button();
            this.txtnum2div = new System.Windows.Forms.TextBox();
            this.lbldivisao = new System.Windows.Forms.Label();
            this.txtnum1div = new System.Windows.Forms.TextBox();
            this.lbllinhadiv1 = new System.Windows.Forms.Label();
            this.lbltitulodiv = new System.Windows.Forms.Label();
            this.lbllinhadiv2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpardiv
            // 
            this.btnlimpardiv.BackColor = System.Drawing.Color.DarkGreen;
            this.btnlimpardiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpardiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpardiv.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpardiv.ForeColor = System.Drawing.Color.White;
            this.btnlimpardiv.Location = new System.Drawing.Point(365, 363);
            this.btnlimpardiv.Name = "btnlimpardiv";
            this.btnlimpardiv.Size = new System.Drawing.Size(128, 47);
            this.btnlimpardiv.TabIndex = 34;
            this.btnlimpardiv.Text = "Limpar";
            this.btnlimpardiv.UseVisualStyleBackColor = false;
            this.btnlimpardiv.Click += new System.EventHandler(this.btnlimpardiv_Click);
            // 
            // lblresultdiv
            // 
            this.lblresultdiv.AutoSize = true;
            this.lblresultdiv.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblresultdiv.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultdiv.ForeColor = System.Drawing.Color.Black;
            this.lblresultdiv.Location = new System.Drawing.Point(411, 252);
            this.lblresultdiv.Name = "lblresultdiv";
            this.lblresultdiv.Size = new System.Drawing.Size(34, 37);
            this.lblresultdiv.TabIndex = 33;
            this.lblresultdiv.Text = "0";
            // 
            // btnvoltardiv
            // 
            this.btnvoltardiv.BackColor = System.Drawing.Color.DarkGreen;
            this.btnvoltardiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltardiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltardiv.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltardiv.ForeColor = System.Drawing.Color.White;
            this.btnvoltardiv.Location = new System.Drawing.Point(16, 371);
            this.btnvoltardiv.Name = "btnvoltardiv";
            this.btnvoltardiv.Size = new System.Drawing.Size(180, 35);
            this.btnvoltardiv.TabIndex = 32;
            this.btnvoltardiv.Text = "Outras Operações";
            this.btnvoltardiv.UseVisualStyleBackColor = false;
            this.btnvoltardiv.Click += new System.EventHandler(this.btnvoltardiv_Click);
            // 
            // lbldivigual
            // 
            this.lbldivigual.AutoSize = true;
            this.lbldivigual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbldivigual.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldivigual.ForeColor = System.Drawing.Color.Black;
            this.lbldivigual.Location = new System.Drawing.Point(252, 257);
            this.lbldivigual.Name = "lbldivigual";
            this.lbldivigual.Size = new System.Drawing.Size(149, 31);
            this.lbldivigual.TabIndex = 31;
            this.lbldivigual.Text = "Resultado : ";
            // 
            // btnefedivisao
            // 
            this.btnefedivisao.AutoSize = true;
            this.btnefedivisao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnefedivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnefedivisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnefedivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnefedivisao.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnefedivisao.ForeColor = System.Drawing.Color.White;
            this.btnefedivisao.Location = new System.Drawing.Point(373, 167);
            this.btnefedivisao.Name = "btnefedivisao";
            this.btnefedivisao.Size = new System.Drawing.Size(120, 49);
            this.btnefedivisao.TabIndex = 30;
            this.btnefedivisao.Text = "Dividir";
            this.btnefedivisao.UseVisualStyleBackColor = false;
            this.btnefedivisao.Click += new System.EventHandler(this.btnefedivisao_Click);
            // 
            // txtnum2div
            // 
            this.txtnum2div.BackColor = System.Drawing.Color.White;
            this.txtnum2div.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum2div.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2div.ForeColor = System.Drawing.Color.Black;
            this.txtnum2div.Location = new System.Drawing.Point(487, 117);
            this.txtnum2div.Name = "txtnum2div";
            this.txtnum2div.Size = new System.Drawing.Size(128, 28);
            this.txtnum2div.TabIndex = 29;
            // 
            // lbldivisao
            // 
            this.lbldivisao.AutoSize = true;
            this.lbldivisao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lbldivisao.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldivisao.ForeColor = System.Drawing.Color.Black;
            this.lbldivisao.Location = new System.Drawing.Point(420, 113);
            this.lbldivisao.Name = "lbldivisao";
            this.lbldivisao.Size = new System.Drawing.Size(25, 31);
            this.lbldivisao.TabIndex = 28;
            this.lbldivisao.Text = "/";
            // 
            // txtnum1div
            // 
            this.txtnum1div.BackColor = System.Drawing.Color.White;
            this.txtnum1div.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum1div.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1div.ForeColor = System.Drawing.Color.Black;
            this.txtnum1div.Location = new System.Drawing.Point(247, 117);
            this.txtnum1div.Name = "txtnum1div";
            this.txtnum1div.Size = new System.Drawing.Size(134, 28);
            this.txtnum1div.TabIndex = 27;
            // 
            // lbllinhadiv1
            // 
            this.lbllinhadiv1.AutoSize = true;
            this.lbllinhadiv1.ForeColor = System.Drawing.Color.Black;
            this.lbllinhadiv1.Location = new System.Drawing.Point(13, 73);
            this.lbllinhadiv1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinhadiv1.Name = "lbllinhadiv1";
            this.lbllinhadiv1.Size = new System.Drawing.Size(757, 13);
            this.lbllinhadiv1.TabIndex = 26;
            this.lbllinhadiv1.Text = resources.GetString("lbllinhadiv1.Text");
            // 
            // lbltitulodiv
            // 
            this.lbltitulodiv.AutoSize = true;
            this.lbltitulodiv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltitulodiv.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulodiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltitulodiv.Location = new System.Drawing.Point(268, 18);
            this.lbltitulodiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulodiv.Name = "lbltitulodiv";
            this.lbltitulodiv.Size = new System.Drawing.Size(319, 45);
            this.lbltitulodiv.TabIndex = 25;
            this.lbltitulodiv.Text = "Efetuando Divisão\r\n";
            // 
            // lbllinhadiv2
            // 
            this.lbllinhadiv2.AutoSize = true;
            this.lbllinhadiv2.ForeColor = System.Drawing.Color.Black;
            this.lbllinhadiv2.Location = new System.Drawing.Point(13, 319);
            this.lbllinhadiv2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinhadiv2.Name = "lbllinhadiv2";
            this.lbllinhadiv2.Size = new System.Drawing.Size(757, 13);
            this.lbllinhadiv2.TabIndex = 35;
            this.lbllinhadiv2.Text = resources.GetString("lbllinhadiv2.Text");
            // 
            // frmDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(769, 458);
            this.Controls.Add(this.lbllinhadiv2);
            this.Controls.Add(this.btnlimpardiv);
            this.Controls.Add(this.lblresultdiv);
            this.Controls.Add(this.btnvoltardiv);
            this.Controls.Add(this.lbldivigual);
            this.Controls.Add(this.btnefedivisao);
            this.Controls.Add(this.txtnum2div);
            this.Controls.Add(this.lbldivisao);
            this.Controls.Add(this.txtnum1div);
            this.Controls.Add(this.lbllinhadiv1);
            this.Controls.Add(this.lbltitulodiv);
            this.Name = "frmDivisao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlimpardiv;
        private System.Windows.Forms.Label lblresultdiv;
        private System.Windows.Forms.Button btnvoltardiv;
        private System.Windows.Forms.Label lbldivigual;
        private System.Windows.Forms.Button btnefedivisao;
        private System.Windows.Forms.TextBox txtnum2div;
        private System.Windows.Forms.Label lbldivisao;
        private System.Windows.Forms.TextBox txtnum1div;
        private System.Windows.Forms.Label lbllinhadiv1;
        private System.Windows.Forms.Label lbltitulodiv;
        private System.Windows.Forms.Label lbllinhadiv2;
    }
}