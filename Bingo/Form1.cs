using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {

        Random r = new Random();

        int numeroSorteado;

        int[] repetidos = new int[75];
        int indice;

        public Form1() {
            InitializeComponent();
         
        }

            private void Reiniciar() {
            repetidos = new int[75];
            indice = 0;
            timer.Enabled = false;
            btIniciar.Text = "REINICIAR";
            btIniciar.Enabled = true;
            btBingo.Enabled = false;

        }
            
       

   


        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }


        //Número sorteadonu

        private void nSorteado_Click(object sender, EventArgs e) {

        }

        //Evento do Timer
        private void timer1_Tick(object sender, EventArgs e) {


            //Não repetir o número sorteado
            do {

                numeroSorteado = r.Next(1, 75);

            } while (repetidos.Contains(numeroSorteado));
            nSorteado.Text = numeroSorteado.ToString();
            repetidos[indice] = numeroSorteado;
            indice++;




                                //Cartela do computador

            //B do Bingo

            if (int.Parse(b1C.Text) == numeroSorteado) {
              
                b1C.Enabled = false;
            }
            if (int.Parse(b2C.Text) == numeroSorteado) {
                
                b2C.Enabled = false;
            }
            if (int.Parse(b3C.Text) == numeroSorteado) {
             
                b3C.Enabled = false;
            }
            if (int.Parse(b4C.Text) == numeroSorteado) {
            
                b4C.Enabled = false;
            }
            if (int.Parse(b5C.Text) == numeroSorteado) {
        
                b5C.Enabled = false;
            }


            //I do Bingo

            if (int.Parse(i1C.Text) == numeroSorteado) {
              
                i1C.Enabled = false;
            }
            if (int.Parse(i2C.Text) == numeroSorteado) {
            
                i2C.Enabled = false;
            }
            if (int.Parse(i3C.Text) == numeroSorteado) {
              
                i3C.Enabled = false;
            }
            if (int.Parse(i4C.Text) == numeroSorteado) {
             
                i4C.Enabled = false;
            }
            if (int.Parse(i5C.Text) == numeroSorteado) {
              
                i5C.Enabled = false;
            }

            //N do Bingo

            if (int.Parse(n1C.Text) == numeroSorteado) {
             
                n1C.Enabled = false;
            }
            if (int.Parse(n2C.Text) == numeroSorteado) {
              
                n2C.Enabled = false;
            }
            if (int.Parse(n4C.Text) == numeroSorteado) {
             
                n4C.Enabled = false;
            }
            if (int.Parse(n5C.Text) == numeroSorteado) {
          
                n5C.Enabled = false;
            }

            //G do Bingo

            if (int.Parse(g1C.Text) == numeroSorteado) {
                
                g1C.Enabled = false;
            }
            if (int.Parse(g2C.Text) == numeroSorteado) {
               
                g2C.Enabled = false;
            }
            if (int.Parse(g3C.Text) == numeroSorteado) {
            
                g3C.Enabled = false;
            }
            if (int.Parse(g4C.Text) == numeroSorteado) {
              
                g4C.Enabled = false;
            }
            if (int.Parse(g5C.Text) == numeroSorteado) {
               
                g5C.Enabled = false;
            }

            //O do Bingo

            if (int.Parse(o1C.Text) == numeroSorteado) {
                
                o1C.Enabled = false;
            }
            if (int.Parse(o2C.Text) == numeroSorteado) {
              
                o2C.Enabled = false;
            }
            if (int.Parse(o3C.Text) == numeroSorteado) {
             
                o3C.Enabled = false;
            }
            if (int.Parse(o4C.Text) == numeroSorteado) {
                
                o4C.Enabled = false;
            }
            if (int.Parse(o5C.Text) == numeroSorteado) {
               
                o5C.Enabled = false;
            }



            //JOGO DO COMPUTADOR


            //Caso ganhe no B vertical
            if (!b1C.Enabled && !b2C.Enabled && !b3C.Enabled && !b4C.Enabled
                && !b5C.Enabled) {

                Reiniciar();
                MessageBox.Show("Computador ganhou!");


            }

            //Caso ganhe no I vertical

            if (!i1C.Enabled && !i2C.Enabled && !i3C.Enabled && !i4C.Enabled
                && !i5C.Enabled) {

                Reiniciar();
                MessageBox.Show("Computador ganhou!");

            }

            //Caso N ganhe vertical

            if (!n1C.Enabled && !n2C.Enabled && !n4C.Enabled
               && !n5C.Enabled) {


                Reiniciar();
                MessageBox.Show("Computador ganhou!");

            }

            //Caso G ganhe vertical

            if (!g1C.Enabled && !i2C.Enabled && !g3C.Enabled && !g4C.Enabled
                && !g5C.Enabled) {


                Reiniciar();
                MessageBox.Show("Computador ganhou!");

            }

            if (!o1C.Enabled && !o2C.Enabled && !o3C.Enabled && !o4C.Enabled
                && !o5C.Enabled) {

                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }


            //  CASO O COMPUTADOR GANHE NA HORIZONTAL

            if(!b1C.Enabled && !i1C.Enabled && !n1C.Enabled && !g1C.Enabled && !o1C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }
            if (!b2C.Enabled && !i2C.Enabled && !n2C.Enabled && !g2C.Enabled && !o2C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }
            if (!b3C.Enabled && !i3C.Enabled && !g3C.Enabled && !o3C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }
            if (!b4C.Enabled && !i4C.Enabled && !n4C.Enabled && !g4C.Enabled && !o4C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }
            if (!b5C.Enabled && !i5C.Enabled && !n5C.Enabled && !g5C.Enabled && !o5C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }


            // CASO O COMPUTADOR GANHE NA DIAGONAL

            if(!b1C.Enabled && !i2C.Enabled && !g4C.Enabled && !o5C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }
            if(!b5C.Enabled && !i4C.Enabled && !g2C.Enabled && !o1C.Enabled) {
                Reiniciar();
                MessageBox.Show("Computador ganhou!");
            }



        }


        //Evento do botão iniciar

        private void btIniciar_Click(object sender, EventArgs e) {

            btIniciar.Enabled = false;

            nSorteado.Enabled = true;
            btBingo.Enabled = true;
            timer.Enabled = true;
            
            //B do Bingo
            b1P.Enabled = true;
            b2P.Enabled = true;
            b3P.Enabled = true;
            b4P.Enabled = true;
            b5P.Enabled = true;
            b1C.Enabled = true;
            b2C.Enabled = true;
            b3C.Enabled = true;
            b4C.Enabled = true;
            b5C.Enabled = true;
            
            //I do Bingo
            i1P.Enabled = true;
            i2P.Enabled = true;
            i3P.Enabled = true;
            i4P.Enabled = true;
            i5P.Enabled = true;
            i1C.Enabled = true;
            i2C.Enabled = true;
            i3C.Enabled = true;
            i4C.Enabled = true;
            i5C.Enabled = true;
            
            //N do Bingo
            n1P.Enabled = true;
            n2P.Enabled = true;
            n4P.Enabled = true;
            n5P.Enabled = true;
            n1C.Enabled = true;
            n2C.Enabled = true;
            n4C.Enabled = true;
            n5C.Enabled = true;

            //G do Bingo
            g1P.Enabled = true;
            g2P.Enabled = true;
            g3P.Enabled = true;
            g4P.Enabled = true;
            g5P.Enabled = true;
            g1C.Enabled = true;
            g2C.Enabled = true;
            g3C.Enabled = true;
            g4C.Enabled = true;
            g5C.Enabled = true;

            //O do Bingo
            o1P.Enabled = true;
            o2P.Enabled = true;
            o3P.Enabled = true;
            o4P.Enabled = true;
            o5P.Enabled = true;
            o1C.Enabled = true;
            o2C.Enabled = true;
            o3C.Enabled = true;
            o4C.Enabled = true;
            o5C.Enabled = true;

            //Lista numero aleatórios B Jogador

            int[] listaBP = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(1, 16);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaBP[x]) {
                        add = false;
                        break;
                    }
                }
                if (add == true) {
                    listaBP[i] = nSorteado1;
                } else {
                    i--;
                }
            }


            //Lista numero aleatórios I Jogador

            int[] listaIP = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(16, 36);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaIP[x]) {
                        add = false;
                        break;
                    }
                }
                if (add == true) {
                    listaIP[i] = nSorteado1;
                } else {
                    i--;
                }
            }


            //Lista número aleatório N Jogador

            int[] listaNP = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(36, 46);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaNP[x]) {
                        add = false;
                        break;
                    }
                }
                if (add == true) {
                    listaNP[i] = nSorteado1;
                } else {
                    i--;
                }
            }

            //Lista número aleatórios G jogador

            int[] listaGP = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(46, 61);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaGP[x]) {
                        add = false;
                        break;
                    }
                }
                if (add == true) {
                    listaGP[i] = nSorteado1;
                } else {
                    i--;
                }
            }

            //Lista numero aleatorio O Jogador

            int[] listaOP = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(61, 76);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaOP[x]) {
                        add = false;
                        break;
                    }
                }
                if (add == true) {
                    listaOP[i] = nSorteado1;
                } else {
                    i--;
                }
            }



            //Adicionando os números aleatórios nos botões do Player



            //B do Bingo
            b1P.Text = listaBP[0].ToString();
            b2P.Text = listaBP[1].ToString();
            b3P.Text = listaBP[2].ToString();
            b4P.Text = listaBP[3].ToString();
            b5P.Text = listaBP[4].ToString();

            //I do Bingo

            i1P.Text = listaIP[0].ToString();
            i2P.Text = listaIP[1].ToString();
            i3P.Text = listaIP[2].ToString();
            i4P.Text = listaIP[3].ToString();
            i5P.Text = listaIP[4].ToString();

            //N do Bingo

            n1P.Text = listaNP[0].ToString();
            n2P.Text = listaNP[1].ToString();
            n4P.Text = listaNP[2].ToString();
            n5P.Text = listaNP[3].ToString();

            //G do Bingo

            g1P.Text = listaGP[0].ToString();
            g2P.Text = listaGP[1].ToString();
            g3P.Text = listaGP[2].ToString();
            g4P.Text = listaGP[3].ToString();
            g5P.Text = listaGP[4].ToString();

            //O do Bingo

            o1P.Text = listaOP[0].ToString();
            o2P.Text = listaOP[1].ToString();
            o3P.Text = listaOP[2].ToString();
            o4P.Text = listaOP[3].ToString();
            o5P.Text = listaOP[4].ToString();




            //Lista de numeros aleatórios B Computador

            int[] listaBC = new int[5];

            for(int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(1, 16);

                for(int x = 0; x < 5; x++) {
                    if(nSorteado1 == listaBC[x]) {
                        add = false;
                        break;
                    }
                }

                if(add == true) {
                    listaBC[i] = nSorteado1;
                } else {
                    i--;
                }
            }


            //Lista de numeros aleatórios I Computador

            int[] listaIC = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(16, 36);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaIC[x]) {
                        add = false;
                        break;
                    }
                }

                if (add == true) {
                    listaIC[i] = nSorteado1;
                } else {
                    i--;
                }
            }





            //Lista de numeros aleatórios N Computador

            int[] listaNC = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(36, 46);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaNC[x]) {
                        add = false;
                        break;
                    }
                }

                if (add == true) {
                    listaNC[i] = nSorteado1;
                } else {
                    i--;
                }
            }

            //Lista de numeros aleatórios G Computador

            int[] listaGC = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(46, 61);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaGC[x]) {
                        add = false;
                        break;
                    }
                }

                if (add == true) {
                    listaGC[i] = nSorteado1;
                } else {
                    i--;
                }
            }

            //Lista de numeros aleatórios O Computador

            int[] listaOC = new int[5];

            for (int i = 0; i < 5; i++) {
                Boolean add = true;
                int nSorteado1 = r.Next(61, 76);

                for (int x = 0; x < 5; x++) {
                    if (nSorteado1 == listaOC[x]) {
                        add = false;
                        break;
                    }
                }

                if (add == true) {
                    listaOC[i] = nSorteado1;
                } else {
                    i--;
                }
            }


            //Adicionando os números nos botões da tabela Computador

            //B do Bingo
            b1C.Text = listaBC[0].ToString();
            b2C.Text = listaBC[1].ToString();
            b3C.Text = listaBC[2].ToString();
            b4C.Text = listaBC[3].ToString();
            b5C.Text = listaBC[4].ToString();

            //I do Bingo

            i1C.Text = listaIC[0].ToString();
            i2C.Text = listaIC[1].ToString();
            i3C.Text = listaIC[2].ToString();
            i4C.Text = listaIC[3].ToString();
            i5C.Text = listaIC[4].ToString();

            //N do Bingo

            n1C.Text = listaNC[0].ToString();
            n2C.Text = listaNC[1].ToString();
            n4C.Text = listaNC[2].ToString();
            n5C.Text = listaNC[3].ToString();

            //G do Bingo

            g1C.Text = listaGC[0].ToString();
            g2C.Text = listaGC[1].ToString();
            g3C.Text = listaGC[2].ToString();
            g4C.Text = listaGC[3].ToString();
            g5C.Text = listaGC[4].ToString();

            //O do Bingo

            o1C.Text = listaOC[0].ToString();
            o2C.Text = listaOC[1].ToString();
            o3C.Text = listaOC[2].ToString();
            o4C.Text = listaOC[3].ToString();
            o5C.Text = listaOC[4].ToString();
            



        }

        //Verificando o B1 ao B5

        private void b1P_Click(object sender, EventArgs e) {

            if(int.Parse(b1P.Text) == numeroSorteado) {
        
                b1P.Enabled = false;
            }

        }

        private void b2P_Click(object sender, EventArgs e) {

            if (int.Parse(b2P.Text) == numeroSorteado) {
           
                b2P.Enabled = false;
            }

        }

        private void b3P_Click(object sender, EventArgs e) {
            if (int.Parse(b3P.Text) == numeroSorteado) {
             
                b3P.Enabled = false;
            }
        }

        private void b4P_Click(object sender, EventArgs e) {
            if (int.Parse(b4P.Text) == numeroSorteado) {
           
                b4P.Enabled = false;
            }
        }

        private void b5P_Click(object sender, EventArgs e) {
            if (int.Parse(b5P.Text) == numeroSorteado) {
            
                b5P.Enabled = false;
            }
        }

        //Verificando I1 ao I5


        private void i1P_Click(object sender, EventArgs e) {
            if (int.Parse(i1P.Text) == numeroSorteado) {
              
                i1P.Enabled = false;
                
            }
        }

        private void i2P_Click(object sender, EventArgs e) {
            if (int.Parse(i2P.Text) == numeroSorteado) {
          
                i2P.Enabled = false;
            }
        }

        private void i3P_Click(object sender, EventArgs e) {
            if (int.Parse(i3P.Text) == numeroSorteado) {
           
                i3P.Enabled = false;
            }
        }

        private void i4P_Click(object sender, EventArgs e) {
            if (int.Parse(i4P.Text) == numeroSorteado) {
             
                i4P.Enabled = false;
            }
        }

        private void i5P_Click(object sender, EventArgs e) {
            if (int.Parse(i5P.Text) == numeroSorteado) {
            
                i5P.Enabled = false;
            }
        }

        //Verificando o N1 ao N5

        private void n1P_Click(object sender, EventArgs e) {

            if (int.Parse(n1P.Text) == numeroSorteado) {
              
                n1P.Enabled = false;
            }


        }

        private void n2P_Click(object sender, EventArgs e) {

            if (int.Parse(n2P.Text) == numeroSorteado) {
               
                n2P.Enabled = false;
            }

        }

        private void n4P_Click(object sender, EventArgs e) {
            if (int.Parse(n4P.Text) == numeroSorteado) {
                n4P.ForeColor = Color.Red;
                n4P.Enabled = false;
            }
        }

        private void n5P_Click(object sender, EventArgs e) {
            if (int.Parse(n5P.Text) == numeroSorteado) {
          
                n5P.Enabled = false;
            }
        }

        //Verificando G1 ao G5

        private void g1P_Click(object sender, EventArgs e) {
            if (int.Parse(g1P.Text) == numeroSorteado) {
              
                g1P.Enabled = false;
            }
        }

        private void g2P_Click(object sender, EventArgs e) {
            if (int.Parse(g2P.Text) == numeroSorteado) {
             
                g2P.Enabled = false;
            }
        }

        private void g3P_Click(object sender, EventArgs e) {
            if (int.Parse(g3P.Text) == numeroSorteado) {
              
                g3P.Enabled = false;
            }
        }

        private void g4P_Click(object sender, EventArgs e) {
            if (int.Parse(g4P.Text) == numeroSorteado) {
             
                g4P.Enabled = false;
            }
        }

        private void g5P_Click(object sender, EventArgs e) {
            if (int.Parse(g5P.Text) == numeroSorteado) {
              
                g5P.Enabled = false;
            }
        }

        //Verificando O1 ao O5

        private void o1P_Click(object sender, EventArgs e) {
            if (int.Parse(o1P.Text) == numeroSorteado) {
        
                o1P.Enabled = false;
            }

        }

        private void o2P_Click(object sender, EventArgs e) {
            if (int.Parse(o2P.Text) == numeroSorteado) {
              
                o2P.Enabled = false;
            }
        }

        private void o3P_Click(object sender, EventArgs e) {
            if (int.Parse(o3P.Text) == numeroSorteado) {
              
                o3P.Enabled = false;
            }
        }

        private void o4P_Click(object sender, EventArgs e) {
            if (int.Parse(o4P.Text) == numeroSorteado) {
             
                o4P.Enabled = false;
            }
        }

        private void o5P_Click(object sender, EventArgs e) {
            if (int.Parse(o5P.Text) == numeroSorteado) {
               
                o5P.Enabled = false;
            }
        }



        //BINGO!!

        private void btBingo_Click(object sender, EventArgs e) {

            //Caso ganhe no B vertical
            if (!b1P.Enabled && !b2P.Enabled && !b3P.Enabled && !b4P.Enabled
                && !b5P.Enabled) {

                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");


            }

            //Caso ganhe no I vertical

           else if (!i1P.Enabled && !i2P.Enabled && !i3P.Enabled && !i4P.Enabled
                && !i5P.Enabled) {

                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                

            }

            //Caso N ganhe vertical

          else  if (!n1P.Enabled && !n2P.Enabled && !n4P.Enabled
               && !n5P.Enabled) {


                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                

            }

            //Caso G ganhe vertical

           else if (!g1P.Enabled && !i2P.Enabled && !g3P.Enabled && !g4P.Enabled
                && !g5P.Enabled) {


                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
               

            }

            else if (!o1P.Enabled && !o2P.Enabled && !o3P.Enabled && !o4P.Enabled
                && !o5P.Enabled) {

                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }


            //  CASO O COMPUTADOR GANHE NA HORIZONTAL

          else if (!b1P.Enabled && !i1P.Enabled && !n1P.Enabled && !g1P.Enabled && !o1P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }
           else  if (!b2P.Enabled && !i2P.Enabled && !n2P.Enabled && !g2P.Enabled && !o2P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }
           else if (!b3P.Enabled && !i3P.Enabled && !g3P.Enabled && !o3P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }
            else if (!b4P.Enabled && !i4P.Enabled && !n4P.Enabled && !g4P.Enabled && !o4P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }
          else  if (!b5P.Enabled && !i5P.Enabled && !n5P.Enabled && !g5P.Enabled && !o5P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }


            // CASO O COMPUTADOR GANHE NA DIAGONAL

           else if (!b1P.Enabled && !i2P.Enabled && !g4P.Enabled && !o5P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            }
            else if (!b5P.Enabled && !i4P.Enabled && !g2P.Enabled && !o1P.Enabled) {
                Reiniciar();
                MessageBox.Show("VOCÊ GANHOU!! PARABÉNS!!");
                
            } else {
                MessageBox.Show("Não, você não fez bingo.", "Bingo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
