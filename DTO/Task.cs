using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Luan_Van.DTO
{
    public class Task
    {
        private string maTask;
        private string maDT;
        private string tenTask;
        private string moTa;
        private int tyLeHoanThanh;
        private DateTime deadline;

        public Task(string maTask, string maDT, string tenTask, string moTa, int tyLeHoanThanh, DateTime deadline)
        {
            this.maTask = maTask;
            this.maDT = maDT;
            this.tenTask = tenTask;
            this.moTa = moTa;
            this.tyLeHoanThanh = tyLeHoanThanh;
            this.deadline = deadline;
        }

        public string MaTask { get => this.maTask; set => this.maTask = value; }

        public string MaDT { get => this.maDT; set => this.maDT = value; }

        public string TenTask {  get => this.tenTask; set => this.tenTask = value; }

        public string MoTa { get => this.moTa; set => this.moTa = value; }

        public int TyLeHoanThanh { get => this.tyLeHoanThanh; set => this.tyLeHoanThanh = value; }

        public DateTime Deadline { get => this.deadline; set => this.deadline = value; }
    }
}
