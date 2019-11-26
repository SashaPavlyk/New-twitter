using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPPTwitter.Models;

namespace WFAPPTwitter
{
    public partial class Form1 : Form
    {
        BinaryFormatter bf = new BinaryFormatter();
        User currentuser = new User(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void SetImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddMessage_Click(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            msg.Name = currentuser.Name;
            msg.Msg = textBoxMessage.Text;
            listBoxMessages.Items.Add(msg);
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream("User.bin", FileMode.Create))
            {
                bf.Serialize(fs, list);
            }
        }
    }
}
