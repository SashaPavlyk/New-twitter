using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPPTwitter.Models;

namespace WFAPPTwitter
{
    public partial class Edit_Form : Form
    {
        User editUser;
        public Edit_Form(User user)
        {
            InitializeComponent();
            editUser = user;
            editNameBox.Text = user.Name;
        }
    }
}
