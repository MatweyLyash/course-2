#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>

using namespace std;

const int MAX_CITIES = 30;

class AntColony {
public:
    AntColony(int numCities, double alpha, double beta, double rho, int numAnts);
    void findBestRoute(int iterations);



    int numCities;
    double alpha;
    double beta;
    double rho;
    int numAnts;

    vector<vector<double>> pheromones;
    vector<vector<double>> distances;

    vector<int> bestRoute;
    double bestDistance;

    vector<int> generateRandomRoute();
    double calculateRouteDistance(const vector<int>& route);
    void updatePheromones(const vector<vector<int>>& antRoutes);
};

AntColony::AntColony(int numCities, double alpha, double beta, double rho, int numAnts)
    : numCities(numCities), alpha(alpha), beta(beta), rho(rho), numAnts(numAnts),
    bestDistance(numeric_limits<double>::max()) {
    srand(time(nullptr));

    distances.resize(numCities, vector<double>(numCities, 0.0));
    for (int i = 0; i < numCities; ++i) {
        for (int j = i + 1; j < numCities; ++j) {
            distances[i][j] = distances[j][i] = rand() % 100 + 1;
        }
    }


    pheromones.resize(numCities, vector<double>(numCities, 1.0));
}

vector<int> AntColony::generateRandomRoute() {
    vector<int> route(numCities);
    for (int i = 0; i < numCities; ++i) {
        route[i] = i;
    }
    random_shuffle(route.begin(), route.end());
    return route;
}

double AntColony::calculateRouteDistance(const vector<int>& route) {
    double distance = 0.0;
    for (int i = 0; i < numCities - 1; ++i) {
        distance += distances[route[i]][route[i + 1]];
    }
    distance += distances[route.back()][route.front()];
    return distance;
}

void AntColony::updatePheromones(const vector<vector<int>>& antRoutes) {
    for (int i = 0; i < numCities; ++i) {
        for (int j = i + 1; j < numCities; ++j) {
            pheromones[i][j] *= (1.0 - rho);

            for (int k = 0; k < numAnts; ++k) {
                double deltaPheromone = 1.0 / calculateRouteDistance(antRoutes[k]);
                pheromones[i][j] += deltaPheromone;
                pheromones[j][i] = pheromones[i][j];
            }
        }
    }
}

void AntColony::findBestRoute(int iterations) {
    for (int iter = 0; iter < iterations; ++iter) {
        vector<vector<int>> antRoutes;

        for (int ant = 0; ant < numAnts; ++ant) {
            vector<int> route = generateRandomRoute();
            antRoutes.push_back(route);
        }

        updatePheromones(antRoutes);

        for (int ant = 0; ant < numAnts; ++ant) {
            double distance = calculateRouteDistance(antRoutes[ant]);
            if (distance < bestDistance) {
                bestDistance = distance;
                bestRoute = antRoutes[ant];
            }
        }

        cout << "Итерация: " << iter + 1 << endl;
        cout << "Лучший путь: ";
        for (int i = 0; i < numCities; ++i) {
            cout << bestRoute[i] << " ";
        }
        cout << endl;
        cout << "Дистанция: " << bestDistance << endl << endl;
    }
}

int main() {
    setlocale(0, "");
    int numCities;
    double alpha, beta, rho;
    int numAnts, iterations;

    cout << "Введите колличество городов: ";
    cin >> numCities;

    cout << "Введите альфа: ";
    cin >> alpha;

    cout << "Введите бета: ";
    cin >> beta;

    cout << "Введите рхо (коэффицент испарения ферамонов): ";
    cin >> rho;

    cout << "Введдите количесвто муравьёв: ";
    cin >> numAnts;

    cout << "Введите количесвто итераций: ";
    cin >> iterations;

    AntColony antColony(numCities, alpha, beta, rho, numAnts);
    cout << "Матрица расстояний:" << endl;
    for (int i = 0; i < numCities; ++i) {
        for (int j = 0; j < numCities; ++j) {
            cout << antColony.distances[i][j] << "\t";
        }
        cout << endl;
    }
    cout << endl;
    antColony.findBestRoute(iterations);
    system("pause");

    return 0;
}
