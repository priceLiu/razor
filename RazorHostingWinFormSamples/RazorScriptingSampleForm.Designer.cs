namespace RazorHostingWinForm
{
    partial class RazorScriptingSampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RazorScriptingSampleForm));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbRunLowLevel = new System.Windows.Forms.ToolStripButton();
            this.tbRunRaw = new System.Windows.Forms.ToolStripButton();
            this.tbRun = new System.Windows.Forms.ToolStripButton();
            this.tbRunFile = new System.Windows.Forms.ToolStripButton();
            this.tbUnloadAppDomain = new System.Windows.Forms.ToolStripButton();
            this.tbShowCode = new System.Windows.Forms.ToolStripButton();
            this.tbFolderHostExecute = new System.Windows.Forms.ToolStripButton();
            this.tbStringHost = new System.Windows.Forms.ToolStripButton();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgContext = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(0, 42);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(617, 201);
            this.txtSource.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 265);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(887, 135);
            this.txtResult.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRunLowLevel,
            this.tbRunRaw,
            this.tbRun,
            this.tbRunFile,
            this.tbUnloadAppDomain,
            this.tbShowCode,
            this.tbFolderHostExecute,
            this.tbStringHost});
            this.toolStrip1.Location = new System.Drawing.Point(9, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tbRunLowLevel
            // 
            this.tbRunLowLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbRunLowLevel.Image = ((System.Drawing.Image)(resources.GetObject("tbRunLowLevel.Image")));
            this.tbRunLowLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRunLowLevel.Name = "tbRunLowLevel";
            this.tbRunLowLevel.Size = new System.Drawing.Size(80, 22);
            this.tbRunLowLevel.Text = "Run Low Level";
            this.tbRunLowLevel.Click += new System.EventHandler(this.tbRunLowLevel_Click);
            // 
            // tbRunRaw
            // 
            this.tbRunRaw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbRunRaw.Image = ((System.Drawing.Image)(resources.GetObject("tbRunRaw.Image")));
            this.tbRunRaw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRunRaw.Name = "tbRunRaw";
            this.tbRunRaw.Size = new System.Drawing.Size(51, 22);
            this.tbRunRaw.Text = "Run 101";
            this.tbRunRaw.Click += new System.EventHandler(this.tbRunRaw_Click);
            // 
            // tbRun
            // 
            this.tbRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbRun.Image = ((System.Drawing.Image)(resources.GetObject("tbRun.Image")));
            this.tbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRun.Name = "tbRun";
            this.tbRun.Size = new System.Drawing.Size(30, 22);
            this.tbRun.Text = "Run";
            this.tbRun.Click += new System.EventHandler(this.tbRun_Click);
            // 
            // tbRunFile
            // 
            this.tbRunFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbRunFile.Image = ((System.Drawing.Image)(resources.GetObject("tbRunFile.Image")));
            this.tbRunFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRunFile.Name = "tbRunFile";
            this.tbRunFile.Size = new System.Drawing.Size(76, 22);
            this.tbRunFile.Text = "Run From File";
            this.tbRunFile.Click += new System.EventHandler(this.tbRunFile_Click);
            // 
            // tbUnloadAppDomain
            // 
            this.tbUnloadAppDomain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbUnloadAppDomain.Image = ((System.Drawing.Image)(resources.GetObject("tbUnloadAppDomain.Image")));
            this.tbUnloadAppDomain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUnloadAppDomain.Name = "tbUnloadAppDomain";
            this.tbUnloadAppDomain.Size = new System.Drawing.Size(101, 22);
            this.tbUnloadAppDomain.Text = "Unload AppDomain";
            this.tbUnloadAppDomain.Click += new System.EventHandler(this.tbUnloadAppDomain_Click);
            // 
            // tbShowCode
            // 
            this.tbShowCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbShowCode.Image = ((System.Drawing.Image)(resources.GetObject("tbShowCode.Image")));
            this.tbShowCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowCode.Name = "tbShowCode";
            this.tbShowCode.Size = new System.Drawing.Size(89, 22);
            this.tbShowCode.Text = "Last Code Gen\'d";
            this.tbShowCode.Click += new System.EventHandler(this.tbShowCode_Click);
            // 
            // tbFolderHostExecute
            // 
            this.tbFolderHostExecute.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolderHostExecute.Image = ((System.Drawing.Image)(resources.GetObject("tbFolderHostExecute.Image")));
            this.tbFolderHostExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFolderHostExecute.Name = "tbFolderHostExecute";
            this.tbFolderHostExecute.Size = new System.Drawing.Size(146, 22);
            this.tbFolderHostExecute.Text = "Folder HostContainer";
            this.tbFolderHostExecute.Click += new System.EventHandler(this.tbFolderExecute_Click);
            // 
            // tbStringHost
            // 
            this.tbStringHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbStringHost.Image = ((System.Drawing.Image)(resources.GetObject("tbStringHost.Image")));
            this.tbStringHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStringHost.Name = "tbStringHost";
            this.tbStringHost.Size = new System.Drawing.Size(111, 22);
            this.tbStringHost.Text = "String HostContainer";
            this.tbStringHost.Click += new System.EventHandler(this.tbShowStringForm_Click);
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(0, 26);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(102, 13);
            this.lblTemplate.TabIndex = 4;
            this.lblTemplate.Text = "Template to Render";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Generated";
            // 
            // pgContext
            // 
            this.pgContext.HelpVisible = false;
            this.pgContext.Location = new System.Drawing.Point(623, 42);
            this.pgContext.Name = "pgContext";
            this.pgContext.Size = new System.Drawing.Size(264, 201);
            this.pgContext.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Context Object Properties";
            // 
            // RazorScriptingSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgContext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RazorScriptingSampleForm";
            this.Text = "Razor Hosting Sample Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbRun;
        private System.Windows.Forms.ToolStripButton tbRunFile;
        private System.Windows.Forms.ToolStripButton tbUnloadAppDomain;
        private System.Windows.Forms.ToolStripButton tbShowCode;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid pgContext;
        private System.Windows.Forms.ToolStripButton tbFolderHostExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tbStringHost;
        private System.Windows.Forms.ToolStripButton tbRunRaw;
        private System.Windows.Forms.ToolStripButton tbRunLowLevel;
    }
}

