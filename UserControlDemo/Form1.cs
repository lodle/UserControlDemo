using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel1 = new UserControl1();
            panel1.Size = PanPlaceHolder.Size;
            Controls.Add(panel1);

            PanPlaceHolder = panel1;
        }

        private void ButUser1_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel1 = new UserControl1();
            panel1.Size = PanPlaceHolder.Size;
            Controls.Add(panel1);

            PanPlaceHolder = panel1;
        }

        private void ButUser2_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel2 = new UserControl2();
            panel2.Size = PanPlaceHolder.Size;
            Controls.Add(panel2);

            PanPlaceHolder = panel2;
        }
    }
}
