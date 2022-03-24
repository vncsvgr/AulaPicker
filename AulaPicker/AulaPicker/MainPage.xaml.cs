using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AulaPicker
{
    public partial class MainPage : ContentPage
    {
        List<string> estadoCivil = new List<string>
        {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Divorciado"
        };

        List<Curso> curso = new List<Curso>
        {
            new Curso {Nome="DESENVOLVIMENTO", Periodo="NOTURNO"},
            new Curso {Nome="ADMINISTRACAO", Periodo="NOTURNO"},
            new Curso {Nome="NUTRICAO", Periodo="NOTURNO"},
            new Curso {Nome="ETIM MECATRONICA", Periodo="DIURNO"},
            new Curso {Nome="ETIM EDIFICACOES", Periodo="DIURNO"}
        };

        public MainPage()
        {
            InitializeComponent();

            pckEstadoCivil.ItemsSource = estadoCivil;

            pckCurso.ItemsSource = curso;
        }

        private void pckEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAlert("Mensagem", pckEstadoCivil.SelectedItem.ToString(), "OK");
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            Curso c = curso.Find(x => x.Nome == pckCurso.Items[pckCurso.SelectedIndex].ToString());
            lblCurso.Text = c.Nome;
            lblPeriodo.Text = c.Periodo;
        }
    }
}
