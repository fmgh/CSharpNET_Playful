using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MetrónomoDigital
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Timer _temporizador = new Timer();
        int _contadorDeGolpeo = 0;

        /// <summary>
        /// Centra la app en la pantalla. Obtiene el ultimo valor de los ajustes de la aplicacion.
        /// </summary>
        private void Principal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblValorActual.Text = Properties.Settings.Default.GolpesPorMinuto;
            hSBGolpes.Value = int.Parse(Properties.Settings.Default.GolpesPorMinuto);
        }

        /// <summary>
        /// Establece el numero de golpes por minuto.
        /// </summary>
        private void hSBGolpes_Scroll(object sender, ScrollEventArgs e)
        {
            _temporizador.Stop();
            lblValorActual.Text = hSBGolpes.Value.ToString();

            osEncendido.FillColor = Color.Green;
            osApagado.FillColor = Color.Red;
            btnEncender.Enabled = true;
            btnApagar.Enabled = false;
        }

        /// <summary>
        /// Guarda el ultimo valor de golpes en los ajustes de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.GolpesPorMinuto = hSBGolpes.Value.ToString();
            Properties.Settings.Default.Save();
        }
        
        /// <summary>
        /// Establece el intervalo del sonido y llama al evento Tick del temporizador.
        /// </summary>
        private void btnEncender_Click(object sender, EventArgs e)
        {
            osEncendido.FillColor = Color.Lime;
            osApagado.FillColor = Color.Maroon;

            btnEncender.Enabled = false;
            btnApagar.Enabled = true;
            btnApagar.Focus();

            _temporizador.Interval = 60000 / hSBGolpes.Value;
            _temporizador.Tick -= _temporizador_Tick;
            _temporizador.Tick += _temporizador_Tick;
            _temporizador.Start();
        }

        /// <summary>
        /// Ejecuta el sonido del metrónomo.
        /// </summary>
        private void _temporizador_Tick(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.metronom_klack;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlaySync();

            _contadorDeGolpeo++;
            lblContador.Text = _contadorDeGolpeo.ToString();
        }

        /// <summary>
        /// Detiene el temporizador / metrónomo.
        /// </summary>
        private void btnApagar_Click(object sender, EventArgs e)
        {
            osEncendido.FillColor = Color.Green;
            osApagado.FillColor = Color.Red;

            btnEncender.Enabled = true;
            btnApagar.Enabled = false;

            _contadorDeGolpeo = 0;
            _temporizador.Stop();
        }
    }
}
