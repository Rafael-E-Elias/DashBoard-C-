using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DashBoard
{
    public partial class DashBoard : Form
    {
        
        string ServerName = "";
        string DBName = "";

        /*Este objeto nos permite conectarnos a sql server.
        Toma como parametos el nombre del servidor y el nombre de la base de datos
        */
        SqlConnection Conexion = new SqlConnection("ServerName;DataBase=DBName");
        SqlCommand cmd;
        SqlDataReader reader;

        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
