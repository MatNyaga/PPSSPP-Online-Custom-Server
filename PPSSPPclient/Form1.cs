using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPSSPPclient
{
    public partial class Form1 : Form
    {
        string name;
        public Form1()
        {
            InitializeComponent();
            name = "Mat";
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            //Equate string message to Chattb Textbox
            string message = chattb.Text;
            int i = 0;
            //check and see if it is multilined
            if (message.Contains("\n"))
            {
                //array to sore multi lined text
                string[] multline = null;
                //separate each line into a separate string
                while (message.Contains("\n"))
                {   
                    int line = message.IndexOf("\n");
                    message.Substring(0, line);
                    multline[0] = "real";

                }
                
            }
            else
            {
                sendtext(message);
            }
            
        }
        public void sendtext(string message)
        {
            chatlb.Items.Add(name +": "+ message);  
        }

    }
}
