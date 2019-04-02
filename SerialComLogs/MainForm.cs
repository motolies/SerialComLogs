using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialComLogs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        SerialPort serialPort = new SerialPort();
        int intTBREST = 1;
        int Port1_Send, Port1_Recieved = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rbAUTO1.Checked)
                SendingMessage(serialPort, btnOPEN, cbTXHEX1, tbSEND1, chkCarriage1);
            else if (rbAUTO2.Checked)
                SendingMessage(serialPort, btnOPEN, cbTXHEX2, tbSEND2, chkCarriage2);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    RecievdDATA();
                }));
            }

        }

        //========================================================================================
        // 데이터 수신 부분
        //========================================================================================
        public void RecievdDATA()
        {
            try
            {
                string RcvData = serialPort.ReadExisting(); // 시리얼에서 들어온 데이터를 집어넣는다.

                if (cbRXHEX.Text == "ASCII")
                {
                    RcvData = RcvData.Replace("\r", "");
                    RcvData = RcvData.Replace("\n", "\r\n");
                    txtReceive.AppendText(RcvData);
                    txtReceive.ScrollToCaret();

                    Port1_Recieved += RcvData.Length;
                    lb_Port1_rcv.Text = Port1_Recieved.ToString();

                    if (Port1_Recieved >= 32760 * intTBREST && intTBREST != 0)
                    {
                        intTBREST++;
                        txtReceive.Text = "";
                    }

                    Update();
                    Application.DoEvents();

                }
                else if (cbRXHEX.Text == "HEX")
                {
                    RcvData = RcvData.Replace("\r", "");
                    RcvData = RcvData.Replace("\n", "\r\n");
                    txtReceive.AppendText(ConvertToHex(RcvData));
                    txtReceive.ScrollToCaret();

                    Port1_Recieved += RcvData.Length;
                    lb_Port1_rcv.Text = Port1_Recieved.ToString();

                    if (Port1_Recieved >= 32760 * intTBREST && intTBREST != 0)
                    {
                        intTBREST++;
                        txtReceive.Text = "";
                    }

                    Update();
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort.DataReceived += SerialPort_DataReceived;
                timer.Tick += Timer_Tick;


                List<String> portList;
                String[] ports = SerialPort.GetPortNames();

                if (ports.Length > 0)
                    portList = ports.ToList();
                else
                {
                    portList = new List<string>();
                    for (int i = 1; i < 31; i++)
                        portList.Add(String.Format("COM", i));
                }

                cbCOMPORT.DataSource = portList;
                btnCLOSE.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("현재 사용할 수 있는 SerialPort가 없습니다.");
            }

        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cbCOMPORT.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBITRATE.Text);
                serialPort.DataBits = Convert.ToInt32(cbDATEBIT.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbPARITY.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbSTOPBIT.Text);
                serialPort.ReadTimeout = (int)500;
                serialPort.WriteTimeout = (int)500;
                serialPort.Open();
                //MessageBox.Show(cbCOMPORT1.Text + "에 접속하였습니다.");
                OPEN_ENABLE(cbBITRATE, cbCOMPORT, cbDATEBIT, cbPARITY, cbSTOPBIT);
                btnOPEN.Enabled = false;
                btnCLOSE.Enabled = true;

            }
            catch
            {
                MessageBox.Show(cbCOMPORT.Text + "접속에 실패하였습니다.");
                btnOPEN.Enabled = true;
                btnCLOSE.Enabled = false;
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                intTBREST = 1;
                CLOSE_ENABLE(cbBITRATE, cbCOMPORT, cbDATEBIT, cbPARITY, cbSTOPBIT);
                btnOPEN.Enabled = true;
                btnCLOSE.Enabled = false;
            }
            catch
            {
                MessageBox.Show(cbCOMPORT.Text + "접속종료에 실패하였습니다.");
                btnOPEN.Enabled = false;
                btnCLOSE.Enabled = true;
            }
        }

        private void btCLEAR_Click(object sender, EventArgs e)
        {
            txtReceive.Clear();
        }





        //========================================================================================
        // 메세지 전송부분
        //========================================================================================
        public void SendingMessage(SerialPort Serial, Button btOPEN, ComboBox chTXHEX, TextBox tbSend, CheckBox chbPORT)
        {
            if (btOPEN.Enabled == true)
            {
                return;
            }
            try
            {
                if (chTXHEX.Text == "ASCII")
                {
                    if (chbPORT.Checked)
                    {
                        string Send = tbSend.Text + "\r\n";
                        Serial.Write(Encoding.Default.GetBytes(Send), 0, Send.Length);

                        Port1_Send += Send.Length;
                        lb_Port1_send.Text = Port1_Send.ToString();

                    }
                    else if (!chbPORT.Checked)
                    {
                        string Send = tbSend.Text;
                        Serial.Write(Encoding.Default.GetBytes(Send), 0, Send.Length);

                        Port1_Send += Send.Length;
                        lb_Port1_send.Text = Port1_Send.ToString();
                    }
                }
                else if (chTXHEX.Text == "HEX")
                {
                    if (chbPORT.Checked)
                    {
                        string Send = ConvertToAscii(tbSend.Text) + "\r\n";
                        Serial.Write(Encoding.Default.GetBytes(Send), 0, Send.Length);

                        Port1_Send += Send.Length;
                        lb_Port1_send.Text = Port1_Send.ToString();
                    }
                    else if (!chbPORT.Checked)
                    {
                        string Send = ConvertToAscii(tbSend.Text);
                        Serial.Write(Encoding.Default.GetBytes(Send), 0, Send.Length);

                        Port1_Send += Send.Length;
                        lb_Port1_send.Text = Port1_Send.ToString();
                    }
                }
            }
            catch
            {
                tbINTERVAL.Enabled = true;
                timer.Stop();
                btnRepeat.Text = "Repeat";

                MessageBox.Show("메세지전송을 실패하였습니다!");
            }
        }



        //========================================================================================
        // 접속 및 종료시 사용권한
        //========================================================================================
        public void OPEN_ENABLE(ComboBox com, ComboBox bitrate, ComboBox databit, ComboBox parity, ComboBox stop)
        {
            Port1_Recieved = 0;
            Port1_Send = 0;

            com.Enabled = false;
            bitrate.Enabled = false;
            databit.Enabled = false;
            parity.Enabled = false;
            stop.Enabled = false;
        }
        public void CLOSE_ENABLE(ComboBox com, ComboBox bitrate, ComboBox databit, ComboBox parity, ComboBox stop)
        {
            Port1_Recieved = 0;
            Port1_Send = 0;

            com.Enabled = true;
            bitrate.Enabled = true;
            databit.Enabled = true;
            parity.Enabled = true;
            stop.Enabled = true;
        }




        //========================================================================================
        // Hex코드 -> 아스키코드
        //========================================================================================
        public string ConvertToAscii(string HexaString)
        {
            string StrValue = "";
            while (HexaString.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexaString.Substring(0, 2), 16)).ToString();
                HexaString = HexaString.Substring(2, HexaString.Length - 2);
            }
            //            StrValue = StrValue.Replace("0d 0a", "\n");
            return StrValue;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOPEN.Enabled == true)
                {
                    return;
                }
                else if (btnOPEN.Enabled == false)
                {
                    if (btnRepeat.Text == "Repeat")
                    {
                        timer.Interval = Convert.ToInt32(tbINTERVAL.Text);
                        tbINTERVAL.Enabled = false;
                        timer.Start();
                        btnRepeat.Text = "Stop";
                    }
                    else if (btnRepeat.Text == "Stop")
                    {
                        tbINTERVAL.Enabled = true;
                        timer.Stop();
                        btnRepeat.Text = "Repeat";
                    }
                }
            }
            catch
            {
                MessageBox.Show("시간에는 1이상의 자연수만 입력해야 합니다.");
            }
        }

        private void btSEND1_Click(object sender, EventArgs e)
        {
            SendingMessage(serialPort, btnOPEN, cbTXHEX1, tbSEND1, chkCarriage1);
        }

        private void btSEND2_Click(object sender, EventArgs e)
        {
            SendingMessage(serialPort, btnOPEN, cbTXHEX2, tbSEND2, chkCarriage2);
        }




        //========================================================================================
        // 아스키코드 -> Hex코드
        //========================================================================================
        public string ConvertToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2} ", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }

    }
}
