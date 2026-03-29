using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3.Model
{
    public class EtabsAPI_PropFrame
    {
        public int NumberNames { get; set; }
        public string MyName { get; set; }
        public int PropType { get; set; }
        public double t2 { get; set; }
        public double t3 { get; set; }
        public double tf { get; set; }
        public double tw { get; set; }
        public double t2b { get; set; }
        public double tfw { get; set; }

        public EtabsAPI_PropFrame(string sectionName)
        {
            this.MyName = sectionName;
        }

        public void GetSectionDimension()
        {
            // Logic lấy kích thước tiết diện
        }
    }
}
