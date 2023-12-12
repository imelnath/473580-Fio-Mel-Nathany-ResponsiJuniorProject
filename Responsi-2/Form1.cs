using System.Data;

namespace Responsi_2
{
    public partial class Form1 : Form
    {
        public DataTable dt;
        private DataGridViewRow r;

        private Karyawan emp;
        private KaryawanRepo empRepo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empRepo = new KaryawanRepo(dgvData);
            emp = new Karyawan();
            btnLoad.PerformClick();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            empRepo.Load();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            empRepo.Insert(tbNama, cbDept, btnLoad);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                cbDept.Text = r.Cells["_id_dep"].Value.ToString();
                empRepo.Row = r;
                emp.Nama = tbNama.Text;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            empRepo.Update(tbNama, cbDept, btnLoad);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            empRepo.Delete(tbNama, cbDept, btnLoad);
        }
    }
}