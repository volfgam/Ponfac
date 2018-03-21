using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ponfac3
{
    public partial class Form1 : Form
    {
        public Dictionary<string, char[]> ListaProcessados { get; set; }
        public Form1()
        {
            InitializeComponent();
            TimeAleatorio();
            ListaProcessados = new Dictionary<string, char[]>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var palavra = GeraStringRamdomica();

            ltbGerado.Items.Insert(0, palavra);
        }

        public string GeraStringRamdomica()
        {
            var random = new Random();
            string id = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 100)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
            return id;
        }

        //Gera time aleatório entre 300 e 1000ms
        public void TimeAleatorio()
        {
            var random = new Random();
            var time = random.Next(300, 1000);

            timer2.Interval = time;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Verifica se tem alum item na lista dos gerados
            if (ltbGerado.Items.Count > 0)
            {
                //Seleciona o primeiro item gerado
                ltbGerado.SetSelected(ltbGerado.Items.Count - 1, true);
                //Pega o valor o item selecionado
                var valorSelecionado = ltbGerado.SelectedItem.ToString();
                //retira da fila o item selecionado
                ltbGerado.Items.RemoveAt(ltbGerado.SelectedIndex);
                //Processa o item 
                var letrasMaisUsadas = RetornaLetraMaisFrequente(valorSelecionado);
                //insere na lista de processadas 
                ltbProcessadas.Items.Insert(0, valorSelecionado);
                ListaProcessados.Add(valorSelecionado, letrasMaisUsadas);
                TimeAleatorio();
            }
        }

        private char[] RetornaLetraMaisFrequente(string str)
        {
            //faz um dicionario chave valor 
            Dictionary<char, int> chars = new Dictionary<char, int>();

            //percorre cada letra
            foreach (char c in str)
            {
                if (chars.ContainsKey(c))
                {
                    chars[c]++;
                }
                else
                {
                    chars.Add(c, 1);
                }
            }
            //Pega a quantidade maxima de vezes que uma letra se repetiu
            int max = chars.Values.Max();
            //Pegar todas as letras que se repetem o maximo de vezes
            return chars.Where(b => b.Value == max).Select(b => b.Key).ToArray();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ltbProcessadas.Items.Count > 0)
            {
                //pega ultimo item da lista de processados 
                var item = ltbProcessadas.Items[ltbProcessadas.Items.Count - 1];
                //Pega ultimo item processado
                var itemDicionario = ListaProcessados[item.ToString()];
                //Se o grid tem mais de 100 items tira o ultimo 
                if (dataGridView1.Rows.Count >= 100)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count -1]);
                }
                //Alimenta Grid 
                dataGridView1.Rows.Insert(0, item.ToString(), new String(itemDicionario.ToArray()));
                //remove item da lista de processados
                ltbProcessadas.Items.Remove(item);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PararIniciar(true);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            PararIniciar(false);
        }

        private void PararIniciar(bool acao)
        {
            timer1.Enabled = acao;
            timer2.Enabled = acao;
            timer3.Enabled = acao;
        }

        private void btnNovoCiclo_Click(object sender, EventArgs e)
        {
            PararIniciar(false);
            TimeAleatorio();
            LimpaListBox(ltbGerado);
            LimpaListBox(ltbProcessadas);
            dataGridView1.Rows.Clear();
        }

        private   void LimpaListBox(ListBox listBox)
        {
            for (int n = listBox.Items.Count - 1; n >= 0; --n)
            {
                listBox.Items.RemoveAt(n);
            }
        }
    }

}
