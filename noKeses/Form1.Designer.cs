namespace noKeses
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bezar = new System.Windows.Forms.Label();
            this.beallitasok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jora = new System.Windows.Forms.Label();
            this.kora = new System.Windows.Forms.Label();
            this.keszen = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.perc = new System.Windows.Forms.Label();
            this.masodperc = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ertesito = new System.Windows.Forms.NotifyIcon(this.components);
            this.dc = new System.Windows.Forms.PictureBox();
            this.classroom = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.beallitpanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.oravege = new System.Windows.Forms.Label();
            this.koviora = new System.Windows.Forms.Label();
            this.oravegetimer = new System.Windows.Forms.Timer(this.components);
            this.orakezdetetimer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.beallitpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "noKésés";
            // 
            // bezar
            // 
            this.bezar.AutoSize = true;
            this.bezar.BackColor = System.Drawing.Color.Maroon;
            this.bezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bezar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezar.ForeColor = System.Drawing.Color.Red;
            this.bezar.Location = new System.Drawing.Point(286, -1);
            this.bezar.Name = "bezar";
            this.bezar.Size = new System.Drawing.Size(21, 22);
            this.bezar.TabIndex = 2;
            this.bezar.Text = "x";
            this.bezar.Click += new System.EventHandler(this.bezar_Click);
            this.bezar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bezar_MouseDown);
            this.bezar.MouseEnter += new System.EventHandler(this.bezar_MouseEnter);
            this.bezar.MouseLeave += new System.EventHandler(this.bezar_MouseLeave);
            // 
            // beallitasok
            // 
            this.beallitasok.AutoSize = true;
            this.beallitasok.BackColor = System.Drawing.Color.White;
            this.beallitasok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beallitasok.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beallitasok.ForeColor = System.Drawing.Color.Black;
            this.beallitasok.Location = new System.Drawing.Point(196, 0);
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.Size = new System.Drawing.Size(73, 21);
            this.beallitasok.TabIndex = 3;
            this.beallitasok.Text = "Beállítások";
            this.beallitasok.Click += new System.EventHandler(this.beallitasok_Click);
            this.beallitasok.MouseEnter += new System.EventHandler(this.beallitasok_MouseEnter);
            this.beallitasok.MouseLeave += new System.EventHandler(this.beallitasok_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelenlegi óra:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Következő óra:";
            // 
            // jora
            // 
            this.jora.AutoSize = true;
            this.jora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jora.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jora.ForeColor = System.Drawing.Color.White;
            this.jora.Location = new System.Drawing.Point(108, 41);
            this.jora.Name = "jora";
            this.jora.Size = new System.Drawing.Size(40, 21);
            this.jora.TabIndex = 6;
            this.jora.Text = "nincs";
            // 
            // kora
            // 
            this.kora.AutoSize = true;
            this.kora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kora.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kora.ForeColor = System.Drawing.Color.White;
            this.kora.Location = new System.Drawing.Point(108, 62);
            this.kora.Name = "kora";
            this.kora.Size = new System.Drawing.Size(40, 21);
            this.kora.TabIndex = 7;
            this.kora.Text = "nincs";
            // 
            // keszen
            // 
            this.keszen.AutoSize = true;
            this.keszen.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keszen.Location = new System.Drawing.Point(0, 152);
            this.keszen.Name = "keszen";
            this.keszen.Size = new System.Drawing.Size(201, 23);
            this.keszen.TabIndex = 8;
            this.keszen.Text = "Készen állok a következő órára.";
            this.keszen.UseVisualStyleBackColor = true;
            this.keszen.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Megjelenés: Discord/Meet";
            // 
            // nap
            // 
            this.nap.AutoSize = true;
            this.nap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nap.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nap.ForeColor = System.Drawing.Color.White;
            this.nap.Location = new System.Drawing.Point(276, 154);
            this.nap.Name = "nap";
            this.nap.Size = new System.Drawing.Size(20, 21);
            this.nap.TabIndex = 12;
            this.nap.Text = "H";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.BackColor = System.Drawing.Color.White;
            this.ora.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ora.ForeColor = System.Drawing.Color.Black;
            this.ora.Location = new System.Drawing.Point(62, 0);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(28, 21);
            this.ora.TabIndex = 13;
            this.ora.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(88, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // perc
            // 
            this.perc.AutoSize = true;
            this.perc.BackColor = System.Drawing.Color.White;
            this.perc.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.perc.ForeColor = System.Drawing.Color.Black;
            this.perc.Location = new System.Drawing.Point(96, 0);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(28, 21);
            this.perc.TabIndex = 15;
            this.perc.Text = "00";
            this.perc.Click += new System.EventHandler(this.perc_Click);
            // 
            // masodperc
            // 
            this.masodperc.AutoSize = true;
            this.masodperc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.masodperc.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masodperc.ForeColor = System.Drawing.Color.White;
            this.masodperc.Location = new System.Drawing.Point(108, 20);
            this.masodperc.Name = "masodperc";
            this.masodperc.Size = new System.Drawing.Size(28, 21);
            this.masodperc.TabIndex = 16;
            this.masodperc.Text = "00";
            this.masodperc.Click += new System.EventHandler(this.masodperc_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ertesito
            // 
            this.ertesito.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ertesito.BalloonTipText = "A noKésés továbbra is fut a háttérben.";
            this.ertesito.BalloonTipTitle = "noKésés";
            this.ertesito.Icon = ((System.Drawing.Icon)(resources.GetObject("ertesito.Icon")));
            this.ertesito.Text = "A noKésés megnyitásához kattints kétszer.";
            this.ertesito.BalloonTipClicked += new System.EventHandler(this.ertesito_BalloonTipClicked);
            this.ertesito.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ertesito_MouseDoubleClick);
            this.ertesito.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ertesito_MouseMove);
            // 
            // dc
            // 
            this.dc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dc.Image = global::noKeses.Properties.Resources.dc;
            this.dc.Location = new System.Drawing.Point(6, 107);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(43, 35);
            this.dc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dc.TabIndex = 18;
            this.dc.TabStop = false;
            this.dc.Click += new System.EventHandler(this.dc_Click);
            // 
            // classroom
            // 
            this.classroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classroom.Image = global::noKeses.Properties.Resources.classroom;
            this.classroom.Location = new System.Drawing.Point(55, 107);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(39, 35);
            this.classroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.classroom.TabIndex = 17;
            this.classroom.TabStop = false;
            this.classroom.Click += new System.EventHandler(this.classroom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 81);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // beallitpanel
            // 
            this.beallitpanel.Controls.Add(this.label12);
            this.beallitpanel.Controls.Add(this.label8);
            this.beallitpanel.Controls.Add(this.label6);
            this.beallitpanel.Controls.Add(this.pictureBox2);
            this.beallitpanel.Location = new System.Drawing.Point(203, 20);
            this.beallitpanel.Name = "beallitpanel";
            this.beallitpanel.Size = new System.Drawing.Size(107, 92);
            this.beallitpanel.TabIndex = 20;
            this.beallitpanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(8, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "Egyébb";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kilépés";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(9, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Jelzés bug ki";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Óra vége:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(100, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Óra kezdete:";
            // 
            // oravege
            // 
            this.oravege.AutoSize = true;
            this.oravege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oravege.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oravege.ForeColor = System.Drawing.Color.White;
            this.oravege.Location = new System.Drawing.Point(184, 104);
            this.oravege.Name = "oravege";
            this.oravege.Size = new System.Drawing.Size(28, 21);
            this.oravege.TabIndex = 23;
            this.oravege.Text = "00";
            // 
            // koviora
            // 
            this.koviora.AutoSize = true;
            this.koviora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.koviora.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koviora.ForeColor = System.Drawing.Color.White;
            this.koviora.Location = new System.Drawing.Point(184, 125);
            this.koviora.Name = "koviora";
            this.koviora.Size = new System.Drawing.Size(28, 21);
            this.koviora.TabIndex = 24;
            this.koviora.Text = "00";
            // 
            // oravegetimer
            // 
            this.oravegetimer.Interval = 60000;
            this.oravegetimer.Tick += new System.EventHandler(this.oravegetimer_Tick);
            // 
            // orakezdetetimer
            // 
            this.orakezdetetimer.Interval = 60000;
            this.orakezdetetimer.Tick += new System.EventHandler(this.orakezdetetimer_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(210, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "perc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(210, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "perc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 173);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.koviora);
            this.Controls.Add(this.oravege);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.beallitpanel);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.classroom);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.nap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keszen);
            this.Controls.Add(this.kora);
            this.Controls.Add(this.jora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beallitasok);
            this.Controls.Add(this.bezar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.masodperc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "noKésés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.beallitpanel.ResumeLayout(false);
            this.beallitpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bezar;
        private System.Windows.Forms.Label beallitasok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label jora;
        private System.Windows.Forms.Label kora;
        private System.Windows.Forms.CheckBox keszen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label perc;
        private System.Windows.Forms.Label masodperc;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon ertesito;
        private System.Windows.Forms.PictureBox classroom;
        private System.Windows.Forms.PictureBox dc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel beallitpanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label oravege;
        private System.Windows.Forms.Label koviora;
        private System.Windows.Forms.Timer oravegetimer;
        private System.Windows.Forms.Timer orakezdetetimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

