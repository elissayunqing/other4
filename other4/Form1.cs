using Microsoft.Win32;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace other4
{
    public partial class Form1 : Form
    {
        private string[] connectType = { "SerialPort" };
        private int[] serialBaud = { 300, 600, 1200, 2400, 4800, 9600, 14400, 38400, 56000, 57600, 115200, 128000, 230400, 25600 };
        private int[] serialDataBit = { 5, 6, 7, 8 };
        private double[] serialStopBitCbb = { 1, 1.5, 2 };
        private StopBits[] serialStopBit = { StopBits.One, StopBits.OnePointFive, StopBits.Two };
        private string[] serialParityCbb = { "None Parity", "Odd Parity", "Even Parity" };//odd 奇校验 Even偶校验
        private Parity[] serialParity = { Parity.None, Parity.Odd, Parity.Even };

        private SerialPort m_serialPort = null;
        private ModbusSerialMaster m_serialMaster;

        private bool isTransPortConnect = false;


        public ushort[] ModubsRegisters;
        public ushort[] ModubsRegisters2;

        public ushort[] temperature_Registers;
        public ushort[] temperature_Registers2;

        DataBase dataBase = new DataBase();


        int i;
        int i2;







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_serialPort = new SerialPort();//实例化

            connectType_cbb.DataSource = connectType;

            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            if (keyCom != null)
            {
                string[] subKeys = keyCom.GetValueNames();//获取所有存在的串口号并以数组暂存

                serialPort_cbb.Items.Clear();             //循环将端口信息添加到cobport中
                foreach (string name in subKeys)
                {
                    string sValue = (string)keyCom.GetValue(name);
                    serialPort_cbb.Items.Add(sValue);
                }
                serialPort_cbb.SelectedIndex = 0;
            }

            foreach (int band in serialBaud)
            {
                serialBaud_cbb.Items.Add(band + " 波特率");
            }
            serialBaud_cbb.SelectedIndex = 5;

            foreach (int databit in serialDataBit)
            {
                serialDatabit_cbb.Items.Add(databit + "数据位");
            }
            serialDatabit_cbb.SelectedIndex = 3;

            foreach (string parity in serialParityCbb)
            {
                serialParity_cbb.Items.Add(parity + "校验位");
            }
            serialParity_cbb.SelectedIndex = 2;

            foreach (double stopBit in serialStopBitCbb)
            {
                serialStopbit_cbb.Items.Add(stopBit + "停止位");
            }
            serialStopbit_cbb.SelectedIndex = 0;


            richTextBox1.Text = "软件初始化成功!";


            
            timer1.Start();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connectType_cbb.Text == connectType[0])
            {
                if (!m_serialPort.IsOpen)
                {
                    try
                    {
                        m_serialPort.PortName = serialPort_cbb.Text;
                        m_serialPort.BaudRate = serialBaud[serialBaud_cbb.SelectedIndex];
                        m_serialPort.DataBits = serialDataBit[serialDatabit_cbb.SelectedIndex];
                        m_serialPort.StopBits = serialStopBit[serialStopbit_cbb.SelectedIndex];
                        m_serialPort.Parity = serialParity[serialParity_cbb.SelectedIndex];

                        m_serialPort.Open();
                        if (RTU_rbtn.Checked)
                        {
                            m_serialMaster = ModbusSerialMaster.CreateRtu(m_serialPort);
                        }
                        if (ASCII_rbtn.Checked)
                        {
                            m_serialMaster = ModbusSerialMaster.CreateAscii(m_serialPort);
                        }

                        m_serialMaster.Transport.Retries = 2;
                        m_serialMaster.Transport.WriteTimeout = 2000;
                        m_serialMaster.Transport.ReadTimeout = 2000;

                        connect_btn.Text = "断开";
                        isTransPortConnect = true;
                        richTextBox1.Clear();
                        richTextBox1.Text = $"串口{m_serialPort.PortName}已经连接";

                    }
                    catch (Exception)
                    {

                        MessageBox.Show(this, "串口被占用", "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        if (m_serialPort.IsOpen)
                        {
                            m_serialPort.Close();
                            isTransPortConnect = false;
                        }
                        connect_btn.Text = "连接";


                        richTextBox1.Clear();
                        richTextBox1.Text = $"串口{m_serialPort.PortName}已经断开";
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ushort[] temperature_Registers = { 0 };
                temperature_Registers = m_serialMaster.ReadHoldingRegisters(GetSlaveAdress(), 5, 2);

                MessageBox.Show("成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte GetSlaveAdress()
        {
            return Convert.ToByte(TB_SlaveAdress.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒fff毫秒");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ushort[] ModubsRegisters = { 0 };
            i++;
            string a = i.ToString();

            ModubsRegisters = m_serialMaster.ReadHoldingRegisters(GetSlaveAdress(), 8, 2);
            textBox1.Text = (((ulong)ModubsRegisters[0]) << 16 | ModubsRegisters[1]).ToString();

            string sql = $"insert into table_LStrd values('{label4.Text}','{textBox1.Text}')";
            dataBase.Execute(sql);

            richTextBox1.Text = label4.Text + ":写入数据库成功!" + a;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "开始计时写入数据库")
            {
                try
                {
                    timer2.Interval = Convert.ToInt32(textBox8.Text);
                    button2.Text = "停止写入";
                    timer2.Start();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                button2.Text = "开始计时写入数据库";
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                i2++;
                string a2 = i2.ToString();


                
                
                temperature_Registers = m_serialMaster.ReadHoldingRegisters(GetSlaveAdress(), 2, 1);
                temperature_Registers2 = m_serialMaster.ReadHoldingRegisters(GetSlaveAdress(), 11, 1);





                richTextBox1.Text = label4.Text + "\n:读取成功!" + a2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "定时读取")
            {
                try
                {
                    timer3.Interval = Convert.ToInt32(textBox10.Text);
                    button3.Text = "停止读取";
                    timer3.Start();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                button2.Text = "定时读取";
                timer3.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] a = new string[3];
            a[0] = "2022年.03月.23日10时.55分.35秒.906毫秒";
            a[1] = "2022年.03月.23日10时.55分.40秒.940毫秒";
            a[2] = "2022年.03月.23日10时.56分.00秒.857毫秒";


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true); //新建一张excel工作簿 s
            excel.Cells[1, 2] = "时间";

            bool isContains2;

            foreach  (string item in a)
            {
                if(isContains2 = item.Contains("55分"))
                {
                    richTextBox1.Text = item;
                }
            }

            excel.Visible = true;


        }
    }
}
