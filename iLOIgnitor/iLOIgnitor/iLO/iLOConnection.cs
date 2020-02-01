using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLOIgnitor
{
    public class iLOConnection
    {
        public string Name { get; set; }

        /// <summary>
        /// 指定是否使用https
        /// </summary>
        public bool Https { get; set; }

        /// <summary>
        /// 指定主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 指定端口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 指定用户名
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// 指定密码
        /// </summary>
        public string UserPassword { get; set; }

        /// <summary>
        /// 读取选中iLO是否可用
        /// </summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// 读取iLO是否连接
        /// </summary>
        public bool IsConnected { get; private set; }

        /// <summary>
        /// 下次更新的时间（连接失败则5s后重试，需要重新编译才可以）
        /// </summary>
        public DateTime NextAttempt { get; private set; }

        /// <summary>
        /// 用于显示的状态(需要修改为调用资源)
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// 获得到的信息
        /// </summary>
        public JObject SystemInfo { get; private set; }

        private iLOHttpClient iLOHttpClient = new iLOHttpClient();
        private string sessionKey = string.Empty;

        /// <summary>
        /// iLO登录
        /// </summary>
        public async void Login()
        {
            try
            {
                if (!this.IsRunning)
                {
                    this.IsRunning = true;

                    this.Status = "Connecting...";

                    this.iLOHttpClient.Https = this.Https;
                    this.iLOHttpClient.Host = this.Host;
                    this.iLOHttpClient.Port = this.Port;

                    JObject jBody = new JObject()
                    {
                        {"method", "login"},
                        {"user_login", this.User},
                        {"password", this.UserPassword}
                    };

                    JObject json = await this.iLOHttpClient.DoJsonRequestAsync("POST", "json/login_session", jBody);
                    this.sessionKey = json["session_key"].ToString();

                    this.IsRunning = false;

                    this.UpdateSystemInfo();
                }
            }
            catch
            {
                this.SetFailStatus();

                this.IsRunning = false;
            }
        }

        /// <summary>
        /// iLO登出
        /// </summary>
        public void Logout()
        {
            JObject jBody = new JObject()
            {
                {"method", "logout"},
                {"session_key", this.sessionKey}
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/login_session", jBody);

            this.IsConnected = false;
        }

        /// <summary>
        /// 更新系统信息，包括概览、风扇、温度信息等
        /// </summary>
        public async void UpdateSystemInfo()
        {
            try
            {
                if (!this.IsRunning)
                {
                    this.IsRunning = true;

                    JObject jOverview = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/overview", null);
                    JObject jFan = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/health_fans", null);
                    JObject jTemp = await this.iLOHttpClient.DoJsonRequestAsync("GET", "json/health_temperature", null);

                    this.SystemInfo = new JObject()
                    {
                        {"Overview", jOverview},
                        {"Fan", jFan},
                        {"Temp", jTemp},
                        {"LastRefresh", DateTime.Now.ToString("HH:mm:ss")}
                    };

                    this.IsConnected = true;
                    this.Status = "";

                    this.IsRunning = false;
                }
            }
            catch
            {
                this.SetFailStatus();

                this.IsRunning = false;
            }
        }

        private void SetFailStatus()
        {
            this.IsConnected = false;
            this.Status = "Failed to connect this iLO.";
            this.NextAttempt = DateTime.Now.AddSeconds(10);
        }

        /// <summary>
        /// 短按开关
        /// </summary>
        public void PowerMomentaryPress()
        {
            JObject jBody = new JObject()
            {
                {"method", "press_power_button"},
                {"session_key", this.sessionKey}
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        /// <summary>
        /// 按住电源开关
        /// </summary>
        public void PressAndHold()
        {
            JObject jBody = new JObject()
            {
                {"method", "hold_power_button"},
                {"session_key", this.sessionKey }
            };

            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        /// <summary>
        /// 冷启动
        /// </summary>
        public void ColdBoot()
        {
            JObject jBody = new JObject()
            {
                {"method", "system_coldboot"},
                {"session_key", this.sessionKey }
            };
            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        /// <summary>
        /// 系统软件复位
        /// </summary>
        public void Reset()
        {
            JObject jBody = new JObject()
            {
                {"method", "system_reset"},
                {"session_key", this.sessionKey }
            };
            this.iLOHttpClient.DoJsonRequest("POST", "json/host_power", jBody);
        }

        public void OpenDotNetRemoteConsole(string ircPath)
        {
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo(ircPath);
                process.StartInfo.Arguments = string.Format("-addr {0}:{1} -name {2} -password {3}", this.Host, this.Port, this.User, this.UserPassword);

                process.Start();
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
