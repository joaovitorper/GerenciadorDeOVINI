using BibliotecaOVNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVINI
{
    public partial class Gerenciador : Form
    {
        public Gerenciador(BibliotecaOVNI.OVNI ovni) // obrigatoriamente deve -se iniciar passando um OVNI
        {
            InitializeComponent();
            // "copiando o ovni visando da outra janela para um objeto Global
            this.ovni = ovni;

            // atualizar as informações
            Atualizarinformacoes();
            // Popular o Combobox com os planetas validos
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }
        // objetos Globais 
        BibliotecaOVNI.OVNI ovni;
        public void Atualizarinformacoes()
        {
         lblTripulantes.Text = $"Tripulantes:{ovni.QtdTripulantes}";
         lblAbduzidos.Text = $"Abduzidos:{ovni.QtdAbduzidos}";
         lblSituacao.Text = $"Situação:{(ovni.Situacao ? "Ligado" : "Desligado")}";
         lblPlaneta.Text = $"Planeta Atual:{ovni.PlanetaAtual}";
         cmbPlanetas.Text = ovni.PlanetaAtual;
            if (ovni.PlanetaAtual == "Terra")

            // Mudar a imagem:
            {
                pibTerra.Image = Properties.Resources.terra;

            }
            else 
            {
             pibTerra.Image = null;
            }
          

           
            // Atualizar os Botões ligar e Desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;

            //Ativar ou Desativar o grb de acordo com o Status da Nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;
        }   
           
            
        
        
    
       

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("ovni foi ligado!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("O OVNI já esta ligado!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informações
            Atualizarinformacoes();
        }
       
        

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("ovni foi Desligado!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("O OVNI já esta Desligado!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informações
            Atualizarinformacoes();
        }

        private void btnAdicionarTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulantes Adicionado!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A nave já esta lotada de Tripulantes!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulantes Removido!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Não é possivel mais Remover Tripulantes!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Atualizarinformacoes();


        }

        private void btnAdicionarAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("algo Foi Extremamente Abduzido!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" nao foi possivel abduzir!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Atualizarinformacoes();

        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("o Ser foi possivel ser Desabiduzidos!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                      
            else
            {
                MessageBox.Show(" nao foi possivel abduzir!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Atualizarinformacoes();
        }

        private void btnMudarDePlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text)) 
            {
                MessageBox.Show("Você mudou de Planeta!",
               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" Não foi possivel mudar de Planeta!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Atualizarinformacoes();
        }
    }
    }
    
    

