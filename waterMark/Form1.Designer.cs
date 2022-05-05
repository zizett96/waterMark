
namespace waterMark
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBack = new System.Windows.Forms.Label();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.폰트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMark = new System.Windows.Forms.Label();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.hsbOpacity = new System.Windows.Forms.HScrollBar();
            this.picView = new System.Windows.Forms.PictureBox();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.fdlg = new System.Windows.Forms.FontDialog();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(12, 39);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(45, 12);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "배 경 : ";
            // 
            // msBar
            // 
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트설정ToolStripMenuItem});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Size = new System.Drawing.Size(486, 24);
            this.msBar.TabIndex = 1;
            this.msBar.Text = "menuStrip1";
            // 
            // 폰트설정ToolStripMenuItem
            // 
            this.폰트설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.폰트설정ToolStripMenuItem.Name = "폰트설정ToolStripMenuItem";
            this.폰트설정ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.폰트설정ToolStripMenuItem.Text = "폰트 설정";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(12, 64);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(45, 12);
            this.lblMark.TabIndex = 2;
            this.lblMark.Text = "마 킹 : ";
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(63, 32);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(330, 21);
            this.txtBack.TabIndex = 3;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(63, 66);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(330, 21);
            this.txtMark.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(399, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "배경 파일";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(399, 64);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "미리 보기";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // hsbOpacity
            // 
            this.hsbOpacity.Location = new System.Drawing.Point(73, 118);
            this.hsbOpacity.Name = "hsbOpacity";
            this.hsbOpacity.Size = new System.Drawing.Size(304, 17);
            this.hsbOpacity.TabIndex = 8;
            this.hsbOpacity.Value = 50;
            // 
            // picView
            // 
            this.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picView.Location = new System.Drawing.Point(12, 164);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(462, 274);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 9;
            this.picView.TabStop = false;
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(12, 123);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(41, 12);
            this.lblOpacity.TabIndex = 10;
            this.lblOpacity.Text = "투명도";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "JPEG Images(*.jpg, *.jpeg)|*.jpg;*.jpeg|GIF Image(*.gif)|*.gif|Bitmap(*.bmp)|*.bm" +
    "p|All Image Format|*.jpg;*.jpeg;*.gif*.bmp";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "이미지 파일(*.jpg)|*.jpg";
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.글꼴ToolStripMenuItem.Text = "글 꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.색상ToolStripMenuItem.Text = "색 상";
            this.색상ToolStripMenuItem.Click += new System.EventHandler(this.색상ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.hsbOpacity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.msBar);
            this.MainMenuStrip = this.msBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.MenuStrip msBar;
        private System.Windows.Forms.ToolStripMenuItem 폰트설정ToolStripMenuItem;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtBack;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HScrollBar hsbOpacity;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FontDialog fdlg;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
    }
}

