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
    public partial class frmP9 : Form {
        public frmP9() {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (rbtnRight.Checked) {
                Variaveis_G.Hits += 1;
                MessageBox.Show("Right answer!", "QUIZ");
                frmP10 p10 = new frmP10();
                p10.ShowDialog();
                this.Dispose();
            } else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) {
                Variaveis_G.Mistakes += 1;
                MessageBox.Show("Wrong answer!");
                frmP10 p10 = new frmP10();
                p10.ShowDialog();
                this.Dispose();
            } else {
                MessageBox.Show("Choose an alternative!");
            }
        }
    }
}
