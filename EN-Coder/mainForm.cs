using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN_Coder.Forms;
using EN_Coder.Forms.Home;
using EN_Coder.Forms.Info_Manager_Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace EN_Coder
{
    
    public partial class mainForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SqlEncoder;Integrated Security=True");

        private IconButton currentBtn;
        private Panel leftBordersBtn;
        private Form currentChildForm;

        public mainForm()
        {
            InitializeComponent();
            panelSubButtons.Visible = false;

            leftBordersBtn = new Panel();
            leftBordersBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBordersBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(184,215,163);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBordersBtn.BackColor = color;
                leftBordersBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBordersBtn.Visible = true;
                leftBordersBtn.BringToFront();

                iconChange.IconChar = currentBtn.IconChar;
                iconChange.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(63, 63, 70);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Info Manager
        private void btnIM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            if (panelSubButtons.Visible == false)
            {
                panelSubButtons.Visible = true;

                lChange.Text = btnInfoManager.Text;
                lChange.ForeColor = RGBColors.color1;
            }
            else
            {
                panelSubButtons.Visible = false;

                Reset();
            }
        }

        private void btnRInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm( new FormAResellerInfo());

            panelSubButtons.Visible = false;

            lChange.Text = btnResellersInfo.Text;
            lChange.ForeColor = RGBColors.color1;
        }

        private void btnPInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBProductInfo());

            panelSubButtons.Visible = false;

            lChange.Text = btnProductInfo.Text;
            lChange.ForeColor = RGBColors.color1;
        }

        private void btnBInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCBranchesInfo());

            panelSubButtons.Visible = false;

            lChange.Text = btnAccountsInfo.Text;
            lChange.ForeColor = RGBColors.color1;
        }
        #endregion

        #region Button Click Event
        private void btnPI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDProductInventory());

            panelSubButtons.Visible = false;

            ActivateButton(sender, RGBColors.color2);

            lChange.Text = btnProductInventory.Text;
            lChange.ForeColor = RGBColors.color2;
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormECashMonitor());

            panelSubButtons.Visible = false;

            ActivateButton(sender, RGBColors.color3);

            lChange.Text = btnCashMonitor.Text;
            lChange.ForeColor = RGBColors.color3;
        }

        private void btnRI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFResellersIncome());

            panelSubButtons.Visible = false;

            ActivateButton(sender, RGBColors.color4);

            lChange.Text = btnResellersIncome.Text;
            lChange.ForeColor = RGBColors.color4;
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGStatistics());

            panelSubButtons.Visible = false;

            ActivateButton(sender, RGBColors.color5);

            lChange.Text = btnStatistics.Text;
            lChange.ForeColor = RGBColors.color5;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHEncoder());

            panelSubButtons.Visible = false;

            ActivateButton(sender, RGBColors.color6);

            lChange.Text = btnEncode.Text;
            lChange.ForeColor = RGBColors.color6;
        }
        #endregion

        private void pLogo_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();

            iconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            lChange.Text = "Home";
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();

            iconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            lChange.Text = "Home";
        }

        private void Reset()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            panelSubButtons.Visible = false;

            DisableButton();
            leftBordersBtn.Visible = false;

            iconChange.IconChar = IconChar.Home;
            iconChange.IconColor = Color.WhiteSmoke;
            lChange.Text = "Home";
            lChange.ForeColor = Color.WhiteSmoke;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Question", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (pProfile.Visible == false)
            {
                pProfile.Visible = true;
            }
            else
            {
                pProfile.Visible = false;
            }
        }

        FormPass fp = new FormPass();
        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            fp.Show();
            pProfile.Visible = false;
            fp.upDel = btnPUpdate.Text;
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            fp.Show();
            pProfile.Visible = false;
            fp.upDel = btnPDelete.Text;
        }
    }
}
