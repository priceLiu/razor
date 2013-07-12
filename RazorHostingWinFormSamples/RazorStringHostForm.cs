using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RazorHosting;

namespace RazorHostingWinForm
{
    public partial class RazorStringHostForm : Form
    {
        public CustomContext Context = new CustomContext();
        public RazorStringHostContainer Host = new RazorStringHostContainer();

        public RazorStringHostForm()
        {
            InitializeComponent();
            Host.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Host.UseAppDomain = false;

            Host.Start();            
        }

        private void RazorStringHostForm_Load(object sender, EventArgs e)
        {
            this.txtSource.Text =
@"Hello @Context.GetFullName(). Your entry was entered on @Context.Entered.

Current time is: @DateTime.Now

This Template runs in its own AppDomain which can be unloaded.
AppDomain: @AppDomain.CurrentDomain.FriendlyName
Assembly: @System.Reflection.Assembly.GetExecutingAssembly().FullName
";

            Context.WinForm = this;
            this.pgContext.SelectedObject = Context;
        }

        private void tbRun_Click(object sender, EventArgs e)
        {
            
            string result = Host.RenderTemplate(this.txtSource.Text, this.Context);

            if (result == null)
            {
                MessageBox.Show(Host.ErrorMessage, "Error executing template");
                return;
            }

            this.txtResult.Text = result;
        }

        private void tbUnloadAppDomain_Click(object sender, EventArgs e)
        {
            Host.Stop();
            // Must restart to keep running
            Host.Start();
        }

        private void chkHostInAppDomain_CheckedChanged(object sender, EventArgs e)
        {
            this.Host.UseAppDomain = this.chkHostInAppDomain.Checked;
            this.tbUnloadAppDomain_Click(this, EventArgs.Empty);
        }
    }
}
