using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz {
    public partial class frmP2 : Form {
        public frmP2() {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (rbtnRight.Checked) {
                Variaveis_G.Hits += 1;
                MessageBox.Show("Right answer!", "QUIZ");
                frmP3 p3 = new frmP3();
                p3.ShowDialog();
                this.Dispose();
            } else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) {
                Variaveis_G.Mistakes += 1;
                MessageBox.Show("Wrong answer!");
                frmP3 p3 = new frmP3();
                p3.ShowDialog();
                this.Dispose();
            } else {
                MessageBox.Show("Choose an alternative!");
            }
        }
    }
}
