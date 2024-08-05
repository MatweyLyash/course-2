#include <iostream>
#include <cstring>
using namespace std;

#define INF 9999999

#define V 8



int G[V][V] = {
    {0, 2,0,8,2,0,0,0},
    {2,0,3,10,5,0,0,0},
    {0,3,0,0,12,0,0,7},
    {8,10,0,0,14,3,1,0},
    {2,5,12,14,0,11,4,8},
    {0,0,0,3,11,0,6,0},
    {0,0,0,1,4,6,0,9},
    {0,0,7,0,8,0,9,0}
};
int find_set(int i, int parent[]) {
    if (i == parent[i]) {
        return i;
    }
    return find_set(parent[i], parent);
}

void union_set(int u, int v, int parent[]) {
    parent[u] = parent[v];
}

void kruskal() {

    int parent[V];
    for (int i = 0; i < V; i++) {
        parent[i] = i;
    }

    int selected[V];
    memset(selected, false, sizeof(selected));

    int edge_count = 0;
    int x;
    int y;

    std::cout << "Вершина : Вес\n";

    while (edge_count < V - 1) {

        int min = INF;
        x = 0;
        y = 0;

        for (int i = 0; i < V; i++) {
            if (selected[i]) {
                for (int j = 0; j < V; j++) {
                    if (!selected[j] && G[i][j]) {
                        if (min > G[i][j]) {
                            min = G[i][j];
                            x = i;
                            y = j;
                        }
                    }
                }
            }
        }

        int x_rep = find_set(x, parent);
        int y_rep = find_set(y, parent);
        selected[y] = true;
        if (x_rep != y_rep) {
            cout << x + 1 << " - " << y + 1 << " : " << G[x][y] << "\n";
            union_set(x_rep, y_rep, parent);
           
            edge_count++;
        }
        
    }
}


int main() {
    setlocale(LC_ALL, "rus");
    int no_edge;           
    int selected[V];

    memset(selected, false, sizeof(selected));

    no_edge = 0;


    selected[0] = true;

    int x;            
    int y;            

    cout << "Алгоритм Прима:" << endl;
    cout << "Вершина" << " : " << "Вес";
    cout << endl;
    while (no_edge < V - 1) {

  
        int min = INF;
        x = 0;
        y = 0;

        for (int i = 0; i < V; i++) {
            if (selected[i]) {
                for (int j = 0; j < V; j++) {
                    if (!selected[j] && G[i][j]) { 
                        if (min > G[i][j]) {
                            min = G[i][j];
                            x = i;
                            y = j;
                        }

                    }
                }
            }
        }
        cout << x+1 << " - " << y+1 << " :  " << G[x][y];
        cout << endl;
        selected[y] = true;
        no_edge++;
    }
    cout << "Алгоритм Краскала" << endl;
    kruskal();
    return 0;
}

