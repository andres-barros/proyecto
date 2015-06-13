namespace country_club
{
    partial class foto
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
            this.btnfoto = new System.Windows.Forms.Button();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.cboDispositivos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbfotog = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfoto
            // 
            this.btnfoto.BackColor = System.Drawing.Color.White;
            this.btnfoto.Location = new System.Drawing.Point(397, 230);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(67, 33);
            this.btnfoto.TabIndex = 0;
            this.btnfoto.Text = "iniciar";
            this.btnfoto.UseVisualStyleBackColor = false;
            this.btnfoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbfoto
            // 
            this.pbfoto.Location = new System.Drawing.Point(-1, 1);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(285, 207);
            this.pbfoto.TabIndex = 1;
            this.pbfoto.TabStop = false;
            // 
            // cboDispositivos
            // 
            this.cboDispositivos.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDispositivos.ForeColor = System.Drawing.Color.Blue;
            this.cboDispositivos.FormattingEnabled = true;
            this.cboDispositivos.Location = new System.Drawing.Point(-1, 230);
            this.cboDispositivos.Name = "cboDispositivos";
            this.cboDispositivos.Size = new System.Drawing.Size(183, 33);
            this.cboDispositivos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(300, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "tomar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbfotog
            // 
            this.pbfotog.Location = new System.Drawing.Point(281, 1);
            this.pbfotog.Name = "pbfotog";
            this.pbfotog.Size = new System.Drawing.Size(285, 207);
            this.pbfotog.TabIndex = 4;
            this.pbfotog.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(480, 230);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 33);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 263);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.pbfotog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDispositivos);
            this.Controls.Add(this.pbfoto);
            this.Controls.Add(this.btnfoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "foto";
            this.Text = "foto";
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.ComboBox cboDispositivos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbfotog;
        private System.Windows.Forms.Button btnguardar;
    }
}