
namespace Vocales_Uppercaps
{
    partial class FRMVocalesUpperCaps
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
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.LBLInstruccion = new System.Windows.Forms.Label();
            this.LBLCantidad_Vocales = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.LBLDivisor = new System.Windows.Forms.Label();
            this.LBLInformacion = new System.Windows.Forms.Label();
            this.RTXParrafo_Out = new System.Windows.Forms.RichTextBox();
            this.LBLTamanioCaracteres = new System.Windows.Forms.Label();
            this.RTXParrafo_In = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LBLTitulo.Location = new System.Drawing.Point(45, 16);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(273, 32);
            this.LBLTitulo.TabIndex = 0;
            this.LBLTitulo.Text = "Vocales Uppercaps";
            // 
            // LBLInstruccion
            // 
            this.LBLInstruccion.AutoSize = true;
            this.LBLInstruccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLInstruccion.Location = new System.Drawing.Point(10, 62);
            this.LBLInstruccion.Name = "LBLInstruccion";
            this.LBLInstruccion.Size = new System.Drawing.Size(132, 19);
            this.LBLInstruccion.TabIndex = 1;
            this.LBLInstruccion.Text = "Digitalice un párrafo";
            // 
            // LBLCantidad_Vocales
            // 
            this.LBLCantidad_Vocales.AutoSize = true;
            this.LBLCantidad_Vocales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLCantidad_Vocales.Location = new System.Drawing.Point(18, 244);
            this.LBLCantidad_Vocales.Name = "LBLCantidad_Vocales";
            this.LBLCantidad_Vocales.Size = new System.Drawing.Size(179, 15);
            this.LBLCantidad_Vocales.TabIndex = 3;
            this.LBLCantidad_Vocales.Text = "Cantidad de vocales del párrafo: ";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(13, 429);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(329, 23);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Cerrar";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // LBLDivisor
            // 
            this.LBLDivisor.AutoSize = true;
            this.LBLDivisor.Location = new System.Drawing.Point(10, 224);
            this.LBLDivisor.Name = "LBLDivisor";
            this.LBLDivisor.Size = new System.Drawing.Size(337, 15);
            this.LBLDivisor.TabIndex = 7;
            this.LBLDivisor.Text = "───────────────────────────────────────────────────────";
            // 
            // LBLInformacion
            // 
            this.LBLInformacion.AutoSize = true;
            this.LBLInformacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLInformacion.Location = new System.Drawing.Point(12, 212);
            this.LBLInformacion.Name = "LBLInformacion";
            this.LBLInformacion.Size = new System.Drawing.Size(82, 19);
            this.LBLInformacion.TabIndex = 8;
            this.LBLInformacion.Text = "Información";
            // 
            // RTXParrafo_Out
            // 
            this.RTXParrafo_Out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTXParrafo_Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTXParrafo_Out.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTXParrafo_Out.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTXParrafo_Out.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RTXParrafo_Out.Location = new System.Drawing.Point(13, 265);
            this.RTXParrafo_Out.Margin = new System.Windows.Forms.Padding(4);
            this.RTXParrafo_Out.Name = "RTXParrafo_Out";
            this.RTXParrafo_Out.ReadOnly = true;
            this.RTXParrafo_Out.Size = new System.Drawing.Size(329, 146);
            this.RTXParrafo_Out.TabIndex = 1;
            this.RTXParrafo_Out.TabStop = false;
            this.RTXParrafo_Out.Text = "\n\n\n\n                  Aquí aparecerá el párrafo introducido con\n                 " +
    "            las vocales en mayúscula...";
            // 
            // LBLTamanioCaracteres
            // 
            this.LBLTamanioCaracteres.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLTamanioCaracteres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLTamanioCaracteres.Location = new System.Drawing.Point(179, 62);
            this.LBLTamanioCaracteres.Name = "LBLTamanioCaracteres";
            this.LBLTamanioCaracteres.Size = new System.Drawing.Size(167, 19);
            this.LBLTamanioCaracteres.TabIndex = 11;
            this.LBLTamanioCaracteres.Text = " ";
            this.LBLTamanioCaracteres.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // RTXParrafo_In
            // 
            this.RTXParrafo_In.AcceptsTab = true;
            this.RTXParrafo_In.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTXParrafo_In.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTXParrafo_In.Location = new System.Drawing.Point(13, 84);
            this.RTXParrafo_In.Margin = new System.Windows.Forms.Padding(4);
            this.RTXParrafo_In.Name = "RTXParrafo_In";
            this.RTXParrafo_In.Size = new System.Drawing.Size(329, 115);
            this.RTXParrafo_In.TabIndex = 0;
            this.RTXParrafo_In.Text = "";
            this.RTXParrafo_In.TextChanged += new System.EventHandler(this.RTXParrafo_In_TextChanged);
            // 
            // FRMVocalesUpperCaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 460);
            this.Controls.Add(this.RTXParrafo_In);
            this.Controls.Add(this.LBLTamanioCaracteres);
            this.Controls.Add(this.RTXParrafo_Out);
            this.Controls.Add(this.LBLInformacion);
            this.Controls.Add(this.LBLDivisor);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.LBLCantidad_Vocales);
            this.Controls.Add(this.LBLInstruccion);
            this.Controls.Add(this.LBLTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMVocalesUpperCaps";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocales Uppercaps";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.Label LBLInstruccion;
        private System.Windows.Forms.Label LBLCantidad_Vocales;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Label LBLDivisor;
        private System.Windows.Forms.Label LBLInformacion;
        private System.Windows.Forms.RichTextBox RTXParrafo_Out;
        private System.Windows.Forms.Label LBLTamanioCaracteres;
        private System.Windows.Forms.RichTextBox RTXParrafo_In;
    }
}

