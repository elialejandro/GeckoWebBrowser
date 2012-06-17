using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Gecko;

namespace GeckoWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String xulPath = Application.StartupPath + "\\xulrunner\\";
            Gecko.Xpcom.Initialize(xulPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("http://www.google.com.mx");
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoBack();
        }

        private void BotonAdelante_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoForward();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Stop();
        }

        private void BotonIr_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(TextUrl.Text);
        }
    }
}
