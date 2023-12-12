using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2
{
    public class Karyawan
    {
        private string _id_karyawan;
        private string _nama;
        private string _id_dep;

        public string Id_karyawan { get => _id_karyawan; set => _id_karyawan = value; }
        public string Nama { get => _nama; set => _nama = value; }
        public string Id_dep { get => _id_dep; set => _id_dep = value; }
    }
}
