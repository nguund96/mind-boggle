using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MindBoggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ss = 0, mm = 0, hh = 0, _Size = 0;
        Button[,] Buttons;
        TimeSpan[] ts = new TimeSpan[3];

        private void tm_Time_Tick(object sender, EventArgs e)
        {
            ss++;
            if (ss == 60)
            {
                ss = 0; mm++;
            }
            if (mm == 60)
            {
                mm = 0; hh++;
            }
            string str = (hh > 9 ? hh.ToString() : ("0" + hh.ToString())) + ":" + (mm > 9 ? mm.ToString() : ("0" + mm.ToString())) + ":" + (ss > 9 ? ss.ToString() : ("0" + ss.ToString()));
            TSSL_Time.Text = "Time: " + str;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Data.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                for (int i = 0; i < 3; i++)
                {
                    string str = sr.ReadLine();
                    string[] mang = str.Split(':');
                    ts[i] = new TimeSpan(Convert.ToInt32(mang[0]), Convert.ToInt32(mang[1]), Convert.ToInt32(mang[2]));
                }
                sr.Close();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu!", "Thông báo");
            }
        }
        public void CreateTable()
        {
            ss = mm = hh = 0;
            TSSL_Time.Text = "Time: 00:00:00";
            pnl_Control.Controls.Clear();
            int x = 0, y = 0, dem = 1;
            int Width_Height_Button = pnl_Control.Width / _Size;
            Buttons = new Button[_Size, _Size];
            for (int i = 0; i < _Size; i++)
            {
                for (int j = 0; j < _Size; j++)
                {
                    Buttons[i, j] = new Button();
                    Buttons[i, j].Click += new System.EventHandler(this.Button_Click);
                    Buttons[i, j].Width = Buttons[i, j].Height = Width_Height_Button;
                    Buttons[i, j].BackColor = Color.SkyBlue;
                    Buttons[i, j].Text = dem.ToString();
                    Buttons[i, j].Name = dem.ToString();
                    dem++;
                }
            }
            for (int i = 0; i < _Size; i++)
            {
                x = 0;
                y = i * Width_Height_Button;
                for (int j = 0; j < _Size; j++)
                {
                    x = j * Width_Height_Button;
                    Point p = new Point(x, y);
                    Buttons[i, j].Location = p;
                    pnl_Control.Controls.Add(Buttons[i, j]);
                }
            }
            tm_Time.Start(); //Bắt đầu chơi
        }
        public void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Button Top = GetButton_Top(b), Bot = GetButton_Bot(b), Left = GetButton_Left(b), Right = GetButton_Right(b);
            if (Top != null && Bot != null && Left != null && Right != null)
            {
                if (b.BackColor == Color.Red)
                {
                    if (Top.BackColor == Color.Red && Bot.BackColor == Color.Red && Left.BackColor == Color.Red && Right.BackColor == Color.Red)
                    {
                        Top.BackColor = Color.SkyBlue;
                        Bot.BackColor = Color.SkyBlue;
                        Left.BackColor = Color.SkyBlue;
                        Right.BackColor = Color.SkyBlue;
                        b.BackColor = Color.SkyBlue;
                    }
                }
                else
                {
                    if (Top.BackColor == Color.SkyBlue && Bot.BackColor == Color.SkyBlue && Left.BackColor == Color.SkyBlue && Right.BackColor == Color.SkyBlue)
                    {
                        Top.BackColor = Color.Red;
                        Bot.BackColor = Color.Red;
                        Left.BackColor = Color.Red;
                        Right.BackColor = Color.Red;
                        b.BackColor = Color.Red;
                    }
                }
            }
            if(Win())
            {
                SaveData();
                pnl_Control.Enabled = false;
                tm_Time.Stop();
                MessageBox.Show("You Winner!");
                Form1_Load(this, new EventArgs());
            }
        }
        public bool Win()
        {
            for (int i = 0; i < _Size; i++)
            {
                for (int j = 0; j < _Size; j++)
                {
                    if (Buttons[i, j].BackColor == Color.SkyBlue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void SaveData()
        {
            FileStream fs = new FileStream("Data.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);

            TimeSpan t = new TimeSpan(hh, mm, ss);
            if(_Size == 5)
            {
                if(ts[0] < t)
                {
                    ts[0] = t;
                }
            }
            else if(_Size == 10)
            {
                if (ts[1] < t)
                {
                    ts[1] = t;
                }
            }
            else if(_Size == 15)
            {
                if (ts[2] < t)
                {
                    ts[2] = t;
                }
            }

            sw.WriteLine(ts[0].ToString());
            sw.WriteLine(ts[1].ToString());
            sw.WriteLine(ts[2].ToString());
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public Button GetButton_Left(Button b)
        {
            int STT = Convert.ToInt32(b.Text);
            int STT_Left = 0;
            if (STT % _Size == 1) //Button b ở lề bên trái
            {
                STT_Left = STT + _Size - 1;
            }
            else
            {
                STT_Left = STT - 1;
            }
            foreach (Button bt in Buttons)
            {
                if (Convert.ToInt32(bt.Text) == STT_Left)
                {
                    return bt;
                }
            }
            return null;
        }
        public Button GetButton_Right(Button b)
        {
            int STT = Convert.ToInt32(b.Text);
            int STT_Right = 0;
            if (STT % _Size == 0) //Button b ở lề bên phải
            {
                STT_Right = STT - _Size + 1;
            }
            else
            {
                STT_Right = STT + 1;
            }
            foreach (Button bt in Buttons)
            {
                if (Convert.ToInt32(bt.Text) == STT_Right)
                {
                    return bt;
                }
            }
            return null;
        }
        public Button GetButton_Top(Button b)
        {
            int STT = Convert.ToInt32(b.Text);
            int STT_Top = 0;
            if ((STT - _Size) <= 0) //Button b ở lề bên trên
            {
                STT_Top = STT + _Size * (_Size - 1);
            }
            else
            {
                STT_Top = STT - _Size;
            }
            foreach (Button bt in Buttons)
            {
                if (Convert.ToInt32(bt.Text) == STT_Top)
                {
                    return bt;
                }
            }
            return null;
        }
        public Button GetButton_Bot(Button b)
        {
            int STT = Convert.ToInt32(b.Text);
            int STT_Bot = 0;
            if ((STT + _Size) > _Size * _Size) //Button b ở lề bên dưới
            {
                STT_Bot = STT - _Size * (_Size - 1);
            }
            else
            {
                STT_Bot = STT + _Size;
            }
            foreach (Button bt in Buttons)
            {
                if (Convert.ToInt32(bt.Text) == STT_Bot)
                {
                    return bt;
                }
            }
            return null;
        }
        private void TSMI_05_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            _Size = Convert.ToInt32(item.Name.Substring(5));
            CreateTable();
            pnl_Control.Enabled = true;
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TSMI_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mind Boggle\nNguyễn Đức Ngưu, ĐH SPKT TPHCM\n1.0.0", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5x5:     " + ts[0].ToString() + "\n10x10: " + ts[1].ToString() + "\n15x15: " + ts[2].ToString());
        }

    }
}
