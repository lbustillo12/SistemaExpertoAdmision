using System;
using System.Windows.Forms;

namespace SistemaExpertoAdmision
{
    public partial class Form1 : Form
    {
        // Instancia  del Motor de Inferencia
        private MotorInferencia motor = new MotorInferencia();
        private int contadorAspirantes = 0;
        private const int LIMITE = 10;

        public Form1()
        {
            InitializeComponent();

            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            
                dgvresultado.Columns.Clear();
                dgvresultado.Columns.Add("Nombre", "Nombre del Aspirante");
                dgvresultado.Columns.Add("Mat", "Nota Matemáticas");
                dgvresultado.Columns.Add("Psi", "Nota Psicología");
                dgvresultado.Columns.Add("Resultado", "Acción (Inferencia)");
                dgvresultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblConta.Text = $"Aspirantes: {contadorAspirantes} / {LIMITE}";
        }

        private void Btnregistro_Click_1(object sender, EventArgs e)
        {
            // Validar que no pase del límite de 10
            if (contadorAspirantes >= LIMITE)
            {
                MessageBox.Show("Ya se han procesado los 10 aspirantes.", "Límite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar que los campos de texto no estén vacíos y tengan números válidos
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre) ||
                !double.TryParse(txtMatematicas.Text, out double mat) ||
                !double.TryParse(txtPsicologia.Text, out double psi))
            {
                MessageBox.Show("Por favor, llene todos los campos con datos válidos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            HechoAspirante hechosActuales = new HechoAspirante
            {
                NotaMatematica = mat,
                NotaPsicologica = psi
            };

            //  Invocar al Motor de Inferencia para obtener la deducción lógica
            string resultadoInferencia = motor.Evaluar(hechosActuales);

            // Agregar los datos y el veredicto del motor al DataGridView
            dgvresultado.Rows.Add(nombre, mat, psi, resultadoInferencia);

            //  Actualizar el contador de la interfaz
            contadorAspirantes++;
            lblConta.Text = $"Aspirantes: {contadorAspirantes} / {LIMITE}";

           
            LimpiarCampos();

            
            if (contadorAspirantes == LIMITE)
            {
                BloquearControles();
                MessageBox.Show("¡Muestra de 10 aspirantes completada a través del Motor de Inferencia!", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMatematicas.Clear();
            txtPsicologia.Clear();
            txtNombre.Focus(); 
        }

        private void BloquearControles()
        {
            txtNombre.Enabled = false;
            txtMatematicas.Enabled = false;
            txtPsicologia.Enabled = false;
            Btnregistro.Enabled = false;
        }

        private void dgvresultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
