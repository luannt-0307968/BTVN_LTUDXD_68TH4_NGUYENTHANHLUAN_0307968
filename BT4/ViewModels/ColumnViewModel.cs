using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BT4.ViewModels
{
    public class ColumnViewModel : INotifyPropertyChanged
    {
        //1. Triển khai INotifyPropertyChanged để thông báo khi có sự thay đổi dữ liệu
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //2. Khai báo danh sách dầm để binding với view
        public ObservableCollection<Models.Column> Columns { get; set; } = new ObservableCollection<Models.Column>();
        //3. Khai báo các properties của dầm để binding với view
        #region khai báo fields
        private string _id;
        private string _mark;
        private string _story;
        private string _length;
        private string _width;
        #endregion

        #region khai báo properties
        public string Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(); }
        }
        public string Mark
        {
            get => _mark;
            set { _mark = value; OnPropertyChanged(); }
        }

        public string Story
        {
            get => _story;
            set { _story = value; OnPropertyChanged(); }
        }
        public string Length
        {
            get => _length;
            set { _length = value; OnPropertyChanged(); }
        }
        public string Width
        {
            get => _width;
            set { _width = value; OnPropertyChanged(); }
        }
        #endregion

        //4. Khai báo các command để xử lý sự kiện từ view (nếu cần)
        public ICommand AddColumnCommand { get; }

        //5. Khai báo hàm khởi tạo
        public ColumnViewModel()
        {
            //7.Khởi tạo command trong constructor (hàm khởi tạo)
            AddColumnCommand = new RelayCommand(AddColumn);
        }
        //6. khai báo hàm xử lý sự kiện (hàm thêm dầm)
        private void AddColumn()
        {
            // Tạo một đối tượng cột mới. 
            // Dùng Models.Column để tránh lỗi "Ambiguous" với thư viện Excel ở bước trước.
            Models.Column Cot = new Models.Column
            {
                Id = (Columns.Count + 1).ToString(),

                // Cột thường ký hiệu là C (Column), dầm mới là D (Beam). 
                // Phải dùng Columns.Count (đếm danh sách) chứ không dùng Column.Count (lớp).
                Mark = $"C{Columns.Count + 1}",

                Story = "Tầng 1",
                Width = 0.3,
                Length = 3.0
            };

            // Thêm cột vừa tạo vào danh sách cột
            Columns.Add(Cot);
        }
    }
}
