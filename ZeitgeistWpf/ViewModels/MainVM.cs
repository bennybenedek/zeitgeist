using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ZeitgeistWpf.ViewModels
{
    class MainVM : ViewModelBase
    {
        public UserControl CurrentView { get; set; }
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
