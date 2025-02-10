using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
namespace TestSerilog
{
    public partial class Form1 : Form
    {
        Dictionary<string, Label> dictionary = new Dictionary<string, Label>();
        public enum WarningType
        {
            On = 0x21,
            Off = 0x41,
            fail = 0xFF
        }
        public Form1()
        {
            InitializeComponent();
            Label label1 = new Label() { 
            Text = "label1",
            };
            Label label2 = new Label()
            {
                Text = "label2",
            };
            dictionary.Add("No0",label1);
            dictionary.Add("No1", label2);


            tlp_Vision.Controls.Add(dictionary["No0"]);
            tlp_Vision.Controls.Add(dictionary["No1"]);


           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte k = Convert.ToByte("0xFF");
            Console.WriteLine(k);
            Log.Error("Long Dep trai", "1 khong 2");
        }
    }
}
