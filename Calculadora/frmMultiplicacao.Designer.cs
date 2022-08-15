
namespace Calculadora
{
    partial class frmMultiplicacao
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
            this.btnlimparmult = new System.Windows.Forms.Button();
            this.lblresultmult = new System.Windows.Forms.Label();
            this.btnvoltarmult = new System.Windows.Forms.Button();
            this.lblmultigual = new System.Windows.Forms.Label();
            this.btnefemult = new System.Windows.Forms.Button();
            this.txtnum2mult = new System.Windows.Forms.TextBox();
            this.lblmultiplicacao = new System.Windows.Forms.Label();
            this.txtnum1mult = new System.Windows.Forms.TextBox();
            this.lbllinhamult1 = new System.Windows.Forms.Label();
            this.lbltitulomult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimparmult
            // 
            this.btnlimparmult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlimparmult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimparmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimparmult.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimparmult.ForeColor = System.Drawing.Color.White;
            this.btnlimparmult.Location = new System.Drawing.Point(339, 369);
            this.btnlimparmult.Name = "btnlimparmult";
            this.btnlimparmult.Size = new System.Drawing.Size(123, 50);
            this.btnlimparmult.TabIndex = 34;
            this.btnlimparmult.Text = "Limpar";
            this.btnlimparmult.UseVisualStyleBackColor = false;
            this.btnlimparmult.Click += new System.EventHandler(this.btnlimparmult_Click);
            // 
            // lblresultmult
            // 
            this.lblresultmult.AutoSize = true;
            this.lblresultmult.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblresultmult.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultmult.ForeColor = System.Drawing.Color.Black;
            this.lblresultmult.Location = new System.Drawing.Point(385, 275);
            this.lblresultmult.Name = "lblresultmult";
            this.lblresultmult.Size = new System.Drawing.Size(34, 37);
            this.lblresultmult.TabIndex = 33;
            this.lblresultmult.Text = "0";
            // 
            // btnvoltarmult
            // 
            this.btnvoltarmult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnvoltarmult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltarmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltarmult.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltarmult.ForeColor = System.Drawing.Color.Navy;
            this.btnvoltarmult.Location = new System.Drawing.Point(26, 379);
            this.btnvoltarmult.Name = "btnvoltarmult";
            this.btnvoltarmult.Size = new System.Drawing.Size(180, 35);
            this.btnvoltarmult.TabIndex = 32;
            this.btnvoltarmult.Text = "Outras Operações";
            this.btnvoltarmult.UseVisualStyleBackColor = false;
            this.btnvoltarmult.Click += new System.EventHandler(this.btnvoltarmult_Click);
            // 
            // lblmultigual
            // 
            this.lblmultigual.AutoSize = true;
            this.lblmultigual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblmultigual.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultigual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblmultigual.Location = new System.Drawing.Point(218, 280);
            this.lblmultigual.Name = "lblmultigual";
            this.lblmultigual.Size = new System.Drawing.Size(149, 31);
            this.lblmultigual.TabIndex = 31;
            this.lblmultigual.Text = "Resultado : ";
            // 
            // btnefemult
            // 
            this.btnefemult.AutoSize = true;
            this.btnefemult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnefemult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnefemult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnefemult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnefemult.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnefemult.ForeColor = System.Drawing.Color.Blue;
            this.btnefemult.Location = new System.Drawing.Point(310, 194);
            this.btnefemult.Name = "btnefemult";
            this.btnefemult.Size = new System.Drawing.Size(178, 49);
            this.btnefemult.TabIndex = 30;
            this.btnefemult.Text = "Multiplicar";
            this.btnefemult.UseVisualStyleBackColor = false;
            this.btnefemult.Click += new System.EventHandler(this.btnefemult_Click);
            // 
            // txtnum2mult
            // 
            this.txtnum2mult.BackColor = System.Drawing.Color.White;
            this.txtnum2mult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum2mult.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2mult.ForeColor = System.Drawing.Color.Black;
            this.txtnum2mult.Location = new System.Drawing.Point(445, 146);
            this.txtnum2mult.Name = "txtnum2mult";
            this.txtnum2mult.Size = new System.Drawing.Size(132, 28);
            this.txtnum2mult.TabIndex = 29;
            // 
            // lblmultiplicacao
            // 
            this.lblmultiplicacao.AutoSize = true;
            this.lblmultiplicacao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblmultiplicacao.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultiplicacao.ForeColor = System.Drawing.Color.Blue;
            this.lblmultiplicacao.Location = new System.Drawing.Point(386, 146);
            this.lblmultiplicacao.Name = "lblmultiplicacao";
            this.lblmultiplicacao.Size = new System.Drawing.Size(25, 31);
            this.lblmultiplicacao.TabIndex = 28;
            this.lblmultiplicacao.Text = "*";
            // 
            // txtnum1mult
            // 
            this.txtnum1mult.BackColor = System.Drawing.Color.White;
            this.txtnum1mult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum1mult.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1mult.ForeColor = System.Drawing.Color.Black;
            this.txtnum1mult.Location = new System.Drawing.Point(215, 146);
            this.txtnum1mult.Name = "txtnum1mult";
            this.txtnum1mult.Size = new System.Drawing.Size(132, 28);
            this.txtnum1mult.TabIndex = 27;
            // 
            // lbllinhamult1
            // 
            this.lbllinhamult1.AutoSize = true;
            this.lbllinhamult1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbllinhamult1.Location = new System.Drawing.Point(4, 83);
            this.lbllinhamult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinhamult1.Name = "lbllinhamult1";
            this.lbllinhamult1.Size = new System.Drawing.Size(765, 19);
            this.lbllinhamult1.TabIndex = 26;
            this.lbllinhamult1.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------";
            this.lbllinhamult1.Click += new System.EventHandler(this.lbllinhasub1_Click);
            // 
            // lbltitulomult
            // 
            this.lbltitulomult.AutoSize = true;
            this.lbltitulomult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltitulomult.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulomult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltitulomult.Location = new System.Drawing.Point(207, 23);
            this.lbltitulomult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulomult.Name = "lbltitulomult";
            this.lbltitulomult.Size = new System.Drawing.Size(423, 45);
            this.lbltitulomult.TabIndex = 25;
            this.lbltitulomult.Text = "Efetuando Multiplicação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------";
            // 
            // frmMultiplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(772, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimparmult);
            this.Controls.Add(this.lblresultmult);
            this.Controls.Add(this.btnvoltarmult);
            this.Controls.Add(this.lblmultigual);
            this.Controls.Add(this.btnefemult);
            this.Controls.Add(this.txtnum2mult);
            this.Controls.Add(this.lblmultiplicacao);
            this.Controls.Add(this.txtnum1mult);
            this.Controls.Add(this.lbllinhamult1);
            this.Controls.Add(this.lbltitulomult);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMultiplicacao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Multiplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlimparmult;
        private System.Windows.Forms.Label lblresultmult;
        private System.Windows.Forms.Button btnvoltarmult;
        private System.Windows.Forms.Label lblmultigual;
        private System.Windows.Forms.Button btnefemult;
        private System.Windows.Forms.TextBox txtnum2mult;
        private System.Windows.Forms.Label lblmultiplicacao;
        private System.Windows.Forms.TextBox txtnum1mult;
        private System.Windows.Forms.Label lbllinhamult1;
        private System.Windows.Forms.Label lbltitulomult;
        private System.Windows.Forms.Label label1;
    }
}