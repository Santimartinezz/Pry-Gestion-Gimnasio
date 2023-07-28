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
    class ClsBarrio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Barrio";

        public String Buscar(Int32 IdBarrio)
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
                        if (DR.GetInt32(0) == IdBarrio)
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

                adaptador = new OleDbDataAdapter(comando);// El adaptador permite convertir los datos que estan en
                                                          // la base de datos en valores entendibles para .NET
                DataSet DS = new DataSet();// Se crea un objeto local tipo Data Set
                adaptador.Fill(DS);//llenamos el data set con la informacion del comando por medio del adaptador 
                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }

            catch(Exception Error)
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

                adaptador = new OleDbDataAdapter(comando);// El adaptador permite convertir los datos que estan en
                                                          // la base de datos en valores entendibles para .NET

                DataSet DS = new DataSet();// Se crea un objeto local tipo Data Set 
                adaptador.Fill(DS);//llenamos el data set con la informacion del comando por medio del adaptador 
                Combo.DataSource = DS.Tables[0];
                Combo.DisplayMember = "Nombre";// el nombre que tiene la columna con los datos que nosotros queremos que se vean 
                Combo.ValueMember = "IdBarrio";// el nombre que tiene la columna con los datos que no queremos que se vean

                conexion.Close();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }


        public void llenarBarrio(Label Barrio, Int32 idSocio)
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
                adaptador.Fill(DS,Tabla);

                foreach (DataRow fila in DS.Tables[Tabla].Rows)
                {
                    if (Convert.ToInt32(fila["idBarrio"]) == idSocio)
                    {
                        Barrio.Text = fila["Nombre"].ToString();
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
