namespace SkiResortTrack
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMapFile = new System.Windows.Forms.Label();
            this.btnMapFileSelector = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMapFile
            // 
            this.lblMapFile.AutoSize = true;
            this.lblMapFile.Location = new System.Drawing.Point(13, 13);
            this.lblMapFile.Name = "lblMapFile";
            this.lblMapFile.Size = new System.Drawing.Size(97, 13);
            this.lblMapFile.TabIndex = 0;
            this.lblMapFile.Text = " Select a map file...";
            // 
            // btnMapFileSelector
            // 
            this.btnMapFileSelector.Location = new System.Drawing.Point(270, 8);
            this.btnMapFileSelector.Name = "btnMapFileSelector";
            this.btnMapFileSelector.Size = new System.Drawing.Size(28, 23);
            this.btnMapFileSelector.TabIndex = 1;
            this.btnMapFileSelector.Text = "...";
            this.btnMapFileSelector.UseVisualStyleBackColor = true;
            this.btnMapFileSelector.Click += new System.EventHandler(this.btnMapFileSelector_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 65);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(282, 90);
            this.txtResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(223, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Get track";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(16, 176);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 13);
            this.lblLog.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 208);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnMapFileSelector);
            this.Controls.Add(this.lblMapFile);
            this.Name = "Form1";
            this.Text = "Kitzbühel ski resort track seeker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMapFile;
        private System.Windows.Forms.Button btnMapFileSelector;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLog;
    }
}

