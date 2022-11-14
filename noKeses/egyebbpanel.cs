using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noKeses
{
    public partial class egyebbpanel : Form
    {
        public egyebbpanel()
        {
            InitializeComponent();
            
        }
        Form1 Form1 = new Form1();
      

        private void egyebbpanel_Load(object sender, EventArgs e)
        {

           
        }

        private void egyebbpanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
            Form1.Show();
            Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
          
            
        }
      
     
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           

        }
    }
}
