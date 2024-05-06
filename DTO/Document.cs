using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class Document
    {
        private string idFile;
        private string maTask;
        private string moTa;
        private DateTime thoiGianUp;
        private byte[] data;
        private string extension;

        public Document() { }

        public Document(string idFile, string maTask, string  moTa, DateTime thoiGianUp, byte[] Date, string extension)
        {
            this.idFile = idFile;
            this.maTask = maTask;
            this.moTa = moTa;
            this.thoiGianUp = thoiGianUp;
            this.data = Date;
            this.extension = extension;
        }

        public string IdFile { get => this.idFile; set => this.idFile = value; }

        public string MaTask { get => this.maTask; set => this.maTask = value; }

        public string MoTa { get => this.moTa; set => this.moTa = value; }

        public DateTime ThoiGianUp { get => this.thoiGianUp; set => this.thoiGianUp = value; }

        public byte[] Data { get => this.data; set => this.data = value; }  

        public string Extension { get => this.extension; set => this.extension = value; }
    }
}
