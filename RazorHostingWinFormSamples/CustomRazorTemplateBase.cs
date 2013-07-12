
using System;
using System.IO;
using RazorHostingWinForm;

namespace RazorHosting
{
 
    public class CustomRazorTemplate : RazorTemplateFolderHost 
    {
        CustomContext Model = null;
        RazorFolderHostTemplateConfiguration Config = null;
        
        public override void  InitializeTemplate(object context, object configurationData)
        {
	        Model = Context as CustomContext;
            Config = configurationData as RazorFolderHostTemplateConfiguration;

            // Pick up configuration data and stuff into Request object
            RazorFolderHostTemplateConfiguration config = configurationData as RazorFolderHostTemplateConfiguration;

            this.Request.TemplatePath = config.TemplatePath;
            this.Request.TemplateRelativePath = config.TemplateRelativePath;
        }        
    }
}

