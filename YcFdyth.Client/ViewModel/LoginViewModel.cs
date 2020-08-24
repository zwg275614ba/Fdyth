using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;

namespace YcFdyth.Client.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private frmLogin frmLogin { get; set; }
        public LoginViewModel(frmLogin frm)
        {
            frmLogin = frm;
        }
        private RelayCommand _exitCommand;
        public RelayCommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new RelayCommand(() => ApplicationShutdown());
                }
                return _exitCommand;
            }
        }

        /// <summary>
        /// 关闭系统
        /// </summary>
        public void ApplicationShutdown()
        {
            //Messenger.Default.Send("", "DialogClose");
            frmLogin.Close();
        }
    }
}
