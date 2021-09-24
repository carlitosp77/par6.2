
namespace par6._2.FORMULARIO
{
    partial class FRMOD5
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
            this.txtpangra = new System.Windows.Forms.TextBox();
            this.lblresultadop = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANGRAMAS";
            // 
            // txtpangra
            // 
            this.txtpangra.Location = new System.Drawing.Point(114, 130);
            this.txtpangra.Name = "txtpangra";
            this.txtpangra.Size = new System.Drawing.Size(558, 20);
            this.txtpangra.TabIndex = 1;
            // 
            // lblresultadop
            // 
            this.lblresultadop.AutoSize = true;
            this.lblresultadop.Location = new System.Drawing.Point(349, 307);
            this.lblresultadop.Name = "lblresultadop";
            this.lblresultadop.Size = new System.Drawing.Size(73, 13);
            this.lblresultadop.TabIndex = 2;
            this.lblresultadop.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMOD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresultadop);
            this.Controls.Add(this.txtpangra);
            this.Controls.Add(this.label1);
            this.Name = "FRMOD5";
            this.Text = "FRMOD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpangra;
        private System.Windows.Forms.Label lblresultadop;
        private System.Windows.Forms.Button button1;
    }
}