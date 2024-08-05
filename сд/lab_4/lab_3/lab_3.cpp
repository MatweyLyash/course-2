
#include <iostream>
#include <limits.h>
    const int INF = INT_MAX;
using namespace std;
void FW(int mV[][6], int D[][6], int C[][6], int V)
{
  
    D = mV;
    for (int i = 0; i < V; i++)
    {
        for (int j = 0; j < V; j++)
        {
            if (D[i][j] == 0)
                D[i][j] = INF;
            if (i == j)
                D[i][j] = 0;
            C[i][j] = j;
        }
    }

    for (int k = 0; k < V; k++)
    {
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                if ((D[i][k] != INF) && (D[k][j] != INF))
                {
                    if (D[i][j] > D[i][k] + D[k][j])
                    {
                        D[i][j] = D[i][k] + D[k][j];

                        C[i][j] = C[i][k];

                    }
                }
            }
        }
    }

    cout << "Матрица кратчайших путей (D[][]):" << endl;
    for (int i = 0; i < V; i++)
    {
        for (int j = 0; j < V; j++)
        {
            if (D[i][j] != INF)
                cout << " " << D[i][j];
            else
                cout << " inf";
        }
        cout << endl;
    }

    cout << "Матрица последовательности путей (S[][]):" << endl;
    for (int i = 0; i < V; i++)
    {
        for (int j = 0; j < V; j++)
        {
            if (i == j)
                C[i][j] = -1;
            cout << " " << C[i][j] + 1;
        }
        cout << endl;
    }

 
}

int main()
{
    setlocale(LC_ALL, "rus");
    int graph[6][6] =
    	{ /* 1  2  3  4  5  6 */
    		{0,28,21,59,12,27},//1
    		{7,0, 24, INF,21,9},//2
    		{9, 32,0,13,11,INF},//3
    		{8,INF, 5,0,16,INF},//4
    		{14,13,15,10,0,22}, //5
    		{15,18,INF,INF,6,0} //6
    	};
    int D[6][6], C[6][6];
    FW(graph, D, C, 6);
   

    return 0;
}