using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace iLOIgnitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            setLogin(ref icCurConn);
            timer1.Interval = 500;
            timer1.Start();
            tmrRefresh.Interval = 5000;
            tmrRefresh.Start();
            dtPowerOn = Convert.ToDateTime("8:30:00");
            dtPowerOff = Convert.ToDateTime("20:50:00");
        }
        
        private iLOConnection icCurConn = new iLOConnection();
        private DateTime dtPowerOn = new DateTime();
        private DateTime dtPowerOff = new DateTime();


        private void setLogin(ref iLOConnection iLOConn)
        {
            iLOConn.Name = "vmhost";
            iLOConn.Https = true;
            iLOConn.Host = "172.16.10.170";
            iLOConn.Port = 443;
            iLOConn.User = "poweron";
            iLOConn.UserPassword = "UUBuZExJejEsZU8qd2BxImZT";
            iLOConn.Login();
        }

        private void updateUI()
        {
            lblServer.Text = icCurConn.Name;
            lblStatus.Text = ((string)icCurConn.SystemInfo["Overview"]["system_health"]).Replace("OP_STATUS_", "");
            string powerState = icCurConn.SystemInfo["Overview"]["power"].ToString();
            if (powerState.Contains("ON"))
            {
                lblPower.Text = "ON";
            }
            else if (powerState.Contains("OFF"))
            {
                lblPower.Text = "OFF";
            }
            else
            {
                lblPower.Text = "Unknown";
            }
            lblLastRefresh.Text = (string)icCurConn.SystemInfo["LastRefresh"];
            lblConnStatus.Text = icCurConn.Status;
        }

        private void powerOn()
        {
            try
            {
                if (icCurConn.SystemInfo["Overview"]["power"].ToString().Contains("OFF"))
                {
                    icCurConn.PowerMomentaryPress();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void powerOff()
        {
            try
            {
                if (icCurConn.SystemInfo["Overview"]["power"].ToString().Contains("ON"))
                {
                    icCurConn.PowerMomentaryPress();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblCurTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblPowerOnTime.Text = dtPowerOn.ToString("HH:mm:ss");
            lblPowerOffTime.Text = dtPowerOff.ToString("HH:mm:ss");
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                if (icCurConn.IsConnected)
                {
                    if (!icCurConn.IsRunning)
                    {
                        icCurConn.UpdateSystemInfo();
                    }
                }
                else if (DateTime.Now >= icCurConn.NextAttempt)
                {
                    if (!icCurConn.IsRunning)
                    {
                        icCurConn.Login();
                    }
                }

                updateUI();

                if (dtPowerOn.Hour == DateTime.Now.Hour && dtPowerOn.Minute == DateTime.Now.Minute && cbPowerOn.Checked)
                {
                    lblWorkStatus.Text = "Powering on...";
                    tmrRefresh.Stop();
                    powerOn();
                    System.Threading.Thread.Sleep(15 * 1000);
                    lblWorkStatus.Text = "Idle";
                    tmrRefresh.Start();
                }

                if (dtPowerOff.Hour == DateTime.Now.Hour && dtPowerOff.Minute == DateTime.Now.Minute && cbPowerOff.Checked)
                {
                    lblWorkStatus.Text = "Powering off...";
                    tmrRefresh.Stop();
                    powerOff();
                    System.Threading.Thread.Sleep(180 * 1000);
                    lblWorkStatus.Text = "Idle";
                    tmrRefresh.Start();
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
