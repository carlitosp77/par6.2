
namespace par6._2.FORMULARIO
{
    partial class FRMOD4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMOD4));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinvertir = new System.Windows.Forms.Label();
            this.btninvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVERTIR PALABRAS";
            // 
            // txtpalabra
            // 
            this.txtpalabra.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabra.Location = new System.Drawing.Point(89, 118);
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(629, 41);
            this.txtpalabra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "PALABRA INVERTIDA";
            // 
            // lblinvertir
            // 
            this.lblinvertir.AutoSize = true;
            this.lblinvertir.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvertir.Location = new System.Drawing.Point(545, 276);
            this.lblinvertir.Name = "lblinvertir";
            this.lblinvertir.Size = new System.Drawing.Size(140, 34);
            this.lblinvertir.TabIndex = 3;
            this.lblinvertir.Text = "PALABRA";
            // 
            // btninvertir
            // 
            this.btninvertir.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvertir.Location = new System.Drawing.Point(296, 187);
            this.btninvertir.Name = "btninvertir";
            this.btninvertir.Size = new System.Drawing.Size(195, 42);
            this.btninvertir.TabIndex = 4;
            this.btninvertir.Text = "INVERTIR";
            this.btninvertir.UseVisualStyleBackColor = true;
            this.btninvertir.Click += new System.EventHandler(this.btninvertir_Click);
            // 
            // FRMOD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninvertir);
            this.Controls.Add(this.lblinvertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpalabra);
            this.Controls.Add(this.label1);
            this.Name = "FRMOD4";
            this.Text = "FRMOD4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblinvertir;
        private System.Windows.Forms.Button btninvertir;
    }
}