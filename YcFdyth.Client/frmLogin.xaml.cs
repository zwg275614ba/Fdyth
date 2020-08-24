using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YcFdyth.Client.ViewModel;
using Yckj.YcFdyth.Common;

namespace YcFdyth.Client
{
    /// <summary>
    /// frmLogin.xaml 的交互逻辑
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtAccountName.Text) || string.IsNullOrEmpty(this.txtPwd.Password))
                {
                    this.labMsg.Text = "用户名和密码不能为空";
                    return;
                }
                this.labMsg.Text = "登录中...";
                var password = Md5.md5(txtPwd.Password, 32);
                var entity = UnityConfig.用户表Service.GetModel(l => l.LoginName == this.txtAccountName.Text.ToString() && l.LoginPwd == password);
                if (entity == null)
                {
                    this.labMsg.Text = "输入的用户名或密码错误";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                this.labMsg.Text = string.Format("登录失败:{0}", ex.Message);
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
