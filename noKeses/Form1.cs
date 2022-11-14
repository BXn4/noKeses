using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace noKeses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void bezar_MouseEnter(object sender, EventArgs e)
        {
            bezar.BackColor = Color.Red;
            bezar.ForeColor = Color.Maroon;
        }

        private void bezar_MouseLeave(object sender, EventArgs e)
        {
            bezar.BackColor = Color.Maroon;
            bezar.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string napido = DateTime.Now.ToString("ddd");
            nap.Text = napido;
            string oraido = DateTime.Now.ToString("HH");
            ora.Text = oraido;
            string percido = DateTime.Now.ToString("mm");
            perc.Text = percido;
            string masodpercido = DateTime.Now.ToString("ss");
            masodperc.Text = masodpercido;
            if (nap.Text == "H")
            {
                ertesito.Text = ("Jelenleg nincs órád!");
                jora.Text = "Jelenleg nincs órád!";
                kora.Text = "Fizika";
            }
            else if (nap.Text == "K")
            {
                ertesito.Text = ("Jelenleg nincs órád!");
                jora.Text = "Jelenleg nincs órád!";
                kora.Text = "Irodalom";
                timer2.Start();
            }
            else if (nap.Text == "Sze")
            {
                ertesito.Text = ("Jelenleg nincs órád!");
                jora.Text = "Jelenleg nincs órád!";
                kora.Text = "Szakmai";
                timer2.Start();
            }

            else if (nap.Text == "Cs")
            {
                ertesito.Text = ("Jelenleg nincs órád!");
                jora.Text = "Jelenleg nincs órád!";
                kora.Text = "Matek";
                timer2.Start();
            }
            else if (nap.Text == "P")
            {
                ertesito.Text = ("Jelenleg nincs órád!");
                jora.Text = "Jelenleg nincs órád!";
                kora.Text = "Testnevelés";
                timer2.Start();
            }


        }
        // Minek nézed meg a kódot? -.-
        private void timer1_Tick(object sender, EventArgs e)
        {
            string napido = DateTime.Now.ToString("ddd");
            nap.Text = napido;
            string oraido = DateTime.Now.ToString("HH");
            ora.Text = oraido;
            string percido = DateTime.Now.ToString("mm");
            perc.Text = percido;
            string masodpercido = DateTime.Now.ToString("ss");
            masodperc.Text = masodpercido;




            if (perc.Text == "56")
            {
                timer2.Start();
            }
            else if (perc.Text == "01")
            {
                timer2.Start();
            }
            else if (perc.Text == "51")
            {
                timer2.Start();
            }
            else if (perc.Text == "41")
            {
                timer2.Start();
            }
            else if (perc.Text == "46")
            {
                timer2.Start();
            }
            else if (perc.Text == "36")
            {
                timer2.Start();
            }
            else if (perc.Text == "41")
            {
                timer2.Start();
            }
            else if (perc.Text == "31")
            {
                timer2.Start();
            }
            else if (perc.Text == "21")
            {
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ora.Text) >= 15)
            {
                jora.Text = "GAME IS ON!!";
                kora.Text = "Találkozunk holnap!";
                ertesito.Text = ("GAME IS ON");
                ertesito.BalloonTipText = ("Vége a napnak! Találkozunk holnap!");
                ertesito.ShowBalloonTip(100000);
                timer2.Stop();
               
            }

            #region Hétfői nap
            if (nap.Text == "H")
            {

                if (ora.Text == "07" && (perc.Text == "55"))
                {
                    ertesito.Text = ("Jelenleg nincs órád!\nKövetkező óra: Fizika");
                    kora.Text = "Fizika";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                    koviora.Text = "5";
                    orakezdetetimer.Start();

                }
                else if (ora.Text == "08" && (perc.Text == "00"))
                {

                    jora.Text = "Fizika";
                    kora.Text = "Nyelvtan/Töri";
                    ertesito.Text = ("Jelenlegi óra: Fizika\nKövetkező óra: Nyelvtan/Töri");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Fizika!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();


                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "01"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "08" && (perc.Text == "50"))
                {
                    jora.Text = "Fizika";
                    kora.Text = "Nyelvtan";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "08" && (perc.Text == "55"))
                {
                    jora.Text = "Nyelvtan/Töri";
                    kora.Text = "Testnevelés";
                    ertesito.Text = ("Jelenlegi óra: Nyelvtan\nKövetkező óra: Tesi");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Nyelvtan/Töri!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "56"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "09" && (perc.Text == "50"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Tesi\nKövetkező óra: Szakami");
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                }
                else if (ora.Text == "10" && (perc.Text == "40"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "10" && (perc.Text == "45"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Angol";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Angol");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "10" && (perc.Text == "46"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "11" && (perc.Text == "35"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Angol";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "11" && (perc.Text == "40"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Matek";
                    ertesito.Text = ("Jelenlegi óra: Angol\nKövetkező óra: Matek");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Angol!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "11" && (perc.Text == "41"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "12" && (perc.Text == "30"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Matek";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "12" && (perc.Text == "35"))
                {
                    jora.Text = "Matek";
                    kora.Text = "Vége a napnak! GAME IS ON!!";
                    ertesito.Text = ("Jelenlegi óra: Matek\nVége a napnak! GAME IS ON!!");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Matek!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "12" && (perc.Text == "36"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//

                #endregion


            }
            #region Keddi nap
            if (nap.Text == "K")
            {

                if (ora.Text == "07" && (perc.Text == "55"))
                {
                    kora.Text = "Irodalom";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                    koviora.Text = "5";
                    orakezdetetimer.Start();

                }
                else if (ora.Text == "08" && (perc.Text == "00"))
                {
                    jora.Text = "Irodalom";
                    kora.Text = "Történelem/Nyelvtan";
                    ertesito.Text = ("Jelenlegi óra: Irodalom\nKövetkező óra: Töri/Nyelvtan");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Irodalom!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "01"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "08" && (perc.Text == "50"))
                {
                    jora.Text = "Irodalom";
                    kora.Text = "Történelem/Nyelvtan";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
              

                }
                else if (ora.Text == "08" && (perc.Text == "55"))
                {
                    jora.Text = "Történelem/Nyelvtan";
                    kora.Text = "Angol";
                    ertesito.Text = ("Jelenlegi óra: Töri/Nyelvtan\nKövetkező óra: Angol");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Töri/Nyelvtan!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "56"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "09" && (perc.Text == "45"))
                {
                    jora.Text = "Történelem/Nyelvtan";
                    kora.Text = "Angol";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "09" && (perc.Text == "50"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Testnevelés";
                    ertesito.Text = ("Jelenlegi óra: Angol\nKövetkező óra: Tesi");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Angol!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "10" && (perc.Text == "45"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Tesi\nKövetkező óra: Szakmai");
                    timer2.Start();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                }
                else if (ora.Text == "11" && (perc.Text == "35"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "11" && (perc.Text == "40"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Szakmai");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai(4x)!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "10" && (perc.Text == "46"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//

                else if (ora.Text == "15" && (perc.Text == "00"))
                {
                    jora.Text = "GAME IS ON!!";
                    kora.Text = "Találkozunk holnap!";
                    keszen.Visible = false;
                    ertesito.Text = ("GAME IS ON");
                    ertesito.BalloonTipText = ("Vége a napnak! Találkozunk holnap!");
                    ertesito.ShowBalloonTip(100000);
                    Close();


                }

                #endregion

            }
            #region Szerdai nap
            if (nap.Text == "Sze")
            {

                if (ora.Text == "07" && (perc.Text == "55"))
                {
                    kora.Text = "Szakmai";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                    koviora.Text = "5";
                    orakezdetetimer.Start();

                }
                else if (ora.Text == "08" && (perc.Text == "00"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Irodalom";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Irodalom");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "01"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "08" && (perc.Text == "50"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Irodalom";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "08" && (perc.Text == "55"))
                {
                    jora.Text = "Irodalom";
                    kora.Text = "Irodalom";
                    ertesito.Text = ("Jelenlegi óra: Irodalom\nKövetkező óra: Irodalom");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Irodalom!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Visible = true;
                    oravege.Text = "90";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "56"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "09" && (perc.Text == "50"))
                {
                    jora.Text = "Irodalom";
                    kora.Text = "Testnevelés";
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                }
                else if (ora.Text == "10" && (perc.Text == "45"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                }
                else if (ora.Text == "11" && (perc.Text == "35"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Tesi\nKövetkező óra: Szakmai");
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "11" && (perc.Text == "40"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Angol";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Angol");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "11" && (perc.Text == "41"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "12" && (perc.Text == "30"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Angol";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "12" && (perc.Text == "35"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Történelem";
                    ertesito.Text = ("Jelenlegi óra: Angol\nKövetkező óra: Töri");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Angol!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "12" && (perc.Text == "36"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "13" && (perc.Text == "20"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Történelem";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "13" && (perc.Text == "25"))
                {
                    jora.Text = "Történelem";
                    kora.Text = "Vége a napnak! GAME IS ON!!";
                    ertesito.Text = ("Jelenlegi óra: Töri\nVége a napnak! GAME IS ON");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Töri!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "13" && (perc.Text == "26"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "14" && (perc.Text == "10"))
                {
                    jora.Text = "GAME IS ON!!";
                    kora.Text = "Találkozunk holnap!";
                    ertesito.Text = ("GAME IS ON");
                    ertesito.BalloonTipText = ("Vége a napnak! Találkozunk holnap!");
                    ertesito.ShowBalloonTip(100000);
                    Close();

                }

                #endregion
            }
            #region Csütörtöki nap
            if (nap.Text == "Cs")
            {

                if (ora.Text == "07" && (perc.Text == "55"))
                {
                    kora.Text = "Matek";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                    koviora.Text = "5";
                    orakezdetetimer.Start();

                }
                else if (ora.Text == "08" && (perc.Text == "00"))
                {

                    jora.Text = "Matek";
                    kora.Text = "Matek";
                    ertesito.Text = ("Jelenlegi óra: Matek\nKövetkező óra: Matek");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Matek!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "90";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "01"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "08" && (perc.Text == "50"))
                {
                    jora.Text = "Matek";
                    kora.Text = "Matek";


                }
                else if (ora.Text == "08" && (perc.Text == "55"))
                {
                    jora.Text = "Matek";
                    kora.Text = "Testnevelés";
                    ertesito.Text = ("Jelenlegi óra: Matek\nKövetkező óra: Tesi");
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Visible = true;
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "56"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "09" && (perc.Text == "50"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Osztályfőnöki";
                    ertesito.Text = ("Jelenlegi óra: Tesi\nKövetkező óra: Osztályfőnöki");
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                }

                else if (ora.Text == "10" && (perc.Text == "40"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Osztályfőnöki";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "10" && (perc.Text == "45"))
                {
                    jora.Text = "Osztályfőnöki";
                    kora.Text = "Angol";
                    ertesito.Text = ("Jelenlegi óra: Osztályfőnöki\nKövetkező óra: Angol");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Osztályfőnöki!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Visible = true;
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();
                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "10" && (perc.Text == "46"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "11" && (perc.Text == "35"))
                {
                    jora.Text = "Osztályfőnöki";
                    kora.Text = "Angol";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "11" && (perc.Text == "40"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Történelem";
                    ertesito.Text = ("Jelenlegi óra: Angol\nKövetkező óra: Töri");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Angol!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "11" && (perc.Text == "41"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "12" && (perc.Text == "30"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Történelem";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "12" && (perc.Text == "35"))
                {
                    jora.Text = "Történelem";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Töri\nKövetkező óra: Szakmai");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Töri!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "12" && (perc.Text == "36"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "13" && (perc.Text == "20"))
                {
                    jora.Text = "Történelem";
                    kora.Text = "Szakmai";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "13" && (perc.Text == "25"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Szakmai");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "90";
                    oravegetimer.Start();
                    koviora.Text = "110";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "13" && (perc.Text == "26"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "15" && (perc.Text == "00"))
                {
                    jora.Text = "GAME IS ON!!";
                    kora.Text = "Találkozunk holnap!";
                    ertesito.Text = ("GAME IS ON");
                    ertesito.BalloonTipText = ("Vége a napnak! Találkozunk holnap!");
                    ertesito.ShowBalloonTip(100000);
                    Close();

                }

                #endregion
            }
            #region Pénteki nap
            if (nap.Text == "P")
            {

                if (ora.Text == "08" && (perc.Text == "00"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Fizika";
                    ertesito.Text = ("Jelenlegi óra: Tesi\nKövetkező óra: Fizika");
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();



                }

                else if (ora.Text == "08" && (perc.Text == "50"))
                {
                    jora.Text = "Testnevelés";
                    kora.Text = "Fizika";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }
                else if (ora.Text == "08" && (perc.Text == "55"))
                {
                    jora.Text = "Fizika";
                    kora.Text = "Angol";
                    ertesito.Text = ("Jelenlegi óra: Fizika\nKövetkező óra: Angol");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Fizika!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "08" && (perc.Text == "56"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }
                else if (ora.Text == "09" && (perc.Text == "45"))
                {
                    jora.Text = "Fizika";
                    kora.Text = "Angol";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                }
                else if (ora.Text == "09" && (perc.Text == "50"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Matek";
                    ertesito.Text = ("Jelenlegi óra: Angol\nKövetkező óra: Matek");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Angol!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "09" && (perc.Text == "51"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//

                else if (ora.Text == "10" && (perc.Text == "40"))
                {
                    jora.Text = "Angol";
                    kora.Text = "Matek";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();
                }

                else if (ora.Text == "10" && (perc.Text == "45"))
                {
                    jora.Text = "Matek";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Matek\nKövetkező óra: Szakmai");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Matek!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "45";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "10" && (perc.Text == "46"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//


                else if (ora.Text == "11" && (perc.Text == "35"))
                {
                    jora.Text = "Matek";
                    kora.Text = "Szakmai";
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    keszen.Checked = false;
                    keszen.Visible = true;
                    timer2.Stop();

                }

                else if (ora.Text == "11" && (perc.Text == "40"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Szakmai";
                    ertesito.Text = ("Jelenlegi óra: Szakmai\nKövetkező óra: Szakmai");
                    ertesito.BalloonTipText = ("Jelenlegi óra: Szakmai!!");
                    ertesito.ShowBalloonTip(100000);
                    System.IO.Stream str = Properties.Resources.figyelmeztetes;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();
                    oravege.Text = "90";
                    oravegetimer.Start();
                    koviora.Text = "55";
                    orakezdetetimer.Start();

                    if (keszen.Checked == true)
                    {
                        timer2.Stop();
                    }

                }
                else if (ora.Text == "11" && (perc.Text == "41"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//

                else if (ora.Text == "12" && (perc.Text == "35"))
                {
                    jora.Text = "Szakmai";
                    kora.Text = "Vége a napnak! GAME IS ON!!";
                    koviora.Text = "0";
                    orakezdetetimer.Start();



                }
                else if (ora.Text == "12" && (perc.Text == "36"))
                {
                    keszen.Checked = false;
                    keszen.Visible = false;
                }//
                else if (ora.Text == "13" && (perc.Text == "20"))
                {
                    jora.Text = "GAME IS ON!!";
                    kora.Text = "Találkozunk holnap!";
                    ertesito.Text = ("GAME IS ON");
                    ertesito.BalloonTipText = ("Vége a napnak! Találkozunk holnap!");
                    ertesito.ShowBalloonTip(100000);
                    Close();
                }


                #endregion
            }
        }


        private void bezar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bezar_Click(object sender, EventArgs e)
        {
            Hide();
            ertesito.Visible = true;
            ertesito.ShowBalloonTip(100000);


        }

        private void ertesito_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ertesito.Visible = false;
        }

        private void ertesito_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void masodperc_Click(object sender, EventArgs e)
        {

        }

        private void classroom_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/u/1/h");
        }

        private void dc_Click(object sender, EventArgs e)
        {
            

        }



       

        private void ertesito_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            ertesito.Visible = false;
        }

        private void beallitasok_Click(object sender, EventArgs e)
        {
            beallitpanel.Visible = true;
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            beallitpanel.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult biztoskilepsz = MessageBox.Show("Biztosan beszeretnéd zárni az alkamazást?", "Én a helyedben nem késnék..", MessageBoxButtons.YesNo);
            if (biztoskilepsz == DialogResult.Yes)
            {
                Close();
            }
            else if (biztoskilepsz == DialogResult.No)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
          

        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void perc_Click(object sender, EventArgs e)
        {

        }

        private void oravegetimer_Tick(object sender, EventArgs e)
        {
            int hatralevoido = Convert.ToInt32(oravege.Text) - 1;
            oravege.Text = Convert.ToString(hatralevoido);
            if (oravege.Text == "0")
            {
                oravegetimer.Stop();
            }
        }

        private void orakezdetetimer_Tick(object sender, EventArgs e)
        {
            int hatralevokezdes = Convert.ToInt32(koviora.Text) - 1;
            koviora.Text = Convert.ToString(hatralevokezdes);
            if (koviora.Text == "0")
            {
                orakezdetetimer.Stop();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void beallitasok_MouseEnter(object sender, EventArgs e)
        {
            beallitasok.BackColor = Color.Gainsboro;
        }

        private void beallitasok_MouseLeave(object sender, EventArgs e)
        {
            beallitasok.BackColor = Color.White;
         
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Orange;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Lime;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Orange;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Aqua;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Orange;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            /*egyebbpanel egyebbeal = new egyebbpanel();
            egyebbeal.Show();
            Hide();
            ertesito.Visible = true;
            */
            DialogResult beallit = MessageBox.Show("Ez még nincs kész!");

        }
       
        private void timer3_Tick(object sender, EventArgs e)
        {
          
        }

       
    }
}


