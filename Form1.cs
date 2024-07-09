using prac1.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac1
{
    public partial class Form1 : Form
    {
        private static CustomList<int> cl = new CustomList<int>(10, 20, 30, 40);
        private static ICustomEnumerator cle = cl.GetEnumerator();

        public Form1()
        {
            InitializeComponent();                        

            Debug.WriteLine(cle.Current);
            cle.MoveNext();
            Debug.WriteLine(cle.Current);
            cle.MoveNext();
            Debug.WriteLine(cle.Current);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cle.MoveNext();
            button1.Text = cle.Current.ToString();
        }
    }
}
