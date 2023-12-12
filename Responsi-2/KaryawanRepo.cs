using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2
{
    internal class KaryawanRepo : Karyawan
    {
        private const string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi-fio;Include Error Detail=true";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable dt;

        private DataGridView dgvData;
        private DataGridViewRow row;
        private string sql;

        public DataGridViewRow Row { get => row; set => row = value; }

        public KaryawanRepo(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }

        public void Load()
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                sql = "SELECT * FROM emp_select()";
                cmd = new NpgsqlCommand(sql, connection);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Insert(TextBox tbNama, ComboBox cbDept, Button btnLoad)
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                sql = "SELECT * FROM emp_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDept.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    tbNama.Text = null;
                    cbDept.Text = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        
        public void Update(TextBox tbNama, ComboBox cbDept, Button btnLoad)
        {
            connection = new NpgsqlConnection(conn);
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate");
            }
            try
            {
                connection.Open();
                sql = "SELECT * FROM emp_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id_karyawan", row.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDept.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate");
                    tbNama.Text = null;
                    cbDept.Text = null;
                    row = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(TextBox tbNama, ComboBox cbDept, Button btnLoad)
        {
            connection = new NpgsqlConnection(conn);
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus");
            }
            try
            {
                connection.Open();
                sql = "SELECT * FROM emp_delete(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id_karyawan", row.Cells["_id_karyawan"].Value.ToString());

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    tbNama.Text = null;
                    cbDept.Text = null;
                    row = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
