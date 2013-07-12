using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RazorHostingWinForm
{
    /// <summary>
    /// Example of a context used to pass data to a template page
    /// The context passed can be any serializable object.
    /// 
    /// In this example some simple properties and a reference
    /// to the parent Windows Forms object are passed via this
    /// context reference
    /// 
    /// Context objects are useful for passing application specific
    /// logic to the template. You can also subclass the template
    /// base class and add your own strongly typed objects directly
    /// as properties to the template (visible as this.Property in
    /// template code)
    /// </summary>
    [Serializable]
    public class CustomContext
    {
        public string MachineName { get; set; }
        public DateTime Entered { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string TemplatePath { get; set; }
        public string TemplateRelativePath { get; set; }
        
        // 
        public Form WinForm { get; set; }

        public CustomContext()
        {
            MachineName = Environment.MachineName;
            Entered = DateTime.Now;
            FirstName = "Rick";
            LastName = "Strahl";
        }

        public string GetFullName()
        {
            if (string.IsNullOrEmpty(FirstName))
                return LastName;

            if (string.IsNullOrEmpty(LastName))
                return FirstName;

            return FirstName + " " + LastName;
        }
        
    }
}
