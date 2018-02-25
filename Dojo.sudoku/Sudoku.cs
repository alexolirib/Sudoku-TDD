using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.sudoku
{
    public class Sudoku
    {
        int[,] tabelaSudoku = new int[9, 9];

        public bool verificaSudoku(int[,] sudoku)
        {
            //vetor criada parapegar cada linha e coluna em um vetor para ser feita a verificação
            int[] transformaVetor = new int[9];

            if (verificaValor(sudoku) == true)
            {
                //irá verificar aqui cada linha
                for (int linha = 0; linha < 9; linha++)
                {
                    for (int coluna = 0; coluna < 9; coluna++)
                    {
                        transformaVetor[coluna] = sudoku[linha, coluna];
                    }
                    if(verificaVetor(transformaVetor) == false)
                    {
                        return false;
                    }
                }

                //irá verificar aqui cada coluna
                for (int coluna = 0; coluna < 9; coluna++)
                {
                    for (int linha = 0; linha < 9; linha++)
                    {
                        transformaVetor[linha] = sudoku[linha, coluna];
                    }
                    if (verificaVetor(transformaVetor) == false)
                    {
                        return false;
                    }
                }

                //aqui é feita a verificação de cada quadrante do sudoku! 
                if(verificaArrayComVetorDeNovePosicao(sudoku) == false)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        //método para verificar se os valores inseridos foram feito de forma correta! 
        private bool verificaValor(int[,] valor)
        {
            for (int linha = 0; linha < 9; linha++)
            {
                for (int coluna = 0; coluna < 9; coluna++)
                {
                    if (valor[linha, coluna] < 1 || valor[linha, coluna] > 9)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Aqui irá transformar cada quadrante em um vetor para ser feita a verificação do vetor
        public bool QuadranteTransoformaVetor(int[,] array)
        {
            int[] transfVetor = new int[9];
            List<int> listVetor = new List<int>();

            for (int coluna = 0; coluna < 3; coluna++)
            {
                for (int linha = 0; linha < 3; linha++)
                {
                    listVetor.Add(array[coluna, linha]);
                }
            }
            int cont = 0;
            foreach (int pegaLista in listVetor)
            {
                transfVetor[cont] = pegaLista;
                cont++;
            }
            return verificaVetor(transfVetor);
        }

        //feita e verificação 
        public bool verificaVetor(int[] array)
        {

            for (int atual = 0; atual < array.Length; atual++)
            {

                for (int anterior = 0; anterior < atual; anterior++)
                {
                    if (array[anterior] == array[atual])
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public bool verificaArrayComVetorDeNovePosicao(int[,] sudoku)
        {
            //Na matriz [NumeroQuandrante, Coluna, Linha]
            int[,,] Quadrante = new int[9, 3, 3];


            // numeroQuandrante é para saber qual posição do quadrante 
            // a colunaQuadrante e linhaQuadrante é para repesentar cada linha e coluna do Sudoku
            //
            int numeroQuadrante = 0, numeroAuxQuadrante = 0, colunaQuandrante = 0, linhaQuadrante = 0;
            for (int linha = 0; linha < 9; linha++)
            {
                if (linha < 3)
                {
                    linhaQuadrante = linha;
                    numeroQuadrante = 0;
                }
                else
                {
                    if (linha < 6)
                    {
                        numeroQuadrante = 3;
                        linhaQuadrante = linha - 3;

                    }
                    else
                    {
                        numeroQuadrante = 6;
                        linhaQuadrante = linha - 6;

                    }
                }
                for (int Coluna = 0; Coluna < 9; Coluna++)
                {
                    if (Coluna < 3)
                    {
                        colunaQuandrante = Coluna;
                        numeroAuxQuadrante = numeroQuadrante;
                    }
                    else
                    {
                        if (Coluna < 6)
                        {
                            colunaQuandrante = Coluna - 3;
                            numeroAuxQuadrante = numeroQuadrante + 1;
                        }
                        else
                        {


                            colunaQuandrante = Coluna - 6;
                            numeroAuxQuadrante = numeroQuadrante + 2;
                        }
                    }
                    Quadrante[numeroAuxQuadrante, colunaQuandrante, linhaQuadrante] = sudoku[linha, Coluna];
                }
            }

            return transformaArrayDeTresParaDoisFazVerificacao(Quadrante);
        }


        //aqui será convertido cada array de 3 dimensões para 2 dimensões(cada quadrante)
        //e manda para o método que converte cada matriz em um vetor 
        private bool transformaArrayDeTresParaDoisFazVerificacao(int[,,] Quandrante)
        {
            int[,] cadaQuandrante = new int[3, 3];

            for (int verificaCadaQuadrante = 0; verificaCadaQuadrante < 9; verificaCadaQuadrante++)
            {
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        cadaQuandrante[linha, coluna] = Quandrante[verificaCadaQuadrante, linha, coluna];
                    }
                }
                                
                if (QuadranteTransoformaVetor(cadaQuandrante) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
