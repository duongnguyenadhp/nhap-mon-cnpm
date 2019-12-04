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
            new TabMenu(){Title="Tài khoản",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Thông tin tài khoản",Icon="AccountEdit"},
                new TabMenuItem(){Title="Phân quyền",Icon="SecurityAccount"},
                new TabMenuItem(){Title="Đăng xuất",Icon="Logout"},
            },Icon="AccountCircle"},
            new TabMenu(){Title="Danh mục",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Khối & Lớp",Icon="InfoOutline"},
                new TabMenuItem(){Title="Môn học",Icon="RemoteDesktop"},
                new TabMenuItem(){Title="Giáo viên",Icon="RemoteDesktop"},
                new TabMenuItem(){Title="Phụ",Icon="RemoteDesktop"},
            },Icon="DesktopClassic"},
            new TabMenu(){Title="Hồ sơ học sinh",Items=new ObservableCollection<TabMenuItem>(){
                new TabMenuItem(){Title="Cập nhật hồ sơ",Icon="PersonAddOutline"},
                new TabMenuItem(){Title="Phân lớp học sinh",Icon="Bitcoin"},
                new TabMenuItem(){Title="Cập nhật điểm",Icon="PersonAddOutline"},
                new TabMenuItem(){Title="Cập nhật hạnh kiểm",Icon="Bitcoin"},
                new TabMenuItem(){Title="Khen thưởng & Kỷ luật",Icon="Bitcoin"},
                new TabMenuItem(){Title="Tiền học",Icon="Bitcoin"},
            },Icon="HumanChild"},
            new TabMenu(){Title="Tìm kiếm",Icon="FolderSearchOutline"},
            new TabMenu(){Title="Báo cáo thống kê",Icon="FileDocument   "}
        };

        public MainWindowViewModel()
        {
           
        }
    }
}
