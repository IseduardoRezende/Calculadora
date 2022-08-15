
namespace Calculadora
{
    partial class frmSoma
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
            this.lbltitulosoma = new System.Windows.Forms.Label();
            this.txtnum1soma = new System.Windows.Forms.TextBox();
            this.lblsoma = new System.Windows.Forms.Label();
            this.btnefesoma = new System.Windows.Forms.Button();
            this.lblsomaigual = new System.Windows.Forms.Label();
            this.btnvoltarsoma = new System.Windows.Forms.Button();
            this.txtnum2soma = new System.Windows.Forms.TextBox();
            this.lblresultsoma = new System.Windows.Forms.Label();
            this.btnlimparsoma = new System.Windows.Forms.Button();
            this.lbllinhasoma1 = new System.Windows.Forms.Label();
            this.lbllinhasoma2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulosoma
            // 
            this.lbltitulosoma.AutoSize = true;
            this.lbltitulosoma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbltitulosoma.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulosoma.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbltitulosoma.Location = new System.Drawing.Point(272, 25);
            this.lbltitulosoma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulosoma.Name = "lbltitulosoma";
            this.lbltitulosoma.Size = new System.Drawing.Size(291, 45);
            this.lbltitulosoma.TabIndex = 2;
            this.lbltitulosoma.Text = "Efetuando Soma";
            this.lbltitulosoma.Click += new System.EventHandler(this.lbltitulosoma_Click);
            // 
            // txtnum1soma
            // 
            this.txtnum1soma.BackColor = System.Drawing.Color.White;
            this.txtnum1soma.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum1soma.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1soma.ForeColor = System.Drawing.Color.Black;
            this.txtnum1soma.Location = new System.Drawing.Point(216, 146);
            this.txtnum1soma.Name = "txtnum1soma";
            this.txtnum1soma.Size = new System.Drawing.Size(143, 28);
            this.txtnum1soma.TabIndex = 3;
            this.txtnum1soma.TextChanged += new System.EventHandler(this.txtnum1soma_TextChanged);
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblsoma.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsoma.Location = new System.Drawing.Point(386, 147);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(23, 23);
            this.lblsoma.TabIndex = 4;
            this.lblsoma.Text = "+";
            // 
            // btnefesoma
            // 
            this.btnefesoma.AutoSize = true;
            this.btnefesoma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnefesoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnefesoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnefesoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnefesoma.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnefesoma.ForeColor = System.Drawing.Color.White;
            this.btnefesoma.Location = new System.Drawing.Point(342, 195);
            this.btnefesoma.Name = "btnefesoma";
            this.btnefesoma.Size = new System.Drawing.Size(118, 49);
            this.btnefesoma.TabIndex = 8;
            this.btnefesoma.Text = "Somar";
            this.btnefesoma.UseVisualStyleBackColor = false;
            this.btnefesoma.Click += new System.EventHandler(this.btnefesoma_Click);
            // 
            // lblsomaigual
            // 
            this.lblsomaigual.AutoSize = true;
            this.lblsomaigual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblsomaigual.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsomaigual.ForeColor = System.Drawing.Color.Black;
            this.lblsomaigual.Location = new System.Drawing.Point(210, 274);
            this.lblsomaigual.Name = "lblsomaigual";
            this.lblsomaigual.Size = new System.Drawing.Size(149, 31);
            this.lblsomaigual.TabIndex = 9;
            this.lblsomaigual.Text = "Resultado : ";
            // 
            // btnvoltarsoma
            // 
            this.btnvoltarsoma.BackColor = System.Drawing.Color.Purple;
            this.btnvoltarsoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltarsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltarsoma.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltarsoma.ForeColor = System.Drawing.Color.White;
            this.btnvoltarsoma.Location = new System.Drawing.Point(17, 375);
            this.btnvoltarsoma.Name = "btnvoltarsoma";
            this.btnvoltarsoma.Size = new System.Drawing.Size(180, 35);
            this.btnvoltarsoma.TabIndex = 10;
            this.btnvoltarsoma.Text = "Outras Operações";
            this.btnvoltarsoma.UseVisualStyleBackColor = false;
            this.btnvoltarsoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnum2soma
            // 
            this.txtnum2soma.BackColor = System.Drawing.Color.White;
            this.txtnum2soma.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnum2soma.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2soma.ForeColor = System.Drawing.Color.Black;
            this.txtnum2soma.Location = new System.Drawing.Point(443, 146);
            this.txtnum2soma.Name = "txtnum2soma";
            this.txtnum2soma.Size = new System.Drawing.Size(142, 28);
            this.txtnum2soma.TabIndex = 11;
            // 
            // lblresultsoma
            // 
            this.lblresultsoma.AutoSize = true;
            this.lblresultsoma.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblresultsoma.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultsoma.ForeColor = System.Drawing.Color.Black;
            this.lblresultsoma.Location = new System.Drawing.Point(383, 268);
            this.lblresultsoma.Name = "lblresultsoma";
            this.lblresultsoma.Size = new System.Drawing.Size(34, 37);
            this.lblresultsoma.TabIndex = 12;
            this.lblresultsoma.Text = "0";
            // 
            // btnlimparsoma
            // 
            this.btnlimparsoma.BackColor = System.Drawing.Color.Purple;
            this.btnlimparsoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimparsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimparsoma.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimparsoma.ForeColor = System.Drawing.Color.White;
            this.btnlimparsoma.Location = new System.Drawing.Point(340, 364);
            this.btnlimparsoma.Name = "btnlimparsoma";
            this.btnlimparsoma.Size = new System.Drawing.Size(120, 52);
            this.btnlimparsoma.TabIndex = 13;
            this.btnlimparsoma.Text = "Limpar";
            this.btnlimparsoma.UseVisualStyleBackColor = false;
            this.btnlimparsoma.Click += new System.EventHandler(this.btnlimparsoma_Click);
            // 
            // lbllinhasoma1
            // 
            this.lbllinhasoma1.AutoSize = true;
            this.lbllinhasoma1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbllinhasoma1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbllinhasoma1.Location = new System.Drawing.Point(13, 91);
            this.lbllinhasoma1.Name = "lbllinhasoma1";
            this.lbllinhasoma1.Size = new System.Drawing.Size(741, 19);
            this.lbllinhasoma1.TabIndex = 14;
            this.lbllinhasoma1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            // 
            // lbllinhasoma2
            // 
            this.lbllinhasoma2.AutoSize = true;
            this.lbllinhasoma2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbllinhasoma2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbllinhasoma2.Location = new System.Drawing.Point(13, 336);
            this.lbllinhasoma2.Name = "lbllinhasoma2";
            this.lbllinhasoma2.Size = new System.Drawing.Size(741, 19);
            this.lbllinhasoma2.TabIndex = 16;
            this.lbllinhasoma2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(773, 460);
            this.Controls.Add(this.lbllinhasoma2);
            this.Controls.Add(this.lbllinhasoma1);
            this.Controls.Add(this.btnlimparsoma);
            this.Controls.Add(this.lblresultsoma);
            this.Controls.Add(this.txtnum2soma);
            this.Controls.Add(this.btnvoltarsoma);
            this.Controls.Add(this.lblsomaigual);
            this.Controls.Add(this.btnefesoma);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.txtnum1soma);
            this.Controls.Add(this.lbltitulosoma);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSoma";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Soma";
            this.Load += new System.EventHandler(this.frmSoma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnum1soma;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.Button btnefesoma;
        private System.Windows.Forms.Label lblsomaigual;
        private System.Windows.Forms.Button btnvoltarsoma;
        private System.Windows.Forms.TextBox txtnum2soma;
        private System.Windows.Forms.Label lblresultsoma;
        private System.Windows.Forms.Button btnlimparsoma;
        private System.Windows.Forms.Label lbltitulosoma;
        private System.Windows.Forms.Label lbllinhasoma1;
        private System.Windows.Forms.Label lbllinhasoma2;
    }
}