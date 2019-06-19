using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Controllers;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Views
{
    public partial class Atendimento : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();
        public Atendimento()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            lbxSenhas.Items.Add("Senha Gerada");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblNumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {

            var index = Int32.Parse(txtGuiche.Text) - 1;
            if (!guiches.ListaGuiches[index].chamar(senhas.FilaSenhas))
            {
                lbxSenhasGuiche.Items.Clear();
                lbxSenhasGuiche.Items.Add("Você não chamou nenhum guichê");
            }
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lbxSenhas.Items.Clear();
            senhas.FilaSenhas.ToList().ForEach(i => lbxSenhas.Items.Add(i.dadosParciais()));
        }

        private void btnListarAtend_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            lbxSenhasGuiche.Items.Clear();
            guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => lbxSenhasGuiche.Items.Add(i.dadosCompletos()));
            lbxSenhasGuiche.Items.Add("Fim da Lista");
        }
    }

    
}
