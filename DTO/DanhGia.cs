using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class DanhGia
    {
        private int _id;
        private string maTask;
        private string nhanXet;
        private int diem;
        public DanhGia() { }

        public DanhGia(int id, string maTask, string nhanXet, int Diem)
        {
            this._id = id;
            this.maTask = maTask;
            this.nhanXet = nhanXet;
            this.diem = Diem;
        }

        public DanhGia(string maTask, string nhanXet, int Diem) 
        {
            this.maTask = maTask;
            this.nhanXet = nhanXet;
            this.diem = Diem;
        }

        public int ID { get { return _id; } set {  _id = value; } }

        public string MaTask { get => this.maTask; set { this.maTask = value; } }

        public string NhanXet { get => this.nhanXet; set { this.nhanXet = value; } }

        public int Diem {  get => this.diem; set {  this.diem = value; } }
    }
}
