namespace PraktikumADO
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNambahData = new System.Windows.Forms.Button();
            this.btnSKS = new System.Windows.Forms.Button();
            this.btnKodeMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(512, 421);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 52);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(662, 421);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(135, 52);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs ";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(860, 421);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(118, 52);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1066, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(593, 226);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(398, 22);
            this.txtHasil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasil ";
            // 
            // btnNambahData
            // 
            this.btnNambahData.Location = new System.Drawing.Point(512, 535);
            this.btnNambahData.Name = "btnNambahData";
            this.btnNambahData.Size = new System.Drawing.Size(113, 23);
            this.btnNambahData.TabIndex = 6;
            this.btnNambahData.Text = "Tambah data";
            this.btnNambahData.UseVisualStyleBackColor = true;
            this.btnNambahData.Click += new System.EventHandler(this.btnNambahData_Click);
            // 
            // btnSKS
            // 
            this.btnSKS.Location = new System.Drawing.Point(781, 535);
            this.btnSKS.Name = "btnSKS";
            this.btnSKS.Size = new System.Drawing.Size(75, 23);
            this.btnSKS.TabIndex = 7;
            this.btnSKS.Text = " SKS";
            this.btnSKS.UseVisualStyleBackColor = true;
            this.btnSKS.Click += new System.EventHandler(this.btnSKS_Click);
            // 
            // btnKodeMK
            // 
            this.btnKodeMK.Location = new System.Drawing.Point(1000, 535);
            this.btnKodeMK.Name = "btnKodeMK";
            this.btnKodeMK.Size = new System.Drawing.Size(75, 23);
            this.btnKodeMK.TabIndex = 8;
            this.btnKodeMK.Text = "KodeMK";
            this.btnKodeMK.UseVisualStyleBackColor = true;
            this.btnKodeMK.Click += new System.EventHandler(this.btnKodeMK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 680);
            this.Controls.Add(this.btnKodeMK);
            this.Controls.Add(this.btnSKS);
            this.Controls.Add(this.btnNambahData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNambahData;
        private System.Windows.Forms.Button btnSKS;
        private System.Windows.Forms.Button btnKodeMK;
    }
}

