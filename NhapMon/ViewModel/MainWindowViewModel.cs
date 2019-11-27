using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VMHelper;
namespace ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
        public string Test;
        public List<TabMenu> Menu { get; set; } = new List<TabMenu>() {
            new TabMenu(){Title="Quản lý tài khoản",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Thông tin tài khoản",Icon="AccountEdit"},
                new TabMenuItem(){Title="Phân quyền",Icon="SecurityAccount"},
                new TabMenuItem(){Title="Đăng xuất",Icon="Logout"},
            },Icon="AccountCircle"},
            new TabMenu(){Title="Quản lý danh mục",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Danh mục khối & lớp",Icon="InfoOutline"},
                new TabMenuItem(){Title="Danh mục môn học",Icon="RemoteDesktop"},
                new TabMenuItem(){Title="Danh mục giáo viên",Icon="RemoteDesktop"},
                new TabMenuItem(){Title="Danh mục phụ",Icon="RemoteDesktop"},
            },Icon="DesktopClassic"},
            new TabMenu(){Title="Quản lý học sinh",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Thông tin học sinh",Icon="PersonAddOutline"},
                new TabMenuItem(){Title="Tiền học",Icon="Bitcoin"},
                new TabMenuItem(){Title="Học tập",Icon="BookOpenOutline"},
                new TabMenuItem(){Title="Rèn luyện",Icon="BookOpenOutline"},
            },Icon="HumanChild"},
            new TabMenu(){Title="Phân công giảng dạy",Icon="FolderSearchOutline"},
            new TabMenu(){Title="Tìm kiếm",Icon="FolderSearchOutline"},
            new TabMenu(){Title="Báo cáo thống kê",Icon="FileDocument   "}
        };

        public MainWindowViewModel()
        {
           
        }
    }
}
