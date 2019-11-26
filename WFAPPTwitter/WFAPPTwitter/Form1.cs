using System;
using System.Drawing;
using System.Windows.Forms;
using WFAPPTwitter.Models;

namespace WFAPPTwitter
{
    public partial class Form1 : Form
    {
        private User user;
        public Form1()
        {
            InitializeComponent();
            user = new User();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{

            //}
            Edit_Form editform = new Edit_Form(user);
            editform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UserPhotoBox.Image = Image.FromFile("/img/unknown.png");

            UserPhotoBox.Image = user.Image;
            UserNameLabel.Text = user.Name;
            UserAgeLabel.Text = user.Age.ToString();

            }
    }
}  

