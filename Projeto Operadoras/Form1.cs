using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rad1_vivo_CheckedChanged(object sender, EventArgs e)
        {

            //Colocando a imagem da vivo:
            Pic_operadoras.Image = Properties.Resources.logo_vivo; 
            
            
            //Ativando os label
            Lbl_dados.Enabled = true;
            Lbl_nome.Enabled = true;
            Lbl_bemvindo.Enabled = true;
            Lbl_0p_selecionada.Enabled = true;
            Lbl_ddd.Enabled = true;
            Lbl_n_cel.Enabled = true;
            Lbl_valor_recarga.Enabled = true;
            Lbl_selecione_valor.Enabled = true;
            Lbl_validade1.Enabled = true;
            Lbl_validade2.Enabled = true;
            Lbl_validade3.Enabled = true;
            Lbl_validade4.Enabled = true;
            Lbl_validade5.Enabled = true;
            Lbl_validade6.Enabled = true;
            Lbl_validade7.Enabled = true;
            Lbl_validade8.Enabled = true;

            //Ativar as caixas de texto
            txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_n_celu.Enabled = true;

            //Ativar os botoes
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;

            //Colocando a operadora na operadora selecionada.
            Txt_op_selec.Text = Rad1_vivo.Text;

            //Colocando os valores Vivo:
            Btn1.Text = "12";
            Btn2.Text = "15";
            Btn3.Text = "20";
            Btn4.Text = "30";
            Btn5.Text = "35";
            Btn6.Text = "40";
            Btn7.Text = "100";
            Btn8.Text = "200";

            //Colocando a validade
            Lbl_validade1.Text = "30 dias";
            Lbl_validade2.Text = "30 dias";
            Lbl_validade3.Text = "30 dias";
            Lbl_validade4.Text = "30 dias";
            Lbl_validade5.Text = "90 dias";
            Lbl_validade6.Text = "90 dias";
            Lbl_validade7.Text = "180 dias";
            Lbl_validade8.Text = "365 dias";

            //Mudando o fundo da Tela
            BackColor = Color.DarkViolet;

            //Mudando a cor dos label:

            Lbl_nome.ForeColor = Color.White;
            Lbl_bemvindo.ForeColor = Color.White;
            Lbl_0p_selecionada.ForeColor = Color.White;
            Lbl_ddd.ForeColor = Color.White;
            Lbl_n_cel.ForeColor = Color.White;
            Lbl_valor_recarga.ForeColor = Color.White;
            Lbl_selecione_valor.ForeColor = Color.White;

            //Mudando a cor do Group box e radio buttons:
            Grp1_operadoras.ForeColor = Color.White;
            Rad1_vivo.ForeColor = Color.White;
            Rad2_claro.ForeColor = Color.White;
            Rad3_tim.ForeColor = Color.White;
            Rad4_Oi.ForeColor = Color.White;

            //mudando a cor dos botoes:
            Btn1.FlatAppearance.BorderColor = Color.Violet;
            Btn2.FlatAppearance.BorderColor = Color.Violet;
            Btn3.FlatAppearance.BorderColor = Color.Violet;
            Btn4.FlatAppearance.BorderColor = Color.Violet;
            Btn5.FlatAppearance.BorderColor = Color.Violet;
            Btn6.FlatAppearance.BorderColor = Color.Violet;
            Btn7.FlatAppearance.BorderColor = Color.Violet;
            Btn8.FlatAppearance.BorderColor = Color.Violet;

            //limpando as trocas de operadora:

            Txt_valor_recar.Clear();
        }

        private void Rad2_claro_CheckedChanged(object sender, EventArgs e)
        {
            //Colocando a imagem da claro:
            Pic_operadoras.Image = Properties.Resources.logo_claro;


            //Ativando os label
            Lbl_dados.Enabled = true;
            Lbl_nome.Enabled = true;
            Lbl_bemvindo.Enabled = true;
            Lbl_0p_selecionada.Enabled = true;
            Lbl_ddd.Enabled = true;
            Lbl_n_cel.Enabled = true;
            Lbl_valor_recarga.Enabled = true;
            Lbl_selecione_valor.Enabled = true;
            Lbl_validade1.Enabled = true;
            Lbl_validade2.Enabled = true;
            Lbl_validade3.Enabled = true;
            Lbl_validade4.Enabled = true;
            Lbl_validade5.Enabled = true;
            Lbl_validade6.Enabled = true;
            Lbl_validade7.Enabled = true;
            Lbl_validade8.Enabled = true;

            //Ativar as caixas de texto
            txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_n_celu.Enabled = true;


            //Ativar os botoes
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;

            //Colocando a operadora na operadora selecionada.
            Txt_op_selec.Text = Rad2_claro.Text;

            // Colocando os valores da Claro
            Btn1.Text = "12";
            Btn2.Text = "15";
            Btn3.Text = "20";
            Btn4.Text = "25";
            Btn5.Text = "30";
            Btn6.Text = "35";
            Btn7.Text = "50";
            Btn8.Text = "100";

            //Mudando a cor da fonte dos botoes:

            BackColor = Color.Red;
            //Mudando a cor dos label:

            Lbl_nome.ForeColor = Color.White;
            Lbl_bemvindo.ForeColor = Color.White;
            Lbl_0p_selecionada.ForeColor = Color.White;
            Lbl_ddd.ForeColor = Color.White;
            Lbl_n_cel.ForeColor = Color.White;
            Lbl_valor_recarga.ForeColor = Color.White;
            Lbl_selecione_valor.ForeColor = Color.White;

            //Mudando a cor do Group box e radio buttons:
            Grp1_operadoras.ForeColor = Color.White;
            Rad1_vivo.ForeColor = Color.White;
            Rad2_claro.ForeColor = Color.White;
            Rad3_tim.ForeColor = Color.White;
            Rad4_Oi.ForeColor = Color.White;

            //mudando a cor dos botoes:
            Btn1.FlatAppearance.BorderColor = Color.Black;
            Btn2.FlatAppearance.BorderColor = Color.Black;
            Btn3.FlatAppearance.BorderColor = Color.Black;
            Btn4.FlatAppearance.BorderColor = Color.Black;
            Btn5.FlatAppearance.BorderColor = Color.Black;
            Btn6.FlatAppearance.BorderColor = Color.Black;
            Btn7.FlatAppearance.BorderColor = Color.Black;
            Btn8.FlatAppearance.BorderColor = Color.Black;

            //limpar o valor da recarga:
            Txt_valor_recar.Clear();

        }

        private void Rad3_tim_CheckedChanged(object sender, EventArgs e)
        {

            //Colocando a imagem da tim:
            Pic_operadoras.Image = Properties.Resources.logo_tim;

            Lbl_dados.Enabled = true;
            Lbl_nome.Enabled = true;
            Lbl_0p_selecionada.Enabled = true;
            Lbl_0p_selecionada.Enabled = true;
            Lbl_ddd.Enabled = true;
            Lbl_n_cel.Enabled = true;
            Lbl_valor_recarga.Enabled = true;
            Lbl_selecione_valor.Enabled = true;
            Lbl_validade1.Enabled = true;
            Lbl_validade2.Enabled = true;
            Lbl_validade3.Enabled = true;
            Lbl_validade4.Enabled = true;
            Lbl_validade5.Enabled = true;
            Lbl_validade6.Enabled = true;
            Lbl_validade7.Enabled = true;
            Lbl_validade8.Enabled = true;

            //Ativar as caixas de texto
            txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_n_celu.Enabled = true;

            //Ativar os botoes
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            //Colocando a operadora na operadora selecionada.
            Txt_op_selec.Text = Rad3_tim.Text;

            //Colocando os valores da tim:
            Btn1.Text = "10";
            Btn2.Text = "15";
            Btn3.Text = "20";
            Btn4.Text = "30";
            Btn5.Text = "40";
            Btn6.Text = "50";
            Btn7.Text = "60";
            Btn8.Text = "100";

            // Colocando a cor de fundo da tim
            BackColor = Color.Blue;


            //Mudando a cor dos botoes:
            Btn1.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn2.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn3.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn4.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn5.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn6.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn7.FlatAppearance.BorderColor = Color.RoyalBlue;
            Btn8.FlatAppearance.BorderColor = Color.RoyalBlue;

            //Limpando o valor da recarga:
            Txt_valor_recar.Clear();
        }

        private void Rad4_Oi_CheckedChanged(object sender, EventArgs e)


        {   
            //Colocando a imagem da oi :
            Pic_operadoras.Image = Properties.Resources.logo_oi;

            Lbl_dados.Enabled = true;
            Lbl_nome.Enabled = true;
            Lbl_bemvindo.Enabled = true;
            Lbl_0p_selecionada.Enabled = true;
            Lbl_ddd.Enabled = true;
            Lbl_n_cel.Enabled = true;
            Lbl_valor_recarga.Enabled = true;
            Lbl_selecione_valor.Enabled = true;
            Lbl_validade1.Enabled = true;
            Lbl_validade2.Enabled = true;
            Lbl_validade3.Enabled = true;
            Lbl_validade4.Enabled = true;
            Lbl_validade5.Enabled = true;
            Lbl_validade6.Enabled = true;
            Lbl_validade7.Enabled = true;
            Lbl_validade8.Enabled = true;

            //Ativar as caixas de texto
            txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_n_celu.Enabled = true;


            //Ativar os botoes
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            //Colocando a operadora na operadora selecionada.
            Txt_op_selec.Text = Rad4_Oi.Text;

            //Colocando os valores da Oi.
            Btn1.Text = "10";
            Btn2.Text = "15";
            Btn3.Text = "20";
            Btn4.Text = "25";
            Btn5.Text = "30";
            Btn6.Text = "35";
            Btn7.Text = "40";
            Btn8.Text = "50";

            //Colocando a cor de fundo da oi:
            BackColor = Color.Orange;

            //mudando a cor dos botoes:
            Btn1.FlatAppearance.BorderColor = Color.Gold;
            Btn2.FlatAppearance.BorderColor = Color.Gold;
            Btn3.FlatAppearance.BorderColor = Color.Gold;
            Btn4.FlatAppearance.BorderColor = Color.Gold;
            Btn5.FlatAppearance.BorderColor = Color.Gold;
            Btn6.FlatAppearance.BorderColor = Color.Gold;
            Btn7.FlatAppearance.BorderColor = Color.Gold;
            Btn8.FlatAppearance.BorderColor = Color.Gold;

            //Limpando o valor da recarga:
            Txt_valor_recar.Clear();

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //Colocando o valor das recargas:
            Txt_valor_recar.Text = Btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //Colcando o valor das recargas:
            Txt_valor_recar.Text = Btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //Colocando o valor das recarga na caixa de texto:
            Txt_valor_recar.Text = Btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            //Colcando o valor das recarga na caixa de texto:
            Txt_valor_recar.Text = Btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            //Colocando o valor da recarga na caixa de texto:
            Txt_valor_recar.Text = Btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            //colocando o valor da recarga na caixa de texto:
            Txt_valor_recar.Text = Btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //Colocando o valor da recarga na caixa de texto:
            Txt_valor_recar.Text = Btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            //Colocando o valor da recarga na caixa de texto:
            Txt_valor_recar.Text = Btn8.Text;
        }
    }
}
