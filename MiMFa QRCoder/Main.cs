using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa_BarCoder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            cbc_Main.Text = tb_Text.Text;
        }
        private void Main_Shown(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(Clipboard.GetText()))
                tb_Text.Paste();
            TopMost = true;
            TopMost = false;
        }
        private void ni_Main_Click(object sender, EventArgs e)
        {
            TopMost = true;
            TopMost = false;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Text.SelectAll();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Text.Copy();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Text.Cut();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Text.Paste();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (cb_RealTime.Checked)
                tb_Text.Paste();
        }

        private void cbc_Main_Click(object sender, EventArgs e)
        {

        }
        private void cbc_Main_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files (*.png)|*.png";
            sfd.RestoreDirectory = true;
            sfd.FileName = Regex.Replace(tb_Text.Text,"\\W+"," ");
            if (sfd.ShowDialog() == DialogResult.OK)
                cbc_Main.GetImage(System.Drawing.Imaging.ImageFormat.Png).Save(sfd.FileName);
        }
    }
}
