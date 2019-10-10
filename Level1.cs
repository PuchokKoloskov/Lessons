using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static void MatrixTurn(string[] Matrix, int M, int N, int T)
        {
            int[,] intArray = new int[M, N];

            int layers;

            if (M <= N)
            {
                layers = M / 2;
            }
            else
            {
                layers = N / 2;
            }

            int[][] layersAr = new int[layers][];

            for (int i = 0, j = layers; i < layers && j >= 1; i++, j--)
            {
                layersAr[i] = new int[(4 + 2 * Math.Abs(M - N)) + (8 * (j - 1))];
            }
;

            for (int i = 0; i < M; i++)
            {
                char[] caAr = Matrix[i].ToCharArray();

                for (int j = 0; j < N; j++)
                {
                    intArray[i, j] = Convert.ToInt32(caAr[j].ToString());
                }
            }

            int layer = 0;

            for (int i = 0; i < layers; i++)
            {
                int count = 0;


                for (int j = 0 + layer; j < N - 1 - layer; j++)
                {
                    layersAr[i][count] = intArray[0 + layer, j];
                    count++;
                }

                for (int j = 0 + layer; j < M - 1 - layer; j++)
                {
                    layersAr[i][count] = intArray[j, N - 1 - layer];
                    count++;
                }

                for (int j = N - 1 - layer; j >= 1 + layer; j--)
                {
                    layersAr[i][count] = intArray[M - 1 - layer, j];
                    count++;
                }

                for (int j = M - 1 - layer; j >= 1 + layer; j--)
                {
                    layersAr[i][count] = intArray[j, 0 + layer];
                    count++;
                }

                layer++;
            }

            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < layers; j++)
                {
                    int last = layersAr[j][layersAr[j].Length - 1];

                    for (int k = layersAr[j].Length - 2; k >= 0; k--)
                    {
                        layersAr[j][k + 1] = layersAr[j][k];
                    }
                    layersAr[j][0] = last;
                }
            }

            layer = 0;

            for (int i = 0; i < layers; i++)
            {
                int count = 0;


                for (int j = 0 + layer; j < N - 1 - layer; j++)
                {
                    intArray[0 + layer, j] = layersAr[i][count];
                    count++;
                }

                for (int j = 0 + layer; j < M - 1 - layer; j++)
                {
                    intArray[j, N - 1 - layer] = layersAr[i][count];
                    count++;
                }

                for (int j = N - 1 - layer; j >= 1 + layer; j--)
                {
                    intArray[M - 1 - layer, j] = layersAr[i][count];
                    count++;
                }

                for (int j = M - 1 - layer; j >= 1 + layer; j--)
                {
                    intArray[j, 0 + layer] = layersAr[i][count];
                    count++;
                }

                layer++;
            }

            for (int i = 0; i < M; i++)
            {
                char[] caAr = Matrix[i].ToCharArray();
                Matrix[i] = null;
                for (int j = 0; j < N; j++)
                {
                    Matrix[i] += intArray[i, j].ToString();
                }
            }

            return;
        }
    }
}
