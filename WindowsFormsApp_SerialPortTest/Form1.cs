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

        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
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
            System.Threading.Thread.Sleep(10);//delay 100ms for waitting data received

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

        private void btnBuildClock_Click(object sender, EventArgs e)
        {
            string prefix = "<00|00|";
            string sendClockData = "";

            btnCleanData_Click_1(sender, e);
            sendClockData = prefix + tbxSendHours.Text.Trim() + "." + tbxSendMinutes.Text.Trim() + "." + tbxSendSeconds.Text.Trim() + ">\n";
            tbxSendData.Text = sendClockData;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "show")
            {
                btnAction.Text = "reset";

                System.Threading.Thread.Sleep(1000);

                PC0_0.Text = "Master";
                PC0_1.Text = "Master";
                PC1_0.Text = "Slave";
                PC1_1.Text = "Master";
                PC2_0.Text = "Slave";
                PC2_1.Text = "Passive";
                PC3_0.Text = "Slave";
                PC3_1.Text = "Master";
            }

            else
            {
                btnAction.Text = "show";

                PC0_0.Text = "";
                PC0_1.Text = "";
                PC1_0.Text = "";
                PC1_1.Text = "";
                PC2_0.Text = "";
                PC2_1.Text = "";
                PC3_0.Text = "";
                PC3_1.Text = "";
            }
        }

        private void arrowReset()
        {
            pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
            pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
            pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
            pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
            pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
            pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
            pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
            pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;

        }

        private void cbxPC1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxPC3.Checked == true && cbxPC1.Checked == true)
            {
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
            }
            else if (cbxPC3.Checked == false || cbxPC1.Checked == false)
            {
                arrowReset();
            }
            else
            {
                arrowReset();
            }
        }



        private void cbxCut0_3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPC1.Checked == true || cbxPC0.Checked == true)
            {
                if (cbxPC1.Checked == true && cbxCut0_3.Checked == true)
                {
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC0.Checked == true && cbxCut0_3.Checked == true)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(800);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC1.Checked == true && cbxCut0_3.Checked == false)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;

                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    pictureBox12.Image = null;
                    pictureBox13.Image = null;
                }
                else if (cbxPC0.Checked == true && cbxCut0_3.Checked == false)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;

                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox12.Image = null;
                    pictureBox6.Image = null;
                    pictureBox11.Image = null;
                    pictureBox13.Image = null;
                }
            }
        }

        private void cbxCut1_0_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPC1.Checked == true && cbxCut1_0.Checked == true)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_right_arrow;
                pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_left_arrow;
                pictureBox8.Image = null;
                pictureBox9.Image = null;

                Delay(500);
                pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                Delay(500);
                pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
            }
            else if (cbxPC1.Checked == true && cbxCut1_0.Checked == false)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;

                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
            }
        }

        private void cbxPC0_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPC3.Checked == true && cbxPC0.Checked == true)
            {
                cbxCut1_0.Enabled = false;
                cbxCutBoth1_0.Enabled = false;

                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
            }
            else if (cbxPC3.Checked == false || cbxPC1.Checked == false)
            {
                cbxCut1_0.Enabled = true;
                cbxCutBoth1_0.Enabled = true;
                arrowReset();
            }
            else
            {
                cbxCut1_0.Enabled = true;
                cbxCutBoth1_0.Enabled = true;
                arrowReset();
            }
        }

        private void cbxCutBoth1_0_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCut1_0.Checked == true && cbxPC1.Checked == true && cbxCutBoth1_0.Checked == true)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_right_arrow;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;

                Delay(500);
                pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                Delay(500);
                pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
            }
            else if(cbxCut1_0.Checked == true && cbxPC1.Checked == true && cbxCutBoth1_0.Checked == false)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_right_arrow;
                pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_left_arrow;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;

                Delay(500);
                pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                Delay(500);
                pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
            }
            else if (cbxCut1_0.Checked == false && cbxPC1.Checked == true && cbxCutBoth1_0.Checked == true)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_right_arrow;
                pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_left_arrow;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;

                Delay(500);
                pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                Delay(500);
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                Delay(500);
                pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                Delay(500);
                pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                Delay(500);
            }
            else if (cbxCut1_0.Checked == false && cbxPC1.Checked == true && cbxCutBoth1_0.Checked == false)
            {
                pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;

                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
            }
        }

        private void cbxCutBoth0_3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPC1.Checked == true || cbxPC0.Checked == true)
            {
                if (cbxPC1.Checked == true && cbxCut0_3.Checked == true && cbxCutBoth0_3.Checked == true)
                {
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    pictureBox12.Image = null;
                    pictureBox13.Image = null;
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC1.Checked == true && cbxCut0_3.Checked == true && cbxCutBoth0_3.Checked == false)
                {
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    pictureBox12.Image = null;
                    pictureBox13.Image = null;
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC1.Checked == true && cbxCut0_3.Checked == false && cbxCutBoth0_3.Checked == true)
                {
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    Delay(500);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC1.Checked == true && cbxCut0_3.Checked == false && cbxCutBoth0_3.Checked == false)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;

                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    pictureBox12.Image = null;
                    pictureBox13.Image = null;
                }
                else if(cbxPC0.Checked == true && cbxCut0_3.Checked == true && cbxCutBoth0_3.Checked == true)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_up_arrow;
                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox12.Image = null;
                    pictureBox6.Image = null;
                    pictureBox11.Image = null;
                    pictureBox13.Image = null;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(800);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC0.Checked == true && cbxCut0_3.Checked == true && cbxCutBoth0_3.Checked == false)
                {
                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox12.Image = null;
                    pictureBox6.Image = null;
                    pictureBox11.Image = null;
                    pictureBox13.Image = null;

                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.gray_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(800);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC0.Checked == true && cbxCut0_3.Checked == false && cbxCutBoth0_3.Checked == true)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.red_up_arrow;

                    Delay(500);
                    pictureBox12.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox10.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;
                    Delay(500);
                    pictureBox7.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                    Delay(800);
                    pictureBox6.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_right_arrow;
                    Delay(500);
                    pictureBox11.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    Delay(500);
                    pictureBox13.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_left_arrow;
                }
                else if (cbxPC0.Checked == true && cbxCut0_3.Checked == false && cbxCutBoth0_3.Checked == false)
                {
                    pictureBox8.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_down_arrow;
                    pictureBox9.Image = WindowsFormsApp_SerialPortTest.Properties.Resources.green_up_arrow;

                    pictureBox7.Image = null;
                    pictureBox10.Image = null;
                    pictureBox12.Image = null;
                    pictureBox6.Image = null;
                    pictureBox11.Image = null;
                    pictureBox13.Image = null;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxPC0.Checked = false;
            cbxPC1.Checked = false;
            cbxCutBoth0_3.Checked = false;
            cbxCut0_3.Checked = false;
            cbxCutBoth1_0.Checked = false;
            cbxCut1_0.Checked = false;

            arrowReset();
        }
    }
}
