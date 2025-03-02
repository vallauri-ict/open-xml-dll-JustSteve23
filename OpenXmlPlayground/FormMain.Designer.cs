﻿namespace OpenXmlPlayground
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpleWordTest = new System.Windows.Forms.Button();
            this.btnSimpleExcelTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleWordTest
            // 
            this.btnSimpleWordTest.Location = new System.Drawing.Point(24, 23);
            this.btnSimpleWordTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSimpleWordTest.Name = "btnSimpleWordTest";
            this.btnSimpleWordTest.Size = new System.Drawing.Size(920, 44);
            this.btnSimpleWordTest.TabIndex = 0;
            this.btnSimpleWordTest.Text = "SIMPLE WORD DOCUMENT TEST";
            this.btnSimpleWordTest.UseVisualStyleBackColor = true;
            this.btnSimpleWordTest.Click += new System.EventHandler(this.btnSimpleWordTest_Click);
            // 
            // btnSimpleExcelTest
            // 
            this.btnSimpleExcelTest.Location = new System.Drawing.Point(24, 79);
            this.btnSimpleExcelTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnSimpleExcelTest.Name = "btnSimpleExcelTest";
            this.btnSimpleExcelTest.Size = new System.Drawing.Size(920, 44);
            this.btnSimpleExcelTest.TabIndex = 1;
            this.btnSimpleExcelTest.Text = "SIMPLE EXCEL DOCUMENT TEST";
            this.btnSimpleExcelTest.UseVisualStyleBackColor = true;
            this.btnSimpleExcelTest.Click += new System.EventHandler(this.btnSimpleExcelTest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 694);
            this.Controls.Add(this.btnSimpleExcelTest);
            this.Controls.Add(this.btnSimpleWordTest);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.Text = "OpenXML Playground";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleWordTest;
        private System.Windows.Forms.Button btnSimpleExcelTest;
    }
}

