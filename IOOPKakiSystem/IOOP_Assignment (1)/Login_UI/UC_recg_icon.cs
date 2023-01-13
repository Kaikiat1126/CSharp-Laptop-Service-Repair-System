using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI
{
    public partial class UC_recg_icon : UserControl
    {
        Image bgc;
        Image icon;

        public UC_recg_icon()
        {
            InitializeComponent();
        }

        public void Init(string type, int num)
        {
            if (type =="cus")
            {
                bgc = Properties.Resources.OrangeContainer;
                if (num ==1)
                {
                    icon = Properties.Resources.user;
                }
                else if (num==2)
                {
                    icon = Properties.Resources.doc;
                }
                else if (num == 3)
                {
                    
                    icon = Properties.Resources.address;
                }

                pictureBox2.BackColor = Color.FromArgb(255, 159, 28);
            }
            else
            {

                bgc = Properties.Resources.BlueContainer;
                if (num == 1)
                {
                    icon = Properties.Resources.user;
                }
                else if (num == 2)
                {
                    icon = Properties.Resources.doc;
                }
                else if (num ==3)
                {

                    icon = Properties.Resources.address;
                }

                pictureBox2.BackColor = Color.FromArgb(49, 196, 182);
            }

            pictureBox1.Image = bgc;
            pictureBox2.Image = icon;
        }
    }
}
