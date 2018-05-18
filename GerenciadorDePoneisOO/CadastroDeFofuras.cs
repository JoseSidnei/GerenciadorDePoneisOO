using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDePoneisOO
{
    public partial class CadastroDeFofuras : Form
    {
        List<Poney> poneys = new List<Poney>();
        public CadastroDeFofuras()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
              if (txtApelido.Text == "")
            {
                MessageBox.Show("Digite o apelido");
                return;
            }

              if (cbRaca.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a raca");
                return;
            }

            if (cbCorCrista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a cor da crista");
                return;
            }

            if (rbVivo.Checked == false && rbMorto.Checked == false)
            {
                MessageBox.Show("Informe s eesta vivo ou morto");
                return;
            }

            if (cbLocalidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a localidade");
                return;
            }

           
            Poney poney = new Poney();
            poney.Apelido = txtApelido.Text;
            poney.CorCrista = cbCorCrista.SelectedItem.ToString();
            poney.Dancarino = cbDancarino.Checked;
            poney.Localidade = cbLocalidade.SelectedItem.ToString();
            poney.NivelFofura = tbNivelFofura.Value;
            poney.VendaVivo = rbVivo.Checked;
            poney.Descricao = rtDescricao.Text;
            poney.Raca = cbRaca.SelectedItem.ToString();
            poneys.Add(poney);
            dgvPoneys.Rows.Add(new Object[] { poney.Apelido, poney.Raca });
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            rtDescricao.Text = "";
            cbCorCrista.SelectedIndex = -1;
            cbLocalidade.SelectedIndex = -1;
            cbRaca.SelectedIndex = -1;
            cbDancarino.Checked = false;
            rbVivo.Checked = false;
            rbMorto.Checked = false;
            tbNivelFofura.Value = tbNivelFofura.Minimum;
        }

       
    }
}
