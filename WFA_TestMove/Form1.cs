using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace WFA_TestMove
{
    public partial class Form1 : Form
    {
        #region private members
        int openPanel = 0;
        string myUsername = "";
        int countAr;
        ArrayList arUsers = new ArrayList();
        #endregion 

        public Form1()
        {
            InitializeComponent();
        }

        #region private methods
        private void FillMenuComboBox()
        {
            DirectoryInfo di = new DirectoryInfo(statics.pathToData + "/Berufe");            
            foreach(DirectoryInfo d in di.GetDirectories())
            {
                toolStripCB_Berufsgruppen.Items.Add(d.Name);
            }
            toolStripCB_Berufsgruppen.Text = "Wähle eine Berufsgruppe";
            
        }

        private void ResizePanels()
        {
            #region panel_userLogin
            panel_userLogin.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width,Screen.PrimaryScreen.WorkingArea.Height - menuStrip1.Height);
            panel_userLogin.Location = new Point(0, 0);
            lbl_Logout.Location = new Point(this.Width - 100,5);
            groupBox_Login.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (groupBox_Login.Width / 2), (panel_main.Height / 2) - (groupBox_Login.Height / 2));
            #endregion

            #region panel_Klassenbuch
            panel_Klassenbuch.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height - menuStrip1.Height);
            panel_Klassenbuch.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, menuStrip1.Height);

            #endregion
        }

        private void showPanel()
        {
            switch(openPanel)
            {
                case 0:
                    panel_userLogin.Visible = true;
                    break;
                case 1:
                    break;
            }
        }       

        private void DoLogin()
        {
            if(tB_LoginUsername.Text.Length > 9 && tB_LoginPasswort.Text.Length > 5)
            {
                if (Directory.Exists(statics.pathToData))
                {
                    StreamReader sr = new StreamReader(statics.pathToData + "/Users/users.uls");
                    string sLine = "";

                    while (sLine != null)
                    {
                        sLine = sr.ReadLine();
                        if (sLine != null)
                        {
                            arUsers.Add(sLine);
                        }
                    }

                    sr.Close();
                    bool gotIt = false;

                    for (int i = 0; i < arUsers.Count; i = i + 3)
                    {
                        if (arUsers[i].ToString() == tB_LoginUsername.Text)
                        {
                            if (arUsers[i + 1].ToString() == tB_LoginPasswort.Text)
                            {
                                myUsername = tB_LoginUsername.Text;
                                gotIt = true;
                                countAr = i;
                                i = arUsers.Count;
                            }
                        }
                    }

                    if (!gotIt)
                    {
                        this.Text = "nächstes mal wirds besser";
                    }
                    else
                    {
                        /*
                        Bearbeitung bt = new Bearbeitung();
                        bt.GetSetProfession = arUsers[countAr + 2].ToString();
                        bt.ShowDialog();                        
                        */
                        statics.programmState = 1;
                        menuStrip1.Enabled = true;
                        lbl_Logout.Visible = true;
                        timer1.Start();
                        panel_userLogin.Visible = false;
                    }

                }
                else
                {
                    this.Text = "Sorry Database hat jemand gestohlen :)";
                }
            }
            else
            {
                if(tB_LoginPasswort.Text.Length <= 5)
                {
                    tB_LoginPasswort.BackColor = Color.Red;
                }
                if(tB_LoginUsername.Text.Length <= 9)
                {
                    tB_LoginUsername.BackColor = Color.Red;
                }
            }
        }

        private void resetLogin()
        {
            tB_LoginUsername.Text = "";
            tB_LoginPasswort.Text = "";
        }

        private void Logout()
        {
            openPanel = 0;
            menuStrip1.Enabled = false;
        }

        private void ClearKlassen()
        {
            toolStripCB_Klasse.Items.Clear();
            toolStripCB_Klasse.Text = "";
        }
        #endregion 

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
           // this.Text = this.Size.Width.ToString() + " - " + (this.Size.Height - menuStrip1.Height).ToString();
            this.Location = new Point(0, 0);
            panel_main.Width = Screen.PrimaryScreen.WorkingArea.Width * 2;
            panel_main.Height = Screen.PrimaryScreen.WorkingArea.Height - menuStrip1.Height;
            panel_main.Location = new Point(0, menuStrip1.Height);
            menuStrip1.Enabled = false;
            FillMenuComboBox();
            ResizePanels();
            showPanel();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (openPanel)
            {
                case 0:
                    if (e.KeyCode == Keys.Enter)
                    {
                        DoLogin();
                    }

                    if (e.KeyCode == Keys.Escape)
                    {
                        resetLogin();
                    }
                    break;
            }
        }

        private void btn_LoginOkay_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void btn_LoginCancel_Click(object sender, EventArgs e)
        {
            resetLogin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(openPanel)
            {
               
            }
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            machmalraus();
        }

        private void machmalraus()
        {
            panel_main.Location = new Point(0, 0);
            panel_userLogin.Visible = true;
            menuStrip1.Enabled = false;
            lbl_Logout.Visible = false;
            resetLogin();
            timer1.Stop();
        }

        private void lbl_Logout_MouseEnter(object sender, EventArgs e)
        {
            lbl_Logout.ForeColor = Color.Red;
        }

        private void lbl_Logout_MouseLeave(object sender, EventArgs e)
        {
            lbl_Logout.ForeColor = Color.Black;
        }

        private void toolStripCB_Berufsgruppen_TextChanged(object sender, EventArgs e)
        {
            if(toolStripCB_Berufsgruppen.Text.Length > 1 && toolStripCB_Berufsgruppen.Text != "Wähle eine Berufsgruppe")
            {
                toolStripCB_Berufe.Items.Clear();
                toolStripCB_Berufe.Text = "";
                ClearKlassen();
                
                DirectoryInfo diBerufe = new DirectoryInfo(statics.pathToData + "/Berufe/" + toolStripCB_Berufsgruppen.Text);
                foreach(DirectoryInfo dB in diBerufe.GetDirectories())
                {
                    toolStripCB_Berufe.Items.Add(dB.Name);
                }
                toolStripCB_Berufe.Text = "Wähle einen Beruf";
                this.Text = "Noch keine Ausbildungsgruppe ausgewählt!";
                toolStripCB_Berufe.Visible = true;
                toolStripCB_Klasse.Visible = false;
            }
        }

        private void toolStripCB_Berufe_TextChanged(object sender, EventArgs e)
        {
            if (toolStripCB_Berufe.Text != "Wähle einen Beruf" && toolStripCB_Berufe.Text.Length > 1)
            {
                toolStripCB_Klasse.Items.Clear();
                DirectoryInfo dberufe = new DirectoryInfo(statics.pathToData + "/Berufe/" + toolStripCB_Berufsgruppen.Text + "/" + toolStripCB_Berufe.Text);
                foreach(DirectoryInfo dber in dberufe.GetDirectories())
                {
                    if(dber.Name != "Grobziele")
                    {
                        toolStripCB_Klasse.Items.Add(dber.Name);
                    }
                }
                toolStripCB_Klasse.Text = "Wähle eine Klasse";
                this.Text = "Noch keine Ausbildungsgruppe ausgewählt!";
                toolStripCB_Klasse.Visible = true;
            }
        }

        private void toolStripCB_Klasse_TextChanged(object sender, EventArgs e)
        {
            if(toolStripCB_Klasse.Text != "Wähle eine Klasse" && toolStripCB_Klasse.Text.Length > 1)
            {
                panel_main.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width * -1), 0);
                this.Text = "Gewählte Ausbildungsgruppe: " + toolStripCB_Berufsgruppen.Text + " - " + toolStripCB_Klasse.Text;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            machmalraus();         
        }
    }
}
