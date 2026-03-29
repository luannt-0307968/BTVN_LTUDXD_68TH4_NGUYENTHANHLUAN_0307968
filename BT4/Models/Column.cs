using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4.Models
{
    public class Column
    {
        public string Id { get; set; }
        public string Mark { get; set; } //mã hiệu
        public string Story { get; set; } //tầng
        public double Length { get; set; } //chiều dài
        public double Width { get; set; } //chiều rộng 

        public EtabsAPI_Frame Frame { get; set; }
        //khai báo quan hệ 1-n giữa beam và frame force
        public ObservableCollection<EtabsAPI_FrameForce> FrameForces { get; set; } //danh sách nội lực của dầm


    }
}
