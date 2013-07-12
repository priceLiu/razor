namespace RazorHostingWinForm
{
    partial class RazorStringHostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RazorStringHostForm));
            this.label2 = new System.Windows.Forms.Label();
            this.pgContext = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbRun = new System.Windows.Forms.ToolStripButton();
            this.tbUnloadAppDomain = new System.Windows.Forms.ToolStripButton();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkHostInAppDomain = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Context Object Properties";
            // 
            // pgContext
            // 
            this.pgContext.HelpVisible = false;
            this.pgContext.Location = new System.Drawing.Point(584, 45);
            this.pgContext.Name = "pgContext";
            this.pgContext.Size = new System.Drawing.Size(245, 201);
            this.pgContext.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output Generated";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(0, 29);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(101, 13);
            this.lblTemplate.TabIndex = 11;
            this.lblTemplate.Text = "Template to Render";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRun,
            this.tbUnloadAppDomain});
            this.toolStrip1.Location = new System.Drawing.Point(9, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(143, 25);
            this.toolStrip1.TabIndex = 8;
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
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(0, 45);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(576, 201);
            this.txtSource.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 268);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(827, 222);
            this.txtResult.TabIndex = 10;
            // 
            // chkHostInAppDomain
            // 
            this.chkHostInAppDomain.AutoSize = true;
            this.chkHostInAppDomain.Checked = true;
            this.chkHostInAppDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHostInAppDomain.Location = new System.Drawing.Point(584, 9);
            this.chkHostInAppDomain.Name = "chkHostInAppDomain";
            this.chkHostInAppDomain.Size = new System.Drawing.Size(117, 17);
            this.chkHostInAppDomain.TabIndex = 18;
            this.chkHostInAppDomain.Text = "Host in AppDomain";
            this.chkHostInAppDomain.UseVisualStyleBackColor = true;
            this.chkHostInAppDomain.CheckedChanged += new System.EventHandler(this.chkHostInAppDomain_CheckedChanged);
            // 
            // RazorStringHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.chkHostInAppDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgContext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtResult);
            this.Name = "RazorStringHostForm";
            this.Text = "RazorStringHostForm";
            this.Load += new System.EventHandler(this.RazorStringHostForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PropertyGrid pgContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbRun;
        private System.Windows.Forms.ToolStripButton tbUnloadAppDomain;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkHostInAppDomain;
    }
}