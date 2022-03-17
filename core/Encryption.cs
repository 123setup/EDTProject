using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.IO;

namespace EncryptionTools
{
    public partial class Encryption : Form
    {
        string p = "";string n=" ";
        public Encryption()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch swt = new Stopwatch();
            string str = textBox1.Text;

            
            
            
            swt.Start();
            int i=0;int stp = 0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = str.Length;
            foreach (var c in str)
            {
                //rebuild codes
                
                i = c;
                i -= 5;
                if (true)     //若不在这个范围内，则不是字符
                {
                    char m = (char)i;   //利用类型强转得到字符
                    p += m.ToString();
                }
                progressBar1.Value += 1;
                stp++;
                label5.Text = "已加密" + stp + "个字符,共计" + str.Length + "个字符";
                this.Refresh();
            }
            label5.Text = "加密完成!";
            n = p;
            textBox2.Text += "加密结果:"+ p;
            swt.Stop();
            textBox2.Text += "\r\n" + "用时:" + swt.Elapsed+"\r\n";



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            string foldPath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath + @"\";
            }
            textBox3.Text = foldPath;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox3.Text + "/" + textBox4.Text);
            sw.WriteLine(n);
            sw.Flush(); //文件流
            sw.Close(); //最后要关闭写入状态
            MessageBox.Show("保存成功！","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
    
}
