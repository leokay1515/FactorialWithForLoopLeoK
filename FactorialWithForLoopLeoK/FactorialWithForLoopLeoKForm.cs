using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialWithForLoopLeoK
{
    public partial class frmFactorialWithForLoopLeoK : Form
    {
        public frmFactorialWithForLoopLeoK()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables
            Double facAns;
            Double FacNum;
            int facCount;

            //clear listbox items
            this.lstFacNum.Items.Clear();

            //initial final answer to 1
            facAns = 1;

            //get the num from the user
            FacNum = Convert.ToDouble(this.nudNum.Value);

            //Start looping
            for (facCount = 1; facCount <= FacNum; facCount++)
            {
                //add to the list
                this.lstFacNum.Items.Add(facCount);

                //multiply the counter by the answer
                facAns = facAns * facCount;
            }

            //convert the answer to a string and diplay it
            this.lblAnswer.Text = this.nudNum.Value + "! = " + Convert.ToString(facAns);
        }
    }
}
