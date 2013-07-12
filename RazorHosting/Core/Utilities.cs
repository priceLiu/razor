using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorHosting
{
    /// <summary>
    /// Helper class that provides a few simple utilitity functions to the project
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Returns a relative path based on a base path.
        /// 
        /// Examples:
        /// &lt;&lt;ul&gt;&gt;
        /// &lt;&lt;li&gt;&gt; filename.txt
        /// &lt;&lt;li&gt;&gt; subDir\filename.txt
        /// &lt;&lt;li&gt;&gt; ..\filename.txt
        /// &lt;&lt;li&gt;&gt; ..\..\filename.txt
        /// &lt;&lt;/ul&gt;&gt;
        /// <seealso>Class Utilities</seealso>
        /// </summary>
        /// <param name="fullPath">
        /// The full path from which to generate a relative path
        /// </param>
        /// <param name="basePath">
        /// The base path based on which the relative path is based on
        /// </param>
        /// <returns>string</returns>
        public static string GetRelativePath(string fullPath, string basePath)
        {
            // ForceBasePath to a path
            if (!basePath.EndsWith("\\"))
                basePath += "\\";

            Uri baseUri = new Uri(basePath);
            Uri fullUri = new Uri(fullPath);

            Uri relativeUri = baseUri.MakeRelativeUri(fullUri);

            // Uri's use forward slashes so convert back to backward slahes
            return relativeUri.ToString().Replace("/", "\\");
        }
    }
}
