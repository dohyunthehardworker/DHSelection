using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace DHMemorizer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FormMain Load 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //메인폼의 이름
            this.Text = Properties.Resource.Internationalization.FormMain.DHMemorizer;
        }

        /// <summary>
        /// toolStripStatusLabelIcon Click 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripStatusLabelIcon_Click(object sender, EventArgs e)
        {
            VisitLink("https://icons8.com");
        }

        private void VisitLink(string url)
        {
            if (null == url)
            {
                return;
            }
            toolStripStatusLabelIcon.LinkVisited = true;
            System.Diagnostics.Process.Start(url);
        }
    }
}
