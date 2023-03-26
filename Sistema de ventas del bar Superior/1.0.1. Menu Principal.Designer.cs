namespace Sistema_de_ventas_del_bar_Superior
{
    partial class Menu_Principal
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnPDV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.Blue;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategoria.Location = new System.Drawing.Point(90, 207);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(124, 42);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Sección de productos";
            this.btnCategoria.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Blue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInventario.Location = new System.Drawing.Point(484, 207);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(124, 42);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnPDV
            // 
            this.btnPDV.BackColor = System.Drawing.Color.Blue;
            this.btnPDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDV.Location = new System.Drawing.Point(284, 207);
            this.btnPDV.Name = "btnPDV";
            this.btnPDV.Size = new System.Drawing.Size(124, 42);
            this.btnPDV.TabIndex = 0;
            this.btnPDV.Text = "Punto de venta";
            this.btnPDV.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(743, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPDV);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnPDV;
        private System.Windows.Forms.Label label1;
    }
}