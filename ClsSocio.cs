using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Drawing;

namespace PryIEFIMartinez
{
    class ClsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Socio";

        private Decimal Saldos;
        private Int32 cantidad;

        private Int32 idCli; //es el DNI de la persona
        private String nom;
        private Decimal sal;
        private Int32 idBar;
        private Int32 idAct;
        private String dir;
        
        


        public Int32 IdCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Direccion
        {
            get { return dir; }
            set { dir = value; }
        }

        public Decimal Saldo
        {
            get { return sal; }
            set { sal = value; }
        }


        public Int32 IdBarrio
        {
            get { return idBar; }
            set { idBar = value; }
        }

        public Int32 IdBIdActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }

        public Int32 CantidadSocios
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }

        public Decimal TotalSaldo
        {
            get { return Saldos; }
            set { Saldos = value; }
        }

        public Decimal TotalDeuda
        {
            get { return Saldos; }
        }

        public Decimal PromedioDeuda
        {
            get
            {
                Decimal promedio = 0;
                if (cantidad != 0) promedio = Saldos / cantidad;
                {
                    return promedio;
                }
            }
        }

        Decimal MaySal = 0;
        

        public decimal MayorSaldo
        {
            get { return MaySal; }
            set { MaySal = value; }

        }

        Decimal MenSal = 0;


        public decimal MenorSaldo
        {
            get { return MenSal; }
            set { MenSal = value; }

        }

        


        public void ListarSocios(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;//Configuracion de la cadena de conexion
                conexion.Open();//Apertura 

                comando.Connection = conexion;// establece la conexion 
                comando.CommandType = CommandType.TableDirect;//Acsede a una tabla directa
                comando.CommandText = Tabla; 

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                cantidad = 0;
                Saldo = 0;
                TotalSaldo = 0;
                ClsBarrio Bar = new ClsBarrio();
                ClsActividad Act = new ClsActividad();
                String NomBar = "";
                String NomAct = "";
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        NomBar = Bar.Buscar(DR.GetInt32(3));
                        NomAct = Act.Buscar(DR.GetInt32(4));
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1),DR.GetString(2), NomBar, NomAct, DR.GetDecimal(5));
                        cantidad++;
                        Saldos = Saldos + DR.GetDecimal(5);
                    }
                }
                conexion.Close();//cierre de conexion 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
                Combo.ValueMember = "idSocio";

                conexion.Close();
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }

        public void ReporteClientes()
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter("ReporteClientes.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de clientes");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        archivo.Write(DR.GetInt32(0));
                        archivo.Write(";");
                        archivo.Write(DR.GetString(1));
                        archivo.Write(";");
                        archivo.WriteLine(DR.GetDecimal(5));
                        cantidad++;
                        total = total + DR.GetDecimal(5);
                    }
                }
                archivo.Write("Cantidad:;;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteClientesDeudores()
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter("ReporteClientesDeudores.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de clientes deudores");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        archivo.Write(DR.GetInt32(0));
                        archivo.Write(";");
                        archivo.Write(DR.GetString(1));
                        archivo.Write(";");
                        archivo.WriteLine(DR.GetDecimal(5));
                        cantidad++;
                        total = total + DR.GetDecimal(5);
                    }
                }
                archivo.Write("Cantidad:;;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Agregar()
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
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();

                fila["IdSocio"] = idCli;
                fila["Nombre"] = nom;
                fila["Direccion"] = dir;
                fila["idBarrio"] = idBar;
                fila["idActividad"] = idAct;
                fila["Saldo"] = sal;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, Tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 IdCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idCli = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            dir = DR.GetString(2);
                            idBar = DR.GetInt32(3);
                            idAct = DR.GetInt32(4);
                            sal = DR.GetDecimal(5);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Modificar(Int32 IdSocio)
        {
            try
            {
                
                String sql = "UPDATE Socio SET ";
                sql = sql + "Nombre = '" + nom + "',";
                sql = sql + "Direccion = '" + dir + "',";
                sql = sql + "idBarrio = " + idBar + ",";
                sql = sql + "idActividad = " + idAct + ",";
                sql = sql + "Saldo = " + sal + " ";
                sql = sql + "WHERE IdSocio = " + IdSocio ;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Eliminar(Int32 IdCliente)
        {
            try
            {
                String sql = "DELETE * FROM Socio WHERE IdSocio  = " + IdCliente.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ListarClientesDeUnaActividad(DataGridView Grilla, Int32 IdCiudad)
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
                MayorSaldo = 0;
                MenorSaldo = 100000000;
                
                Decimal Sld = 0;
                cantidad = 0;
                TotalSaldo = 0;
                Grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdCiudad)
                        {
                            Grilla.Rows.Add(fila["idSocio"], fila["Nombre"], fila["Saldo"]);

                            Sld = (Convert.ToDecimal(fila["Saldo"]));

                            if (MayorSaldo < Sld)
                            {
                                MayorSaldo = Sld;
                            }

                            if (MenorSaldo > Sld)
                            {
                                MenorSaldo = Sld;
                            }
                            cantidad++;
                            TotalSaldo = TotalSaldo + Convert.ToDecimal(fila["Saldo"]);

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarClientesDeBarrio(DataGridView Grilla, Int32 IdCiudad)
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
                MayorSaldo = 0;
                MenorSaldo = 100000000;

                Decimal Sld = 0;
                cantidad = 0;
                TotalSaldo = 0;
                Grilla.Rows.Clear();
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == IdCiudad)
                        {
                            Grilla.Rows.Add(fila["idSocio"], fila["Nombre"], fila["Saldo"]);

                            Sld = (Convert.ToDecimal(fila["Saldo"]));

                            if (MayorSaldo < Sld)
                            {
                                MayorSaldo = Sld;
                            }

                            if (MenorSaldo > Sld)
                            {
                                MenorSaldo = Sld;
                            }
                            cantidad++;
                            TotalSaldo = TotalSaldo + Convert.ToDecimal(fila["Saldo"]);

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        public void ListarClientesDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;//Configara la conexion 
                conexion.Open();// Apertura

                comando.Connection = conexion;// establece la conexion 
                comando.CommandType = CommandType.TableDirect;//entra a una tabla en forma directa
                comando.CommandText = Tabla;// nombre de la tabla 

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();//Limpiar grilla 
                TotalSaldo = 0;
                cantidad = 0;

                Grilla.Rows.Clear();

                if (DR.HasRows)//Si hay filas 
                {
                    while (DR.Read())//Mientras que el data reader las lea 
                    {
                        if (DR.GetDecimal(5) > 1500)//Si el saldo es mayor a 1500 
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));//Se muestra el DNI, el nombre y el saldo
                            cantidad++;
                            TotalSaldo = TotalSaldo + DR.GetDecimal(5);
                        }
                    }
                }
                conexion.Close();//cierre 
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void CosultaSocio(Int32 Nombre)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;// Configura la conexion 
                conexion.Open();// Apertura 
                comando.Connection = conexion;//establece la conexion 
                comando.CommandType = CommandType.TableDirect;//entra en una tabla de forma directa 
                comando.CommandText = Tabla;// nombre de la tabla 

                OleDbDataReader DR = comando.ExecuteReader();// toda la tabla de la base de datos fue a parar a
                                                             // un espacio de la memoria RAM llamado Data Reader(DR) 
                
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == Nombre)
                        {
                            idCli = DR.GetInt32(0);
                            Direccion = DR.GetString(2);
                            idBar = DR.GetInt32(3);
                            idAct = DR.GetInt32(4);
                            Saldo = DR.GetDecimal(5);


                        }
                    }
                }
                conexion.Close();
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }


        public void ReporteClientesDeUnaActividad(Int32 IdActividad, String NombreArchivoReporte)
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter(NombreArchivoReporte, false, Encoding.UTF8);
                archivo.WriteLine("Listado de clientes de una actividad");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Saldo");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if ( Convert.ToInt32( DR.GetValue(4)) == IdActividad)
                        {
                            archivo.Write(DR.GetInt32(0));
                            archivo.Write(";");
                            archivo.Write(DR.GetString(1));
                            archivo.Write(";");
                            archivo.WriteLine(DR.GetDecimal(5));
                            cantidad++;
                            total = total + DR.GetDecimal(5);
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReportePorBarrio(Int32 IdBarrio, String NombreArchivoReporte)
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter(NombreArchivoReporte, false, Encoding.UTF8);
                archivo.WriteLine("Listado de clientes de un barrio");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Saldo");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (Convert.ToInt32(DR.GetValue(4)) == IdBarrio)
                        {
                            archivo.Write(DR.GetInt32(0));
                            archivo.Write(";");
                            archivo.Write(DR.GetString(1));
                            archivo.Write(";");
                            archivo.WriteLine(DR.GetDecimal(5));
                            cantidad++;
                            total = total + DR.GetDecimal(5);
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ImprimirPorBarrio(PrintPageEventArgs Reporte)
        {
            try
            {
                Font TituloPrincipal = new Font("Arial", 30);
                Font Titulo1 = new Font("Arial", 18);
                Font Titulo2 = new Font("Arial", 14);
                Font LetraNormal = new Font("Arial", 12);


                Int32 Cantidad = 0;
                Int32 F = 200;


                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Reporte.Graphics.DrawString("GYM", TituloPrincipal, Brushes.Black, 325, 50);
                Reporte.Graphics.DrawString("Listado por Barrio", Titulo1, Brushes.Black, 300, 100);
                Reporte.Graphics.DrawString("DNI", Titulo2, Brushes.Black, 80, 150);
                Reporte.Graphics.DrawString("Nombre", Titulo2, Brushes.Black, 300, 150);
                Reporte.Graphics.DrawString("Saldo", Titulo2, Brushes.Black, 600, 150);

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow Reg in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(Reg["idBarrio"]) == idBar)
                        {
                            Reporte.Graphics.DrawString(Reg["IdSocio"].ToString(), LetraNormal, Brushes.Black, 80, F);
                            Reporte.Graphics.DrawString(Reg["Nombre"].ToString(), LetraNormal, Brushes.Black, 300, F);
                            Reporte.Graphics.DrawString(Reg["Saldo"].ToString(), LetraNormal, Brushes.Black, 600, F);
                            F = F + 30;
                            Cantidad++;
                        }
                    }
                }
                conexion.Close();



            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void ImprimirPorActividad(PrintPageEventArgs Reporte)
        {
            try
            {
                Font TituloPrincipal = new Font("Arial", 30);
                Font Titulo1 = new Font("Arial", 18);
                Font Titulo2 = new Font("Arial", 14);
                Font LetraNormal = new Font("Arial", 12);


                Int32 Cantidad = 0;
                Int32 F = 200;


                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Reporte.Graphics.DrawString("GYM", TituloPrincipal, Brushes.Black, 325, 50);
                Reporte.Graphics.DrawString("Listado por Actividad", Titulo1, Brushes.Black, 300, 100);
                Reporte.Graphics.DrawString("DNI", Titulo2, Brushes.Black, 80, 150);
                Reporte.Graphics.DrawString("Nombre", Titulo2, Brushes.Black, 300, 150);
                Reporte.Graphics.DrawString("Saldo", Titulo2, Brushes.Black, 600, 150);

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow Reg in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(Reg["idActividad"]) == idAct)
                        {
                            Reporte.Graphics.DrawString(Reg["IdSocio"].ToString(), LetraNormal, Brushes.Black, 80, F);
                            Reporte.Graphics.DrawString(Reg["Nombre"].ToString(), LetraNormal, Brushes.Black, 300, F);
                            Reporte.Graphics.DrawString(Reg["Saldo"].ToString(), LetraNormal, Brushes.Black, 600, F);
                            F = F + 30;
                            Cantidad++;
                        }
                    }
                }
                conexion.Close();



            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }


        public void ImprimirTodos(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 F = 150;
                Font Texto = new Font("Arial",10);
                Font Titulo = new Font("Arial", 20);
                Font Subtitulo = new Font("Arial", 12);
                Reporte.Graphics.DrawString("Listado de socios", Titulo, Brushes.Crimson, 325, 50);
                Reporte.Graphics.DrawString("DNI", Subtitulo, Brushes.Green, 300, 125);
                Reporte.Graphics.DrawString("Nombre", Subtitulo, Brushes.Green, 80, 125);
                Reporte.Graphics.DrawString("Saldo", Subtitulo, Brushes.Green, 600, 125);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Reporte.Graphics.DrawString(fila["IdSocio"].ToString(), Texto,Brushes.Black,80,F);
                        Reporte.Graphics.DrawString(fila["Nombre"].ToString(), Texto, Brushes.Black, 300, F);
                        Reporte.Graphics.DrawString(fila["Saldo"].ToString(), Texto, Brushes.Black, 600, F);
                        F = F + 15;
                    }
                }
                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ImprimirDeudores(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 F = 150;
                Font Texto = new Font("Arial", 10);
                Font Titulo = new Font("Arial", 20);
                Font Subtitulo = new Font("Arial", 12);
                Reporte.Graphics.DrawString("Listado de socios", Titulo, Brushes.Crimson, 325, 50);
                Reporte.Graphics.DrawString("DNI", Subtitulo, Brushes.Green, 300, 125);
                Reporte.Graphics.DrawString("Nombre", Subtitulo, Brushes.Green, 80, 125);
                Reporte.Graphics.DrawString("Saldo", Subtitulo, Brushes.Green, 600, 125);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToDecimal(fila["Saldo"]) < 1500)
                        {
                            Reporte.Graphics.DrawString(fila["IdSocio"].ToString(), Texto, Brushes.Black, 80, F);
                            Reporte.Graphics.DrawString(fila["Nombre"].ToString(), Texto, Brushes.Black, 300, F);
                            Reporte.Graphics.DrawString(fila["Saldo"].ToString(), Texto, Brushes.Black, 600, F);
                            F = F + 15;
                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
