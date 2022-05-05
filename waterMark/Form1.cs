using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace waterMark
{
    public partial class Form1 : Form
    {

        Bitmap ImageFile = null;
        bool fnset = false;
        bool fncol = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog()==DialogResult.OK)
                this.txtBack.Text = this.ofdFile.FileName;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.fdlg.ShowDialog() == DialogResult.OK)
            {
                Mark.fnSet = this.fdlg.Font;
                fnset = true;
            }

        }

        private void 색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.cdlg.ShowDialog()==DialogResult.OK)
            {
                Mark.fnCol = this.cdlg.Color;
                fncol = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(txtCheck())
            {
                Mark.BackImgPath = this.txtBack.Text;
                Mark.MarkImgText = this.txtMark.Text;
                Mark.MarkOpacity = this.hsbOpacity.Value;
                this.picView.Image = Mark.NewImage().Image;
            }
        }

        private bool txtCheck()
        {
            if(this.txtBack.Text=="")
            {
                MessageBox.Show("배경 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(this.txtMark.Text=="")
            {
                MessageBox.Show("마킹 이미지 파일을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(!fnset)
            {
                MessageBox.Show("마킹 글꼴을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!fncol)
            {
                MessageBox.Show("마킹 색상을 선택하지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.picView.Image != null)
            {
                if(this.sfdFile.ShowDialog()==DialogResult.OK)
                {
                    ImageFile = new Bitmap(Mark.ImageSize.Width, Mark.ImageSize.Height);
                    ImageFile = (Bitmap)this.picView.Image;
                    this.ImageFile.Save(sfdFile.FileName, ImageFormat.Jpeg);
                }
            }
        }
    }
}
