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

        private void Main_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            EstablecerHora(Properties.Settings.Default.TipoHora);
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void EstablecerHora(string tipoHora)
        {
            switch (tipoHora)
            {
                case "Ver Hora Convencional":
                    this.Text = "Reloj Digital - Hora Militar";
                    btnTipoHora.Text = "Ver Hora Convencional";
                    lblHora.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second} Hrs";
                    lblHora.Location = new Point(12, 9);                    
                    break;
                case "Ver Hora Militar":
                    this.Text = "Reloj Digital - Hora Convencional";
                    btnTipoHora.Text = "Ver Hora Militar";
                    lblHora.Text = DateTime.Now.ToLongTimeString();
                    lblHora.Left = (this.Width - lblHora.Width) / 2;
                    break;
                default:
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            EstablecerHora(btnTipoHora.Text);
        }

        private void btnTipoHora_Click(object sender, EventArgs e)
        {
            if (btnTipoHora.Text == "Ver Hora Convencional")
                btnTipoHora.Text = "Ver Hora Militar";
            else
                btnTipoHora.Text = "Ver Hora Convencional";

            EstablecerHora(btnTipoHora.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TipoHora = (btnTipoHora.Text == "Ver Hora Convencional") ? "Ver Hora Convencional" : "Ver Hora Militar";
            Properties.Settings.Default.Save();
        }
    }
}
