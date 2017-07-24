using System;
using System.Windows.Forms;
using RoboclawClassLib;

namespace RoboClawTest01
{
    public partial class Form1 : Form
    {
        private readonly Roboclaw _roboClaw;
        private string _roboClawModel;
        int _m1EncoderCnt, _m2EncoderCount;
        private short _m1Current, _m2Current;
        private double _temperature;
        private double _mainVoltage, _logicVoltage;
        bool _encoderWatch = false;

        static readonly System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            _roboClaw = new Roboclaw();

            MyTimer.Tick += new EventHandler(TimerEventProcessor);  // Timer event and handler
            MyTimer.Interval = 100; // Timer interval is 25 milliseconds
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!_roboClaw.IsOpen())
            {
                _roboClaw.Open("AUTO", ref _roboClawModel, 128, 38400); // Open the interface to the RoboClaw
                labelRoboClawModel.Text = _roboClawModel; // Display the RoboClaw device model number
                _roboClaw.ResetEncoders();
                buttonConnect.Enabled = false;
                buttonGoForward.Enabled = true;
                buttonGoReverse.Enabled = true;
                buttonDisconnect.Enabled = true;
            }
        }

        private void buttonGoForward_Click(object sender, EventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                _roboClaw.ST_M1Forward(100); // Start the motor going forward at power 100
                _roboClaw.ST_M2Forward(100); // Start the motor going forward at power 100
                MyTimer.Start(); // Start timer to show encoder ticks
                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
            }
        }

        private void buttonGoReverse_Click(object sender, EventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                _roboClaw.ST_M1Backward(100); // Start the motor going forward at power 100
                _roboClaw.ST_M2Backward(100); // Start the motor going forward at power 100
                MyTimer.Start(); // Start timer to show encoder ticks
                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
            }
        }

        private void buttonGoToZero_Click(object sender, EventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                _encoderWatch = true;
                MyTimer.Start(); // Start timer to show encoder ticks
                if (_m1EncoderCnt > 0)
                {
                    _roboClaw.ST_M1Backward(100); // Start the motor going forward at power 100
                    _roboClaw.ST_M2Backward(100); // Start the motor going forward at power 100
                }
                else if (_m1EncoderCnt < 0)
                {
                    _roboClaw.ST_M1Forward(100); // Start the motor going forward at power 100
                    _roboClaw.ST_M2Forward(100); // Start the motor going forward at power 100
                }
                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                _roboClaw.ST_M1Forward(0); // Stop the motor
                _roboClaw.ST_M2Forward(0); // Stop the motor
                MyTimer.Stop(); // Stop timer to stop encoder updates
                buttonStop.Enabled = false;
                buttonGoForward.Enabled = true;
                buttonGoReverse.Enabled = true;
                buttonDisconnect.Enabled = true;
                if(Math.Abs(_m1EncoderCnt) > 10)
                {
                    buttonGoToZero.Enabled = true;
                }
                _encoderWatch = false;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                MyTimer.Stop(); // Stop the timer to stop the encoder display updates
                _roboClaw.Close(); // Close the RoboClaw interface
                labelRoboClawModel.Text = " "; // Clear the RoboClaw device model number display
                buttonStop.Enabled = false;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_roboClaw.IsOpen())
            {
                _roboClaw.ST_M1Forward(0); // Stop the motor
                _roboClaw.ST_M2Forward(0); // Stop the motor
                _roboClaw.Close(); // Close the interface
                MyTimer.Stop(); // Stop the timer to stop the encoder display updates
            }
        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            // Get encoder ticks.
            _roboClaw.GetEncoders(out _m1EncoderCnt, out _m2EncoderCount);
            lblM1EncoderTicksCount.Text = _m1EncoderCnt.ToString();
            lblM2EncoderTicksCount.Text = _m2EncoderCount.ToString();

            // Get current values.
            _roboClaw.GetCurrents(out _m1Current, out _m2Current);
            lblM1Current.Text = _m1Current.ToString();
            lblM2Current.Text = _m2Current.ToString();

            // Get temperature.
            _roboClaw.GetTemperature(out _temperature);
            lblTemperature.Text = _temperature.ToString("0.00");

            // Get voltages.
            _roboClaw.GetMainVoltage(out _mainVoltage);
            lblMainVoltage.Text = _mainVoltage.ToString("0.00");
            _roboClaw.GetLogicVoltage(out _logicVoltage);
            lblLogicVoltage.Text = _logicVoltage.ToString("0.00");

            if (_encoderWatch)
            {
                if (Math.Abs(_m1EncoderCnt) < 10)
                {
                    _roboClaw.ST_M1Forward(0);
                    MyTimer.Stop(); // Stop timer to stop encoder updates
                    buttonStop.Enabled = false;
                    buttonGoForward.Enabled = true;
                    buttonGoReverse.Enabled = true;
                    buttonGoToZero.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    if (Math.Abs(_m1EncoderCnt) > 10)
                    {
                        buttonGoToZero.Enabled = true;
                    }
                    _encoderWatch = false;
                }
                else if (Math.Abs(_m1EncoderCnt) < 100)
                {
                    if (_m1EncoderCnt < 0)
                    {
                        _roboClaw.ST_M1Forward(14);
                    }
                    else
                    {
                        _roboClaw.ST_M1Backward(14);
                    }
                }
                else if (Math.Abs(_m1EncoderCnt) < 250)
                {
                    if (_m1EncoderCnt < 0)
                    {
                        _roboClaw.ST_M1Forward(20);
                    }
                    else
                    {
                        _roboClaw.ST_M1Backward(20);
                    }
                }
                else if (Math.Abs(_m1EncoderCnt) < 1000)
                {
                    if (_m1EncoderCnt < 0)
                    {
                        _roboClaw.ST_M1Forward(30);
                    }
                    else
                    {
                        _roboClaw.ST_M1Backward(30);
                    }
                }
            }
        }
    }
}
