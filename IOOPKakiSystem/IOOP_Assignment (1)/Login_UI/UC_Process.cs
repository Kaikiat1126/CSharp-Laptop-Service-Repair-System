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
    public partial class UC_Process : UserControl
    {
        public UC_Process()
        {
            InitializeComponent();
            InitEvent();
            InitCursor();
        }

        public dynamic uc_recg_partOne = null;
        public UC_recg_partTwo uc_recg_partTwo = null;
        public UC_recg_partThree uc_recg_partThree = null;

        private void InitEvent()
        {
            label1.Click += new EventHandler(btn1ClickEvent);
            pictureBox1.Click += new EventHandler(btn1ClickEvent);

            label2.Click += new EventHandler(btn2ClickEvent);
            pictureBox2.Click += new EventHandler(btn2ClickEvent);

            label3.Click += new EventHandler(btn3ClickEvent);
            pictureBox3.Click += new EventHandler(btn3ClickEvent);

        }

        public void Unload()
        {
            label1.Click -= new EventHandler(btn1ClickEvent);
            pictureBox1.Click -= new EventHandler(btn1ClickEvent);

            label2.Click -= new EventHandler(btn2ClickEvent);
            pictureBox2.Click -= new EventHandler(btn2ClickEvent);

            label3.Click -= new EventHandler(btn3ClickEvent);
            pictureBox3.Click -= new EventHandler(btn3ClickEvent);


            Label[] labels = { label1, label2, label3 };
            PictureBox[] pictureBox = { pictureBox1, pictureBox2, pictureBox3 };
            foreach (Label label in labels)
            {
                label.Cursor = Cursors.Default;
            }

            foreach (PictureBox pcs in pictureBox)
            {
                pcs.Cursor = Cursors.Default;
            }
        }

        private void InitCursor()
        {
            dynamic[] controls = { InfoContainer.uc_recg_partOne, InfoContainer.uc_recg_partTwo, InfoContainer.uc_recg_partThree };
            Label[] labels = { label1, label2, label3 };
            PictureBox[] pictureBox = { pictureBox1, pictureBox2, pictureBox3 };
            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i] != null)
                {
                    labels[i].Cursor = Cursors.Hand;
                    pictureBox[i].Cursor = Cursors.Hand;
                }
            }
        }

        private void addLine(string type)
        {
            Color color = Color.White;
            if (type =="cus")
            {
                color = Color.FromArgb(203, 243, 240);
            }
            else
            {
                color = Color.FromArgb(255, 191, 105);
            }
            Panel panel = new Panel();
            panel.Size = new Size(384, 2);
            panel.Location = new Point(0, 27);
            panel.BackColor = color;
            this.Controls.Add(panel);
            panel.SendToBack();

        }

        public void Init(string type,int num)
        {
            addLine(type);
            PictureBox[] pics = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            Label[] labels = { label1, label2, label3, label4 };
            Color fontBGC = Color.White;
            Image fullImg = null;
            Image halfImg = null;
            if (type == "cus")
            {
                fullImg = Properties.Resources.fullGreen;
                halfImg = Properties.Resources.halfGreen;
                foreach (Label label in labels)
                {
                    label.BackColor = Color.White;
                }
                fontBGC = Color.FromArgb(46, 192, 182);
            }
            else
            {
                fullImg = Properties.Resources.fullOrange;
                halfImg = Properties.Resources.halfOrange;
                foreach (Label label in labels)
                {
                    label.BackColor = Color.White;
                }
                fontBGC = Color.FromArgb(255, 159, 28);
            }

            foreach (var item in pics)
            {
                item.Image = halfImg;
            }

            for (int i = 0; i < num; i++)
            {
                pics[i].Image = fullImg;
                labels[i].BackColor = fontBGC;
            }
            for (int i = 3; i > num-1; i--)
            {
                labels[i].ForeColor =Color.Black;
            }
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Register.instance.panelContainer.Controls.Clear();
            Register.instance.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn1ClickEvent(object sender, EventArgs e)
        {
            if (InfoContainer.uc_recg_partOne != null)
            {
                addUserControl(InfoContainer.uc_recg_partOne);
            }
            
        }

        private void btn2ClickEvent(object sender, EventArgs e)
        {
            if (InfoContainer.uc_recg_partTwo != null)
            {
                addUserControl(InfoContainer.uc_recg_partTwo);
            }
            
        }

        private void btn3ClickEvent(object sender, EventArgs e)
        {
            if (InfoContainer.uc_recg_partThree != null)
            {
                addUserControl(InfoContainer.uc_recg_partThree);
            }
            
        }
    }
}
