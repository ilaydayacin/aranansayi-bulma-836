namespace Sayının_var_olup_olmadıgına_bakan_uygulama_836
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.btnVarMi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(8, 305);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Aradığın sayı";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(131, 310);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(172, 20);
            this.txtAra.TabIndex = 1;
            // 
            // lbSayi
            // 
            this.lbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.ItemHeight = 24;
            this.lbSayi.Location = new System.Drawing.Point(12, 12);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(160, 244);
            this.lbSayi.TabIndex = 2;
            // 
            // btnVarMi
            // 
            this.btnVarMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVarMi.Location = new System.Drawing.Point(227, 96);
            this.btnVarMi.Name = "btnVarMi";
            this.btnVarMi.Size = new System.Drawing.Size(161, 110);
            this.btnVarMi.TabIndex = 3;
            this.btnVarMi.Text = "Sayıyı ara ";
            this.btnVarMi.UseVisualStyleBackColor = true;
            this.btnVarMi.Click += new System.EventHandler(this.btnVarMi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.btnVarMi);
            this.Controls.Add(this.lbSayi);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.Button btnVarMi;
    }
}

