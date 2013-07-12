using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RazorHosting;
using System.Diagnostics;

namespace RazorHostingWinForm
{
    public partial class RazorFolderHostForm : Form
    {
        protected string TemplateBaseFolder = "..\\..\\templates\\";
        
        RazorFolderHostContainer<CustomRazorTemplate> HostContainer = new RazorFolderHostContainer<CustomRazorTemplate>();
        //RazorFolderHostContainer HostContainer = new RazorFolderHostContainer();

        /// <summary>
        /// Create an arbitrary Context object we pass to the 
        /// template each time.
        /// </summary>
        CustomContext Context = new CustomContext();

        public RazorFolderHostForm()
        {
            InitializeComponent();
            
            // The base path for templates - templates are rendered with relative paths
            // based on this path.
            HostContainer.TemplatePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, TemplateBaseFolder)); 

            // Default output rendering disk location
            HostContainer.RenderingOutputFile = Path.Combine(HostContainer.TemplatePath, "__Preview.htm");

            // Add any assemblies you want reference in your templates
            HostContainer.ReferencedAssemblies.Add( "System.Windows.Forms.dll");

            // Add a reference to this EXE assembly so we can access the CustomContext class
            // as a strongly typed class
            HostContainer.ReferencedAssemblies.Add( "RazorHostingWinForm.exe");

            HostContainer.ReferencedAssemblies.Add("System.Web.dll");
            HostContainer.ReferencedAssemblies.Add("System.Web.Extensions.dll");

            // Start up the host container
            HostContainer.Start();

            HostContainer.Engine.Configuration.CompileToMemory = false;
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.DefaultExt = "cshtml";
            diag.Filter = "C# Razor Templates (*.csHtml)|*.csHtml";
            diag.CheckFileExists = true;
            diag.Title = "Select Template to load";
            diag.InitialDirectory = Path.Combine(Environment.CurrentDirectory,TemplateBaseFolder);

            DialogResult res = diag.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
            {

                this.txtFileName.Text = diag.FileName;                                
            }
        }

        private void RenderTemplate(string fileName)
        {
            // Pass the template path via the Context            
            var relativePath = Utilities.GetRelativePath(fileName, HostContainer.TemplatePath);

            
            if (!HostContainer.RenderTemplate(relativePath, this.Context, HostContainer.RenderingOutputFile))
            {
                MessageBox.Show("Error: " + HostContainer.ErrorMessage);
                return;
            }

            this.webBrowser1.Navigate("file://" + HostContainer.RenderingOutputFile);
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            Context.TemplatePath = this.txtFileName.Text;
            Context.TemplateRelativePath = Utilities.GetRelativePath(this.txtFileName.Text, HostContainer.TemplatePath);

            if (!string.IsNullOrEmpty(this.txtFileName.Text))
                this.RenderTemplate(this.txtFileName.Text);
            else
                MessageBox.Show("Please enter a file name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // ShellExecute
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = this.txtFileName.Text;            
            process.Start();
        }

        private void RazorFileHostForm_Load(object sender, EventArgs e)
        {
            // templates folder is in the project
            this.txtFileName.Text = Path.GetFullPath(
                                                Path.Combine(Environment.CurrentDirectory,
                                                 @"..\..\Templates\FolderHost.csHtml"));
            this.Context.WinForm = this;

            this.pgContextProperties.SelectedObject = this.Context;
            this.pgContextProperties.Text = "Context Object Properties";
        }



        private void btnUnloadAppDomain_Click(object sender, EventArgs e)
        {
            // Stop the Host to unload AppDomain
            this.HostContainer.Stop();

            // Restart it to run again for more requests
            this.HostContainer.Start();
        }

        private void chkHostInAppDomain_CheckedChanged(object sender, EventArgs e)
        {
            this.HostContainer.UseAppDomain = this.chkHostInAppDomain.Checked;
            this.btnUnloadAppDomain_Click(this, EventArgs.Empty);
        }

    }
}
