using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewModelLocator
    {
        private static MainWindowViewModel _mainWindowViewModelStatic;
        public static MainWindowViewModel MainWindowViewModelStatic
        {
            get
            {
                if (_mainWindowViewModelStatic == null)
                    _mainWindowViewModelStatic = new MainWindowViewModel();
                return _mainWindowViewModelStatic;
            }
        }
    }
}
