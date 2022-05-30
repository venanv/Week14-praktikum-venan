using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week14_praktikum_venan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable Team = new DataTable();
        DataTable Score = new DataTable();
        int PosisiSekarang = 0;

        public void DataPemain(int posisi)
        {
            lbname.Text = Team.Rows[posisi][0].ToString();
            lbmanager.Text = Team.Rows[posisi][1].ToString();
            lbstadium.Text = Team.Rows[posisi][2].ToString();
            sqlQuery = "select concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), ' (', sum(dm.type = 'GP'),')') from dmatch dm, player p where p.team_id = '" + Team.Rows[posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id group by dm.player_id order by 1 desc; ";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Score);
            lbscore.Text = Score.Rows[posisi][0].ToString();
            PosisiSekarang = posisi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name,' (',n.nation,')'), concat(t.home_stadium, ', ',  t.city, ' (',t.capacity,')'), t.team_id from team t, manager m, nationality n where t.manager_id = m.manager_id and n.nationality_id = m.nationality_id; ";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Team);
            DataPemain(0);
        }

        private void btfirst_Click(object sender, EventArgs e)
        {
            DataPemain(0);
        }

        private void btprev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < Team.Rows.Count - 1)
            {
                PosisiSekarang++;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btlast_Click(object sender, EventArgs e)
        {
            DataPemain(Team.Rows.Count - 1);
        }

        private void team_Click(object sender, EventArgs e)
        {

        }

        private void dgv(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
