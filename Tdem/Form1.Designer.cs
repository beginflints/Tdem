namespace Tdem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Flag = new System.Windows.Forms.TextBox();
            this.Btn_Get = new System.Windows.Forms.Button();
            this.Btn_AddOrUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filename";
            // 
            // Txt_Filename
            // 
            this.Txt_Filename.Location = new System.Drawing.Point(14, 36);
            this.Txt_Filename.Name = "Txt_Filename";
            this.Txt_Filename.Size = new System.Drawing.Size(215, 20);
            this.Txt_Filename.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Flag";
            // 
            // Txt_Flag
            // 
            this.Txt_Flag.Location = new System.Drawing.Point(247, 36);
            this.Txt_Flag.Name = "Txt_Flag";
            this.Txt_Flag.Size = new System.Drawing.Size(166, 20);
            this.Txt_Flag.TabIndex = 9;
            // 
            // Btn_Get
            // 
            this.Btn_Get.Location = new System.Drawing.Point(517, 33);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(75, 23);
            this.Btn_Get.TabIndex = 8;
            this.Btn_Get.Text = "Get";
            this.Btn_Get.UseVisualStyleBackColor = true;
            this.Btn_Get.Click += new System.EventHandler(this.Btn_Get_Click);
            // 
            // Btn_AddOrUpdate
            // 
            this.Btn_AddOrUpdate.Location = new System.Drawing.Point(419, 33);
            this.Btn_AddOrUpdate.Name = "Btn_AddOrUpdate";
            this.Btn_AddOrUpdate.Size = new System.Drawing.Size(92, 23);
            this.Btn_AddOrUpdate.TabIndex = 7;
            this.Btn_AddOrUpdate.Text = "Add or Update";
            this.Btn_AddOrUpdate.UseVisualStyleBackColor = true;
            this.Btn_AddOrUpdate.Click += new System.EventHandler(this.Btn_AddOrUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Flag);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.Btn_AddOrUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Flag;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.Button Btn_AddOrUpdate;
    }
}

