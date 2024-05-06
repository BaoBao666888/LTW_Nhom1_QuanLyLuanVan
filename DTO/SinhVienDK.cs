using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quan_Li_Luan_Van.DTO
{


    public class SinhVienDK
    {
        private string mssv;
        private string hoten;

        public SinhVienDK() { }
        public SinhVienDK(string mssv, string hoten)
        {
            this.mssv = mssv;
            this.hoten = hoten;
        }
        public string MSSV { get => this.mssv; set => this.mssv = value; }
        public string Hoten { get => this.hoten; set => this.hoten = value; }
    }
}
