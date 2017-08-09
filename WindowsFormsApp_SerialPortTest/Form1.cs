using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp_SerialPortTest
{
    public partial class Form1 : Form
    {
        SerialPort sp = null;//declare a serialport class
        bool isOpen = false;//serialport openning flag
        bool isSetProperty = false;//property setting flag
        bool isHex = false;//hex setting flag
        

        public Form1()
        {
            InitializeComponent();
        }


/*        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 10; i++) //max ten COMs
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;

            //list paud rate
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 5;

            //list stop bits
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;

            //list data bits
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;

            //list parity
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;

            //default show 'Char'
            rbnChar.Checked = true;
        }
*/

/*       private void btnCheckCOM_Click(object sender, EventArgs e)//checking which serialports is available
        {
            bool comExistence = false;//serialport flag is available
            cbxCOMPort.Items.Clear();//clear
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch(Exception)
                {
                    continue;
                }
            }
            if(comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;//show the first one in the listbox 
            }
            else
            {
                MessageBox.Show("没有找到可用串口", "错误提示");
            }
        }
*/

        private bool CheckPortSetting()//checking port is setting or not
        {
            if (cbxCOMPort.Text.Trim() == "")
                return false;
            if (cbxBaudRate.Text.Trim() == "")
                return false;
            if (cbxDataBits.Text.Trim() == "")
                return false;
            if (cbxParity.Text.Trim() == "")
                return false;
            if (cbxStopBits.Text.Trim() == "")
                return false;

            return true;
        }

        private bool CheckSendData()
        {
            if (tbxSendData.Text.Trim() == "")
                return false;
            return true;
        }

        private void SetPortProperty()
        {
            sp = new SerialPort();


            sp.PortName = cbxCOMPort.Text.Trim();//setting serial port name
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//setting baud rate

            //setting stop bits
            float f = Convert.ToSingle(cbxStopBits.Text.Trim());
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 1)
            {
                sp.StopBits = StopBits.One;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }

            //setting data bits
            sp.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());

            //setting parity
            string s = cbxParity.Text.Trim();
            if (s.CompareTo("无") == 0)
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }

            //setting read time out
            sp.ReadTimeout = -1;

            sp.RtsEnable = true;

            //define DataReceived event,when the serial port receive data trigged
            sp.DataReceived += new SerialDataReceivedEventHandler(tbxRecvData_TextChanged);
            if (rbnHex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        //send data
/*        private void btnSend_Click(object sender, EventArgs e)
        {
            //write
            if (isOpen)
            {
                try
                {
                    sp.WriteLine(tbxSendData.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
                return;
            }

            //checking senddata
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据", "错误提示");
                return;
            }
        }
*/

/*        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if(!CheckPortSetting())
                {
                    MessageBox.Show("串口未设置", "错误提示");
                    return;
                }
                if(!isSetProperty)
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCOM.Text = "close";
                    //serial port setting is unavailable when the port is openned
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch(Exception)
                {
                    //flag will be canceled when opening port failled
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用", "错误提示");
                }
            }
            else
            {
                try
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCOM.Text = "open";
                    //serial port setting is available when the port is closed
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParity.Enabled = true;
                    cbxStopBits.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误","错误提示");
                }
            }            
        }
*/

/*        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);//delay 100ms for waitting data received

            //this.invoke是跨线程访问UI的方法，也是本文范例
            this.Invoke((EventHandler)(delegate
            {
                if (isHex == false)
                {
                    tbxRecvData.Text += sp.ReadLine();
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];//creat received data array
                    sp.Read(ReceivedData, 0, ReceivedData.Length);//read received data
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }
                    tbxRecvData.Text += RecvDataText;
                }
                sp.DiscardInBuffer();//丢弃接受缓冲区数据


            }));
        }*/


/*        private void btnCleanData_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
        }
*/

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 10; i++) //max ten COMs
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;

            //list paud rate
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 5;

            //list stop bits
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;

            //list data bits
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;

            //list parity
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;

            //default show 'Char'
            rbnChar.Checked = true;
        }

        private void btnCheckCOM_Click_1(object sender, EventArgs e)
        {
            bool comExistence = false;//serialport flag is available
            cbxCOMPort.Items.Clear();//clear
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;//show the first one in the listbox 
            }
            else
            {
                MessageBox.Show("没有找到可用串口", "错误提示");
            }
        }

        private void btnOpenCOM_Click_1(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())
                {
                    MessageBox.Show("串口未设置", "错误提示");
                    return;
                }
                if (!isSetProperty)
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try
                {
                    sp.Open();
                    isOpen = true;
                    btnOpenCOM.Text = "close";
                    //serial port setting is unavailable when the port is openned
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch (Exception)
                {
                    //flag will be canceled when opening port failled
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用", "错误提示");
                }
            }
            else
            {
                try
                {
                    sp.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCOM.Text = "open";
                    //serial port setting is available when the port is closed
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParity.Enabled = true;
                    cbxStopBits.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误", "错误提示");
                }
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            //write
            if (isOpen)
            {
                try
                {
                    sp.WriteLine(tbxSendData.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
                return;
            }

            //checking senddata
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据", "错误提示");
                return;
            }
        }

        private void btnCleanData_Click_1(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
        }

        private void tbxRecvData_TextChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(100);//delay 100ms for waitting data received

            //this.invoke是跨线程访问UI的方法，也是本文范例
            this.Invoke((EventHandler)(delegate
            {
                if (isHex == false)
                {
                    tbxRecvData.Text += sp.ReadLine();
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];//creat received data array
                    sp.Read(ReceivedData, 0, ReceivedData.Length);//read received data
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }
                    tbxRecvData.Text += RecvDataText;
                }
                sp.DiscardInBuffer();//丢弃接受缓冲区数据


            }));
        }

        private void ModelShow_Click(object sender, EventArgs e)
        {
            PC0_0.Text = "Slave";
        }
    }
}
