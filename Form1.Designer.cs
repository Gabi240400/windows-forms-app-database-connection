
namespace Lab2
{
    partial class Form_Cartis
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
            this.dataGridViewParinte = new System.Windows.Forms.DataGridView();
            this.dataGridViewCopil = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butonAdauga = new System.Windows.Forms.Button();
            this.butonUpdate = new System.Windows.Forms.Button();
            this.butonSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopil)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParinte
            // 
            this.dataGridViewParinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParinte.Location = new System.Drawing.Point(95, 12);
            this.dataGridViewParinte.Name = "dataGridViewParinte";
            this.dataGridViewParinte.RowHeadersWidth = 51;
            this.dataGridViewParinte.RowTemplate.Height = 24;
            this.dataGridViewParinte.Size = new System.Drawing.Size(590, 268);
            this.dataGridViewParinte.TabIndex = 0;
            // 
            // dataGridViewCopil
            // 
            this.dataGridViewCopil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCopil.Location = new System.Drawing.Point(95, 306);
            this.dataGridViewCopil.Name = "dataGridViewCopil";
            this.dataGridViewCopil.RowHeadersWidth = 51;
            this.dataGridViewCopil.RowTemplate.Height = 24;
            this.dataGridViewCopil.Size = new System.Drawing.Size(590, 268);
            this.dataGridViewCopil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 224);
            this.label1.TabIndex = 2;
            this.label1.Text = "P\r\na\r\nr\r\ni\r\nn\r\nt\r\ne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 160);
            this.label2.TabIndex = 3;
            this.label2.Text = "C\r\no\r\np\r\ni\r\nl";
            // 
            // butonAdauga
            // 
            this.butonAdauga.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAdauga.Location = new System.Drawing.Point(713, 506);
            this.butonAdauga.Name = "butonAdauga";
            this.butonAdauga.Size = new System.Drawing.Size(146, 68);
            this.butonAdauga.TabIndex = 5;
            this.butonAdauga.Text = "Adauga";
            this.butonAdauga.UseVisualStyleBackColor = true;
            this.butonAdauga.Click += new System.EventHandler(this.butonAdauga_Click);
            // 
            // butonUpdate
            // 
            this.butonUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.butonUpdate.Location = new System.Drawing.Point(929, 506);
            this.butonUpdate.Name = "butonUpdate";
            this.butonUpdate.Size = new System.Drawing.Size(146, 68);
            this.butonUpdate.TabIndex = 6;
            this.butonUpdate.Text = "Update";
            this.butonUpdate.UseVisualStyleBackColor = true;
            this.butonUpdate.Click += new System.EventHandler(this.butonUpdate_Click);
            // 
            // butonSterge
            // 
            this.butonSterge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.butonSterge.Location = new System.Drawing.Point(1144, 506);
            this.butonSterge.Name = "butonSterge";
            this.butonSterge.Size = new System.Drawing.Size(146, 68);
            this.butonSterge.TabIndex = 7;
            this.butonSterge.Text = "Sterge";
            this.butonSterge.UseVisualStyleBackColor = true;
            this.butonSterge.Click += new System.EventHandler(this.butonSterge_Click);
            // 
            // Form_Cartis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 586);
            this.Controls.Add(this.butonSterge);
            this.Controls.Add(this.butonUpdate);
            this.Controls.Add(this.butonAdauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCopil);
            this.Controls.Add(this.dataGridViewParinte);
            this.Name = "Form_Cartis";
            this.Text = "Cartis";
            this.Load += new System.EventHandler(this.Form_Cartis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParinte;
        private System.Windows.Forms.DataGridView dataGridViewCopil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonAdauga;
        private System.Windows.Forms.Button butonUpdate;
        private System.Windows.Forms.Button butonSterge;
    }
}

