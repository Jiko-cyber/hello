using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.CreateSubKey("MyKey");

           string color = (string)myKey.GetValue("Color");
          if (color == "Зеленый")
                BackColor = System.Drawing.Color.LightGreen;
          else if (color =="Розовый")
            BackColor = System.Drawing.Color.LightPink;
          else if (color =="Серый")
            BackColor = System.Drawing.Color.Gray;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
         
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.CreateSubKey("MyKey");

           myKey.SetValue("Color", "Зеленый");
            myKey.Close();
            BackColor = System.Drawing.Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.CreateSubKey("MyKey");

            myKey.SetValue("Color", "Серый");
            myKey.Close();
            BackColor = System.Drawing.Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey myKey = currentUserKey.CreateSubKey("MyKey");
        
           myKey.SetValue("Color", "Розовый");
            myKey.Close();
            BackColor = System.Drawing.Color.LightPink;
        }

        
    }
}
