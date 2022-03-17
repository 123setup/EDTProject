using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace EncryptionTools
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string str = textBox1.Text;
            Stopwatch swt = new Stopwatch();
            Thread.Sleep(100); //为避免软件未加载完成，延时100毫秒
            
            swt.Start();
            int i = 0; int stp = 0; string p = " ";
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = str.Length;
            foreach (var c in str)
            {
                //rebuild codes

                i = c;
                i += 5;
                if (true)     
                {
                    char m = (char)i;   //利用类型强转得到字符
                    p += m.ToString();
                }

                progressBar1.Value += 1;
                stp++;
                label5.Text = "已解密" + stp + "个字符,共计" + str.Length + "个字符";
                this.Refresh();

            }
            label5.Text = "解密完成!";
            textBox2.Text += "解密结果:" + p;
            swt.Stop();
            textBox2.Text += "\r\n" + "用时:" + swt.Elapsed+"\r\n";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "已加密的密码文件 (*.txt)|*.txt"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };

            //var result = openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            textBox3.Text = path;
            //读取
            System.IO.StreamReader st;
            st = new System.IO.StreamReader(textBox3.Text, System.Text.Encoding.UTF8);
            //UTF-8通用编码
            string readstring = st.ReadToEnd();
            string laststring = readstring.Replace("\r\n", "");

            textBox1.Text = laststring;
            
            st.Close();
        }
    }
}
