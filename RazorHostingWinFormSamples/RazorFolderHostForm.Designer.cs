namespace RazorHostingWinForm
{
    partial class RazorFolderHostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pgContextProperties = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnloadAppDomain = new System.Windows.Forms.Button();
            this.chkHostInAppDomain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output Generated";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(6, 24);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(665, 22);
            this.txtFileName.TabIndex = 8;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDialog.Location = new System.Drawing.Point(673, 22);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(25, 25);
            this.btnFileDialog.TabIndex = 9;
            this.btnFileDialog.Text = "...";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(782, 498);
            this.webBrowser1.TabIndex = 10;
            // 
            // btnRender
            // 
            this.btnRender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRender.Location = new System.Drawing.Point(698, 22);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 25);
            this.btnRender.TabIndex = 11;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(773, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pgContextProperties
            // 
            this.pgContextProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgContextProperties.HelpVisible = false;
            this.pgContextProperties.Location = new System.Drawing.Point(788, 78);
            this.pgContextProperties.Name = "pgContextProperties";
            this.pgContextProperties.Size = new System.Drawing.Size(257, 498);
            this.pgContextProperties.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Context Object Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Template File to render";
            // 
            // btnUnloadAppDomain
            // 
            this.btnUnloadAppDomain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnloadAppDomain.Location = new System.Drawing.Point(848, 22);
            this.btnUnloadAppDomain.Name = "btnUnloadAppDomain";
            this.btnUnloadAppDomain.Size = new System.Drawing.Size(75, 25);
            this.btnUnloadAppDomain.TabIndex = 16;
            this.btnUnloadAppDomain.Text = "Unload";
            this.btnUnloadAppDomain.UseVisualStyleBackColor = true;
            this.btnUnloadAppDomain.Click += new System.EventHandler(this.btnUnloadAppDomain_Click);
            // 
            // chkHostInAppDomain
            // 
            this.chkHostInAppDomain.AutoSize = true;
            this.chkHostInAppDomain.Checked = true;
            this.chkHostInAppDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHostInAppDomain.Location = new System.Drawing.Point(673, 3);
            this.chkHostInAppDomain.Name = "chkHostInAppDomain";
            this.chkHostInAppDomain.Size = new System.Drawing.Size(130, 18);
            this.chkHostInAppDomain.TabIndex = 17;
            this.chkHostInAppDomain.Text = "Host in AppDomain";
            this.chkHostInAppDomain.UseVisualStyleBackColor = true;
            this.chkHostInAppDomain.CheckedChanged += new System.EventHandler(this.chkHostInAppDomain_CheckedChanged);
            // 
            // RazorFolderHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 575);
            this.Controls.Add(this.chkHostInAppDomain);
            this.Controls.Add(this.btnUnloadAppDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgContextProperties);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.Name = "RazorFolderHostForm";
            this.Text = "Razor Hosting in FolderHost Container";
            this.Load += new System.EventHandler(this.RazorFileHostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PropertyGrid pgContextProperties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnloadAppDomain;
        private System.Windows.Forms.CheckBox chkHostInAppDomain;
    }
}