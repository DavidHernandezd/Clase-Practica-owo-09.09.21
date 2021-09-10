
namespace Practica_9_09
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
            this.btngetname = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.lstnames = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetname
            // 
            this.btngetname.Location = new System.Drawing.Point(12, 12);
            this.btngetname.Name = "btngetname";
            this.btngetname.Size = new System.Drawing.Size(93, 43);
            this.btngetname.TabIndex = 0;
            this.btngetname.Text = "getnames()";
            this.btngetname.UseVisualStyleBackColor = true;
            this.btngetname.Click += new System.EventHandler(this.btngetname_Click);
            // 
            // btngetdata
            // 
            this.btngetdata.Location = new System.Drawing.Point(12, 64);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(93, 44);
            this.btngetdata.TabIndex = 1;
            this.btngetdata.Text = "getdata()";
            this.btngetdata.UseVisualStyleBackColor = true;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // lstnames
            // 
            this.lstnames.FormattingEnabled = true;
            this.lstnames.ItemHeight = 16;
            this.lstnames.Location = new System.Drawing.Point(12, 123);
            this.lstnames.Name = "lstnames";
            this.lstnames.Size = new System.Drawing.Size(93, 228);
            this.lstnames.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(126, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(609, 245);
            this.dgv.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lstnames);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.btngetname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetname;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.ListBox lstnames;
        private System.Windows.Forms.DataGridView dgv;
    }
}

