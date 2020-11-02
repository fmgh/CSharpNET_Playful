using System;
using System.Drawing;
using System.Windows.Forms;

namespace RelojDigital
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Funciones 

        /// <summary>
        /// Retorna la hora de acuerdo al parámetro de tipo String enviado.
        /// </summary>
        /// <param name="tipoHora">Solo acepta los siguiente valores para evaluar: "Ver Hora Convencional" o "Ver Hora Militar"</param>
        private void EstablecerHora(string tipoHora)
        {
            switch (tipoHora)
            {
                case "Ver Hora Convencional":
                    this.Text = "Reloj Digital - Visualizacion : Hora Militar";
                    btnTipoHora.Text = "Ver Hora Convencional";
                    lblHora.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second} Hrs";
                    lblHora.Location = new Point(12, 9);
                    break;
                case "Ver Hora Militar":
                    this.Text = "Reloj Digital - Visualizacion : Hora Convencional";
                    btnTipoHora.Text = "Ver Hora Militar";
                    lblHora.Text = DateTime.Now.ToLongTimeString();
                    lblHora.Left = (this.Width - lblHora.Width) / 2;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Centra el formulario, inicia un temporizador por segundo y establece la hora.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            EstablecerHora(Properties.Settings.Default.TipoHora);
            Timer timer = new Timer() { Interval = 1000 };
            timer.Tick += (s, ev) =>
            {
                EstablecerHora(btnTipoHora.Text);
            };
            timer.Start();
        }        

        /// <summary>
        /// Cambia el tipo de hora y la visualización de esta en la interfaz.
        /// </summary>
        private void btnTipoHora_Click(object sender, EventArgs e)
        {
            if (btnTipoHora.Text == "Ver Hora Convencional")
                btnTipoHora.Text = "Ver Hora Militar";
            else
                btnTipoHora.Text = "Ver Hora Convencional";

            EstablecerHora(btnTipoHora.Text);
        }

        /// <summary>
        /// Se guarda en los settings internos de la aplicación, el ultimo tipo de hora mostrado.
        /// </summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TipoHora = (btnTipoHora.Text == "Ver Hora Convencional") ? "Ver Hora Convencional" : "Ver Hora Militar";
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
