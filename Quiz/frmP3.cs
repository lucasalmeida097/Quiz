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
    public partial class frmP3 : Form {
        public frmP3() {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (rbtnRight.Checked) {
                Variaveis_G.Hits += 1;
                MessageBox.Show("Right answer!", "QUIZ");
                frmP4 p4 = new frmP4();
                p4.ShowDialog();
                this.Dispose();
            } else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) {
                Variaveis_G.Mistakes += 1;
                MessageBox.Show("Wrong answer!");
                frmP4 p4 = new frmP4();
                p4.ShowDialog();
                this.Dispose();
            } else {
                MessageBox.Show("Choose an alternative!");
            }
        }
    }
}
