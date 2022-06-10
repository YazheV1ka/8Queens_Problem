
namespace EightQueens_term_proj
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
            this.DFSbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.BFSbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IDSbtn = new System.Windows.Forms.Button();
            this.gameField = new System.Windows.Forms.Panel();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnMInfo = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DFSbtn
            // 
            this.DFSbtn.Location = new System.Drawing.Point(513, 247);
            this.DFSbtn.Margin = new System.Windows.Forms.Padding(4);
            this.DFSbtn.Name = "DFSbtn";
            this.DFSbtn.Size = new System.Drawing.Size(135, 41);
            this.DFSbtn.TabIndex = 0;
            this.DFSbtn.Text = "LDFS";
            this.DFSbtn.UseVisualStyleBackColor = true;
            this.DFSbtn.Click += new System.EventHandler(this.DFSbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "          8Queens\r\nTry to solve the task!";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 23);
            this.lblTime.TabIndex = 6;
            // 
            // BFSbtn
            // 
            this.BFSbtn.Location = new System.Drawing.Point(513, 190);
            this.BFSbtn.Name = "BFSbtn";
            this.BFSbtn.Size = new System.Drawing.Size(135, 41);
            this.BFSbtn.TabIndex = 5;
            this.BFSbtn.Text = "BFS";
            this.BFSbtn.UseVisualStyleBackColor = true;
            this.BFSbtn.Click += new System.EventHandler(this.BFSbtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(524, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose metod";
            // 
            // IDSbtn
            // 
            this.IDSbtn.Location = new System.Drawing.Point(513, 304);
            this.IDSbtn.Name = "IDSbtn";
            this.IDSbtn.Size = new System.Drawing.Size(133, 43);
            this.IDSbtn.TabIndex = 10;
            this.IDSbtn.Text = "IDS";
            this.IDSbtn.UseVisualStyleBackColor = true;
            this.IDSbtn.Click += new System.EventHandler(this.IDSbtn_Click);
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(12, 89);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(484, 486);
            this.gameField.TabIndex = 11;
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(514, 530);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(132, 38);
            this.btnRules.TabIndex = 13;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnMInfo
            // 
            this.btnMInfo.Location = new System.Drawing.Point(514, 462);
            this.btnMInfo.Name = "btnMInfo";
            this.btnMInfo.Size = new System.Drawing.Size(132, 42);
            this.btnMInfo.TabIndex = 14;
            this.btnMInfo.Text = "Metods Info";
            this.btnMInfo.UseVisualStyleBackColor = true;
            this.btnMInfo.Click += new System.EventHandler(this.btnMInfo_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Clearbtn.Location = new System.Drawing.Point(12, 60);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(72, 23);
            this.Clearbtn.TabIndex = 15;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Checkbtn
            // 
            this.Checkbtn.Location = new System.Drawing.Point(92, 60);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(72, 23);
            this.Checkbtn.TabIndex = 16;
            this.Checkbtn.Text = "Check";
            this.Checkbtn.UseVisualStyleBackColor = true;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 607);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.btnMInfo);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.gameField);
            this.Controls.Add(this.IDSbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BFSbtn);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DFSbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8Queen Task";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Checkbtn;

        private System.Windows.Forms.Button Clearbtn;

        private System.Windows.Forms.Button btnMInfo;

        private System.Windows.Forms.Button btnRules;

        private System.Windows.Forms.Panel gameField;

        #endregion
        private System.Windows.Forms.Button DFSbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BFSbtn;
        private System.Windows.Forms.Button IDSbtn;
        
    }
}
