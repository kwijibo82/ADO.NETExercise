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
    public partial class FormulariModificarEspecialitatsDesconnectat : Form
    {

        

        public FormulariModificarEspecialitatsDesconnectat()
        {
            InitializeComponent();
        }

        private void FormulariModificarEspecialitatsDesconnectat_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gimnasioExamenDataSet.profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.gimnasioExamenDataSet.profesores);
            // TODO: esta línea de código carga datos en la tabla 'gimnasioExamenDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.gimnasioExamenDataSet.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'gimnasioExamenDataSet.deportes' Puede moverla o quitarla según sea necesario.
            this.deportesTableAdapter.Fill(this.gimnasioExamenDataSet.deportes);

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            //obtenemos datos de la grid
            try
            {
                int idDeporte = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[0].Value;
                String dniProfe = this.dataGridViewEspecialitats.CurrentRow.Cells[1].Value.ToString();
                int grado = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[2].Value;

                //obtenemos los valores nombre del deporte, nombre del profesor, y grado
                #region OBTENEMOS MEDIANTE UN FILTER DEL BINDINGSOURCE EL NOMBRE DEL PROFESOR
                this.bindingSourceProfesores.RemoveFilter();
                this.bindingSourceProfesores.Filter = string.Format("dni LIKE '*{0}*'", dniProfe);
                this.comboBoxProfesores.DataSource = this.bindingSourceProfesores;
                this.comboBoxProfesores.ValueMember = "dni";
                this.comboBoxProfesores.DisplayMember = "nombre";
                #endregion

                #region OBTENEMOS MEDIANTE UN FILTER DEL BINDINGSOURCE EL NOMBRE DEL DEPORTE
                this.bindingSourceDeportes.RemoveFilter();
                //ATENCIÓN, usuamos la función convert en el filter para pasar el id_deporte (que es un string) a int
                this.bindingSourceDeportes.Filter = string.Format("CONVERT(id_deporte, 'System.String') LIKE '*{0}*'", idDeporte);
                this.comboBoxEsport.DataSource = this.bindingSourceDeportes;
                this.comboBoxEsport.ValueMember = "id_deporte";
                this.comboBoxEsport.DisplayMember = "desc_deporte";
                #endregion

                //seteamos valor del grado en la datagrid en la textbox grado
                this.textBoxGrau.Text = grado.ToString();
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
         

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            /**
             * ESTA PARTE DE CÓDIGO ELIMNA REGISTOS DE LA TABLA ESPECIALIDADES
             * SEGÚN LOS VALORES OBTENIDOS DE LA DATAGRID ESPECIALIDADES
             */
            int idDeporte = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[0].Value;
            String dniProfe = this.dataGridViewEspecialitats.CurrentRow.Cells[1].Value.ToString();
            int grado = (int)this.dataGridViewEspecialitats.CurrentRow.Cells[2].Value;

           

            //controla que hay al menos un a fila seleccionada en la grid
            if (this.dataGridViewEspecialitats.SelectedRows.Count > 0)
            {
                //obtenemos datos             
                #region ELIMINAMOS UN REGISTRO

                /**
                 * FORMA MÁS SENCILLA
                 **/
                try
                {
                    this.especialidadesTableAdapter.Delete(idDeporte, dniProfe, grado);
                    this.especialidadesTableAdapter.Fill(this.gimnasioExamenDataSet.especialidades);
                    MessageBox.Show("Registro borrado correctamente");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
                }

                /**
                 * ESTA FORMA ES MÁS COMPLEJA PERO EFECTIVA SI SE DESEA 
                 * TRABAJAR CON FILAS DE LA DATAGRID
                 **/
                //gimnasioExamenDataSet.especialidadesRow row;
                //row = this.gimnasioExamenDataSet.especialidades.FindByid_deportedni(idDeporte, dniProfe);
                //try
                //{
                    
                //   if (row != null)
                //    {
                //        row.Delete();
                //        this.especialidadesTableAdapter.Update(this.gimnasioExamenDataSet);
                //        this.gimnasioExamenDataSet.AcceptChanges();
                //        MessageBox.Show("Registro borrado correctamente");
                //        this.especialidadesTableAdapter.Fill(this.gimnasioExamenDataSet.especialidades);
                //    }
                    
                //}
                //catch (SqlException sqlEx)
                //{
                //    MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
                //}
                #endregion

            }

            try
            {
                //insert
                this.especialidadesTableAdapter.Insert(idDeporte, dniProfe, grado);
                MessageBox.Show("Registro insertado correctamente");
                this.especialidadesTableAdapter.Fill(this.gimnasioExamenDataSet.especialidades);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(BDErrores.controlError((SqlException)sqlEx.InnerException.InnerException));
            }
            
        }


    }
}
