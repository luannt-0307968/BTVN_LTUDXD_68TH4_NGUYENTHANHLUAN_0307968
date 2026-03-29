using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauDuAn_CTThietKeDam.Models
{
    public class EtabsAPI_FrameForce
    {
        // Fields & Properties
        public string Name { get; set; }
        public string ItemTypeElm { get; set; }
        public int NumberResults { get; set; }
        public string Obj { get; set; }
        public double ObjSta { get; set; } // Vị trí mặt cắt
        public string Elm { get; set; }
        public double ElmSta { get; set; }
        public string LoadCase { get; set; }
        public string StepType { get; set; }
        public double StepNum { get; set; }

        // Các giá trị nội lực
        public double P { get; set; }
        public double V2 { get; set; }
        public double V3 { get; set; }
        public double T { get; set; }
        public double M2 { get; set; }
        public double M3 { get; set; } // Mô men uốn chính

        public EtabsAPI_FrameForce(string name)
        {
            this.Name = name;
        }

        public void GetFrameForces()
        {
            // Logic lấy nội lực từ API
        }
    }
}
