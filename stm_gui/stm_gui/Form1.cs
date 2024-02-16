using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stm_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] baud = { "1200", "2400", "9600", "115200" };
        string[] databit = { "5", "6", "7", "8" };
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init graph
            GraphPane mypane = zedGraphControl1.GraphPane;
            mypane.Title.Text = "DHT Data";
            mypane.XAxis.Title.Text = "Time";
            mypane.YAxis.Title.Text = "Value";

            //Initialize 2 array for temp and DH
            RollingPointPairList list1 = new RollingPointPairList(6000);
            RollingPointPairList list2 = new RollingPointPairList(6000);

            //Init 2 line for temp and DH
            LineItem templine = mypane.AddCurve("Temperature", list1, Color.Red, SymbolType.Circle);
            LineItem dhline = mypane.AddCurve("DH", list2, Color.Black, SymbolType.Triangle);

            //Init x, y axis para
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = 100;
            mypane.XAxis.Scale.MinorStep = 1;
            mypane.XAxis.Scale.MajorStep = 5;

            mypane.YAxis.Scale.Min = 0;
            mypane.YAxis.Scale.Max = 100;
            mypane.YAxis.Scale.MinorStep = 1;
            mypane.YAxis.Scale.MajorStep = 5;
            
            zedGraphControl1.AxisChange();

            //Init Serial Settings
            string[] myport = SerialPort.GetPortNames();
            cBoxPortNo.Items.AddRange(myport);
            cBoxBaudrate.Items.AddRange(baud);
            cBoxBaudrate.SelectedIndex = 3;
            cBoxData.Items.AddRange(databit);
            cBoxData.SelectedIndex = 3;
            cBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cBoxParity.SelectedIndex = 0;
            cBoxStopbit.SelectedIndex = 0;
        }

        int sum = 0;
        public void draw(double value, int curveIndex)
        {
            LineItem line = zedGraphControl1.GraphPane.CurveList[curveIndex] as LineItem;

            if (line == null)
                return;

            IPointListEdit list = line.Points as IPointListEdit;

            if (list == null)
                return;

            list.Add(sum, value);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            sum += 2;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            try 
            {
                serialPort1.PortName = cBoxPortNo.Text;
                serialPort1.BaudRate = int.Parse(cBoxBaudrate.Text);
                serialPort1.DataBits = int.Parse(cBoxData.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopbit.Text);
                
                serialPort1.NewLine = "\n"; // Set the newline character(s)
                serialPort1.ReadTimeout = 1000;
                
                serialPort1.Open();

                progressBar1.Value = 100;
                Connect.Enabled = false;
                Disconnect.Enabled = true;

                manual.Enabled = true;
                auto.Enabled = false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    progressBar1.Value = 0;
                    Connect.Enabled = true;
                    Disconnect.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else return;
        }

        private void manual_Click(object sender, EventArgs e)
        {
            serialPort1.Write("M");
            manual.Enabled = false;
            auto.Enabled = true;
        }

        private void auto_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
            manual.Enabled = true;
            auto.Enabled = false;
        }
        char data1;
        string data = "";
        string temp = "";
        string humid = "";
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data1 = (char)serialPort1.ReadChar();
            if (data1 == '\n')
            {
                // Display the received data in the TextBox
                textBox1.Invoke((MethodInvoker)delegate
                {
                    textBox1.AppendText(data + Environment.NewLine);

                    // Scroll to the end of the TextBox
                    textBox1.ScrollToCaret();
                });
                if (data.StartsWith("T"))
                {
                    int index = data.IndexOf("C");
                    temp=data.Substring(12,index-12);
                    Console.WriteLine(temp);
                } 
                if(data.StartsWith("H"))
                {
                    int index = data.IndexOf("%");
                    humid = data.Substring(9, index - 9);
                    
                    Console.WriteLine(humid);
                }

                if (temp != "" && humid != "")
                {
                    Invoke(new MethodInvoker(() => draw(float.Parse(temp), 0)));
                    Invoke(new MethodInvoker(() => draw(float.Parse(humid), 1)));
                }



                data = "";  // Reset the data string for the next message
            }
            else
            {
                data += data1;
                data.Trim();
            }

            

            
            
        }

        
    }


    }


