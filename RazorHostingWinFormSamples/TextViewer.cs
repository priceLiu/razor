using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RazorHostingWinForm
{
    public partial class TextViewer : Form
    {
        public string TextToDisplay { get; set; }


        public TextViewer()
        {
            InitializeComponent();
            TextToDisplay = string.Empty;
        }

        public TextViewer(string text)
        {
            InitializeComponent();
            TextToDisplay = text;
        }

        private void TextViewer_Load(object sender, EventArgs e)
        {            
            this.txtText.Text = TextToDisplay;            
        }

    }
}
