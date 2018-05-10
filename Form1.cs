using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_unit_change
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int beChangeData = Convert.ToInt32(beChangeValue.Text);
            int dpiData = Convert.ToInt32(dpi.Text);
            double resultData = 0;
            switch (beChangeUnit.Text)
            {
                case "px":
                    switch (resultUnit.Text)
                    {
                        case "px":
                            resultData = beChangeData;
                            break;

                        case "dp":
                            resultData = beChangeData / (dpiData / 160f);
                            break;
                    }
                    break;

                case "dp":
                    switch (resultUnit.Text)
                    {
                        case "px":
                            resultData = beChangeData * (dpiData / 160f);
                            break;

                        case "dp":
                            resultData = beChangeData;
                            break;
                    }
                    break;
            }
            resultValue.Text = Convert.ToInt32(resultData).ToString();
        }
    }
}
