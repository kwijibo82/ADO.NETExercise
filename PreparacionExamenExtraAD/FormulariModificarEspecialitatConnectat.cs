using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparacionExamenExtraAD
{
    public partial class FormulariModificarEspecialitatConnectat : Form
    {
        //variable de control para el evento selectionchanged
        public bool clickEnGrid = false;

        public FormulariModificarEspecialitatConnectat()
        {
            InitializeComponent();
        }


        private void FormulariModificarEspecialitatConnectat_Load(object sender, EventArgs e)
        {

            /*conectamos*/
            SqlConnection connect = new SqlConnection();
            connect = AccionesSQL.establecerConexion();

            //creamos objetos SqlDataReader y SqlCommand
            SqlCommand sentenciaDataGrid, sentenciaComboProfes, sentenciaComboEsport;
            SqlDataReader dataReaderDataGridView, dataReaderProfes, dataReaderEsport;

            try 
            {
                //abrimos conexión
                connect.Open();

                //ESTA PARTE DE CÓDIGO LLENA LA COMBOBOX DE PROFESORES
                //CON LOS PROFESORES QUE HAY 
                //EN LA BASE DE DATOS
                sentenciaComboProfes = AccionesSQL.crearSentenciaLlenadoComboBoxProfesores(connect);

                dataReaderProfes = sentenciaComboProfes.ExecuteReader();

                DataTable dtComboProfes = new DataTable();
                dtComboProfes.Load(dataReaderProfes);

                //añadimos a la combo 
                comboBoxProfesores.ValueMember = "nombre";
                comboBoxProfesores.DisplayMember = "nombre";
                comboBoxProfesores.DataSource = dtComboProfes;

                dataReaderProfes.Close();

                //ESTA PARTE DE CÓDIGO LLENA LA COMBOBOX DE DEPORTES
                sentenciaComboEsport = AccionesSQL.crearSentenciaLlenadoComboBoxDeportes(connect);

                dataReaderEsport = sentenciaComboEsport.ExecuteReader();
                
                //añadimos datos a la combo
                DataTable dtEsports = new DataTable();
                dtEsports.Load(dataReaderEsport);
                comboBoxEsport.ValueMember = "desc_deporte";
                comboBoxEsport.DisplayMember = "desc_deporte";
                comboBoxEsport.DataSource = dtEsports;

                dataReaderEsport.Close();

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
            }
            finally
            {
                //cerramos conexiones
                connect.Close();
            }

        }

        private void dataGridViewEspecialitats_SelectionChanged(object sender, EventArgs e)
        {
            if (clickEnGrid)
            {

                /*conectamos*/
                SqlConnection connect = new SqlConnection();
                connect = AccionesSQL.establecerConexion();
           
                try
                {                  
                    connect.Open();

                    SqlCommand sentenciaProfe, sentenciaDeporte;
                    SqlDataReader dataReaderProfes, dataReaderDeportes;

                    int idDeporte = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[0].Value;
                    String dniProfe = this.dataGridViewEspecialitats.CurrentRow.Cells[1].Value.ToString();

                    //llenamos combos con los datos
                    sentenciaProfe = AccionesSQL.getNombreProfe(connect, dniProfe);
                    dataReaderProfes = sentenciaProfe.ExecuteReader();          
                    DataTable dtProfes = new DataTable();
                    dtProfes.Load(dataReaderProfes);
                    this.comboBoxProfesores.SelectedValue = dtProfes.Rows[0][0].ToString();
                    dataReaderProfes.Close();

                    sentenciaDeporte = AccionesSQL.getDeporte(connect, idDeporte);
                    DataTable dtDeportes = new DataTable();
                    dataReaderDeportes = sentenciaDeporte.ExecuteReader();
                    dtDeportes.Load(dataReaderDeportes);
                    this.comboBoxEsport.SelectedValue = dtDeportes.Rows[0][0].ToString();
                    dataReaderDeportes.Close();
                   
                    //llenamos textbox con el grado
                    this.textBoxGrau.Text = this.dataGridViewEspecialitats.CurrentRow.Cells[2].Value.ToString();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
                }
                finally
                {
                    //cerramos conexiones
                    connect.Close();
                } 

            }

        }

        private void dataGridViewEspecialitats_MouseClick(object sender, MouseEventArgs e)
        {
           //ponemos booleana de control a true
            clickEnGrid = true;
            this.dataGridViewEspecialitats_SelectionChanged(sender, e);

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection();
            connect = AccionesSQL.establecerConexion();
            SqlCommand sentenciaBorrarEspecialidad, sentenciaAltaNuevaEspecialidad, sentenciaGetIdDeporte,
                sentenciaGetDniProfe;

            /*conectamos*/
            connect.Open();

            try
            {

                #region ESTA PARTE DEL CÓDIGO INTRODUCE UNA NUEVA ESPECIALIDAD SEGÚN LOS DATOS INTRODUCIDOS

                //obtenemos datos
                //obtenemos id_deporte
                String esport = this.comboBoxEsport.SelectedValue.ToString();
                sentenciaGetIdDeporte = AccionesSQL.getidDeporteSeleccionadoEnCombo(connect, esport);
                int id_deporte = (int) sentenciaGetIdDeporte.ExecuteScalar();

                //obtenemos nombre profe
                String nomProfe = this.comboBoxProfesores.SelectedValue.ToString();
                sentenciaGetDniProfe = AccionesSQL.getDniProfeSeleccionadoEnCombo(connect, nomProfe);
                String dniProfe = (String) sentenciaGetDniProfe.ExecuteScalar(); 

                //obtenemos grado
                int grau = Int32.Parse(this.textBoxGrau.Text);

                sentenciaAltaNuevaEspecialidad = AccionesSQL.crearSentenciaAltaNuevaEspecialidad(connect, id_deporte, dniProfe, grau);

                sentenciaAltaNuevaEspecialidad.ExecuteNonQuery();

                MessageBox.Show("Registro añadido correctamente");

                #endregion

                #region ESTA PARTE DEL CÓDIGO BORRA EL REGISTRO SELECCIONADO EN LA GRID
                //obtenemos datos de la grid para borrar la fila seleccionada de la base de datos
                int idDeporte = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[0].Value;
                String dni = this.dataGridViewEspecialitats.CurrentRow.Cells[1].Value.ToString();
                int grado = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[2].Value;

                sentenciaBorrarEspecialidad = AccionesSQL.BorrarEspecialitat(connect, idDeporte, dni, grado);

                sentenciaBorrarEspecialidad.ExecuteNonQuery();

                MessageBox.Show("Registro borrado correctamente");
                #endregion
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
            }
            finally
            {
                connect.Close();
            }
            

        }

        private void FormulariModificarEspecialitatConnectat_Activated(object sender, EventArgs e)
        {
            /*conectamos*/
            SqlConnection connect = new SqlConnection();
            connect = AccionesSQL.establecerConexion(); 

            try
            {
                connect.Open();
                
                SqlCommand sentenciaRefreshDataGrid = AccionesSQL.crearSentenciaLlenadoDataGridEspecialidades(connect);

                SqlDataReader dataReaderRefreshDataGridView = sentenciaRefreshDataGrid.ExecuteReader();

                DataTable dtgrid = new DataTable();
                dtgrid.Load(dataReaderRefreshDataGridView);

                //añadimos a la dataGrid
                dataGridViewEspecialitats.DataSource = dtgrid;
                dataReaderRefreshDataGridView.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
            }
            finally
            {
                connect.Close();
            }
    
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
