using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) //获取选择的内容
            {
                case "加密工具(Encryption)": Encryption dnc = new Encryption();dnc.Show(); break;
                case "解密工具(Decryption)": Decryption enc = new Decryption();enc.Show(); break;
                //Form名称不小心弄反了（？！）
                default:
                    MessageBox.Show("前请选择要启动的组件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About about_page = new About();
            about_page.Show();
        }
    }
}
