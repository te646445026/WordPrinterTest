namespace WordPrinter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnClearList;
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            btnClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(316, 259);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(101, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "btnSelectFiles";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(588, 259);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 12;
            this.lbFiles.Location = new System.Drawing.Point(81, 68);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(605, 136);
            this.lbFiles.TabIndex = 2;
            // 
            // btnClearList
            // 
            btnClearList.Location = new System.Drawing.Point(453, 259);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new System.Drawing.Size(102, 23);
            btnClearList.TabIndex = 3;
            btnClearList.Text = "btnClearList";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(82, 221);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(604, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(btnClearList);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSelectFiles);
            this.Name = "Form1";
            this.Text = "Word文档批量打印工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

