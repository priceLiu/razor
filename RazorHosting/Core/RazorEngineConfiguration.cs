using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RazorHosting
{
    /// <summary>
    /// Configuration for the Host class. These settings determine some of the
    /// operational parameters of the RazorHost class that can be changed at
    /// runtime.
    /// </summary>        
    public class RazorEngineConfiguration : MarshalByRefObject
    {
        /// <summary>
        /// Determines if assemblies are compiled to disk or to memory.
        /// If compiling to disk generated assemblies are not cleaned up
        /// </summary>
        public bool CompileToMemory
        {
            get { return _CompileToMemory; }
            set { _CompileToMemory = value; }
        }
        private bool _CompileToMemory = true;

        /// <summary>
        /// When compiling to disk use this Path to hold generated assemblies
        /// </summary>
        public string TempAssemblyPath
        {
            get 
            { 
                if (!string.IsNullOrEmpty(_TempAssemblyPath))
                    return _TempAssemblyPath; 
                   
                return Path.GetTempPath();            
            }
            set { _TempAssemblyPath = value; }
        }
        private string _TempAssemblyPath = null;

         /// <summary>
         /// Encoding to be used when generating output to file
         /// </summary>
        public Encoding OutputEncoding
        {
          get { return _OutputEncoding; }
          set { _OutputEncoding = value; }
        }
        private Encoding _OutputEncoding = Encoding.UTF8;

        
        /// <summary>
        /// Buffer size for streamed template output when using filenames
        /// </summary>
        public int StreamBufferSize
        {
            get { return _StreamBufferSize; }
            set { _StreamBufferSize = value; }
        }
        private int _StreamBufferSize = 2048;

    }
}
