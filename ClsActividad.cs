using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;

namespace PryIEFIMartinez
{
    class ClsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Actividad";


        public String Buscar(Int32 IdActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                String Resultado = "";
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdActividad)
                        {
                            Resultado = DR.GetString(1);
                        }
                    }
                }
                conexion.Close();
                return Resultado;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public void listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);
                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        public void Listar(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);
                Combo.DataSource = DS.Tables[0];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "IdActividad";

                conexion.Close();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }


        public void llenarActividad(Label Actividad, Int32 idSocio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                foreach (DataRow fila in DS.Tables[Tabla].Rows)
                {
                    if (Convert.ToInt32(fila["idActividad"]) == idSocio)
                    {
                        Actividad.Text = fila["Nombre"].ToString();
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }


















    }
}
