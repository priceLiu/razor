using System;
using System.Windows.Forms;
using RazorHosting;
using System.IO;
using System.Reflection;
using System.Text;

namespace RazorHostingWinForm
{
    public partial class RazorScriptingSampleForm : Form
    {
        /// <summary>
        /// Cached instance of RazorHost
        /// </summary>
        RazorEngine<RazorTemplateBase> Host { get; set; }

        /// <summary>
        /// A custom user context object we pass to the Template
        /// </summary>
        public CustomContext CustomContext { get; set; }

        public string FileTemplatePath { get; set; }

        public RazorScriptingSampleForm()
        {
            InitializeComponent();

            // Create a custom context we can pass to Template
            CustomContext = new CustomContext();

            // Assign a reference to this form for use within
            // the template
            CustomContext.WinForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtSource.Text =
@"Hello @Context.GetFullName(). Current time is: @DateTime.Now.

Current time is: @DateTime.Now

This Template runs in its own AppDomain which can be unloaded.
AppDomain: @AppDomain.CurrentDomain.FriendlyName
Assembly: @System.Reflection.Assembly.GetExecutingAssembly().FullName
";
            pgContext.SelectedObject = CustomContext;
        }

        private void tbRun_Click(object sender, EventArgs e)
        {
            RazorEngine<RazorTemplateBase> host = CreateHost();

            if (host == null)
                return;

            //TextReader reader = new StringReader(this.txtSource.Text);
            //string assemblyId = host.ParseAndCompileTemplate("RazorTest","RazorTemplate",new string[] { "System.Windows.Forms.dll", "Westwind.Utilities.dll"},reader);
            //string result = host.ExecuteTemplateByAssembly(assemblyId,
            //        "RazorTest", "RazorTemplate",                    
            //        // Pass in this WinForm as a Context so we can
            //        // manipulate the form from within Razor code
            //        this.CustomContext);


            string result = host.RenderTemplate(
                    this.txtSource.Text,                    
                    new string[] { "System.Windows.Forms.dll", "System.Web.dll" },                
                    this.CustomContext);

            if (result == null)
            {
                MessageBox.Show(host.ErrorMessage, "Template Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.txtResult.Text = result;
        }

        private void tbRunFile_Click(object sender, EventArgs e)
        {
            RazorEngine<RazorTemplateBase> host = CreateHost();            
            if (host == null)
                return;

            string result = String.Empty;
           
            StreamReader reader = null;            
            try
            {
            	reader = new StreamReader("..\\..\\templates\\simple.csHtml", true);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            	return;
            }

            try
            {                
                result = host.RenderTemplate(reader,
                    new string[] { "System.Windows.Forms.dll", "System.Web.dll" },
                    this.CustomContext);
            }
            finally 
            {
                reader.Close();                
            }

            if (result == null)
            {
                MessageBox.Show(host.ErrorMessage, "Template Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.txtResult.Text = result;       
        }

        /// <summary>
        /// Routine that returns an instance of the RazorHost hosted
        /// in a separate AppDomain. Checks for existance of the host
        /// and creates only if needed. You need to cache the host
        /// to avoid excessive resource use.
        /// </summary>
        /// <returns></returns>
        private RazorEngine<RazorTemplateBase> CreateHost()
        {

            if (this.Host != null)
                return this.Host;

            // Use Static Methods - no error message if host doesn't load
            //this.Host = RazorHostFactory<RazorTemplateBase>.CreateRazorHost();           
            this.Host = RazorEngineFactory<RazorTemplateBase>.CreateRazorHostInAppDomain();
            if (this.Host == null)
            {
                MessageBox.Show("Unable to load Razor Template Host",
                                "Razor Hosting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 

            // Use instance methods
            //RazorEngineFactory<RazorTemplateBase> factory = new RazorEngineactory<RazorTemplateBase>();
            //this.Host = factory.GetRazorHostInAppDomain();
            //if (this.Host == null)
            //{
            //    MessageBox.Show("Unable to load Razor Template Host\r\n" + factory.ErrorMessage,
            //                    "Razor Hosting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);             
            //}            

            return this.Host;
        }

        private void tbUnloadAppDomain_Click(object sender, EventArgs e)
        {
            RazorEngineFactory<RazorTemplateBase>.UnloadRazorHostInAppDomain();
            this.Host = null;
        }

        private void tbShowCode_Click(object sender, EventArgs e)
        {
            if (this.Host != null)
            {
                var form = new TextViewer(this.Host.LastGeneratedCode);
                form.ShowDialog();
            }
        }

        private void tbFolderExecute_Click(object sender, EventArgs e)
        {
            var form = new RazorFolderHostForm();
            form.Show();
        }

        private void tbShowStringForm_Click(object sender, EventArgs e)
        {
            var form = new RazorStringHostForm();
            form.Show();
        }

        private void tbRunRaw_Click(object sender, EventArgs e)
        {
            var engine = new RazorEngine<RazorTemplateBase>();

            // we can pass any object as context - here create a custom context
            var context = new CustomContext()
            {
                WinForm = this,
                Entered = DateTime.Now.AddDays(-10)
            };

            string output = engine.RenderTemplate(this.txtSource.Text,
                                                  new string[] { "System.Windows.Forms.dll" },
                                                  context);

            if (output == null)
                this.txtResult.Text = "*** ERROR:\r\n" + engine.ErrorMessage;
            else
                this.txtResult.Text = output;

        }

        private void tbRunLowLevel_Click(object sender, EventArgs e)
        {
            // we can pass any object as context - here create a custom context
            var context = new CustomContext()
            {
                WinForm = this,
                Entered = DateTime.Now.AddDays(-10)
            };

            var engine = new RazorEngine<RazorTemplateBase>();
            string assId = null;

            using (StringReader reader = new StringReader(this.txtSource.Text))
            {
                assId = engine.ParseAndCompileTemplate(new string[] { "System.Windows.Forms.dll" }, reader);
            }

            string output = engine.RenderTemplateFromAssembly(assId, context);

            if (output == null)
                this.txtResult.Text = "*** ERROR:\r\n" + engine.ErrorMessage;
            else
                this.txtResult.Text = output;
        }
    }
}
