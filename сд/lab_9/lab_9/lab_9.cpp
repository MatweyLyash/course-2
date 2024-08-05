#include "GeneticAlgorith.h"

int main()
{
    setlocale(LC_ALL, "Rus");
    srand(time(0));

    int populaton, Evolutions;

    cout << "Введите размер популяции: ";
    cin >> populaton;

    cout << "Введите кол-во эволюций: ";
    cin >> Evolutions;


    GeneticAlgorithm ga(populaton, Evolutions);
    ga.Solve();
}