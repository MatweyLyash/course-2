#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct stuff {
	string name;
	int weight;
	int cost;
	void input() {
		cout << "Введите название товара" << endl;
		cin >> name;
		cout << "Введите вес товара" << endl;
		cin >> weight;
		cout << "Введите стоимость товара" << endl;
		cin >> cost;
	}
	void output(){
		cout << "Наименование: " << name << endl;
		cout << "Вес: " << weight << endl;
		cout << "Цена: " << cost << endl;
	}
};
//void PrintKnapsack(int capacity, const vector<stuff> products)
//{
//	int productCount = products.size();
//
//	vector<vector<int>> D(productCount + 1, vector<int>(capacity + 1, 0));
//
//	for (int i = 1; i <= productCount; i++)
//	{
//		for (int w = 0; w <= capacity; ++w)
//		{
//			if (products[i - 1].weight > w) D[i][w] = D[i - 1][w];
//			else D[i][w] = max(D[i - 1][w], D[i - 1][w - products[i - 1].weight] + products[i - 1].cost);
//		}
//	}
//
//	int i = productCount;
//	int w = capacity;
//
//	vector<stuff> selectedProducts;
//
//	while (i > 0 && w > 0) {
//		if (D[i][w] != D[i - 1][w]) {
//			selectedProducts.push_back(products[i - 1]);
//			w -= products[i - 1].weight;
//			i--;
//		}
//		else {
//			i--;
//		}
//	}
//
//	for (auto item : selectedProducts)
//	{
//		item.output();
//	}
//
//
//}
vector<stuff> getSelectedItems(const vector<stuff>& items, int capacity, const vector<int>& dp) {
	vector<stuff> selectedItems;
	int w = capacity;

	for (int i = items.size() - 1; i >= 0; --i) {
		if (w >= items[i].weight && dp[w] == dp[w - items[i].weight] + items[i].cost) {
			selectedItems.push_back(items[i]);
			w -= items[i].weight;
		}
	}
	reverse(selectedItems.begin(), selectedItems.end());
	return selectedItems;
}
int knapsack(vector<stuff>& items, int capacity) {
	//vector<stuff> inBag;
	//for (const auto& item : items) {
	//	if (capacity >= item.weight) {
	//		inBag.push_back(item);
	//		capacity -= item.weight;
	//	}
	//}

	vector<int> dp(capacity + 1, 0);
	for (const auto& item : items) {
		for (int w = capacity; w >= item.weight; --w) {
			dp[w] = max(dp[w], dp[w - item.weight] + item.cost);
		}
	}
	vector<stuff> inBag=getSelectedItems(items,capacity,dp);
	cout << "\nПредметы, помещённые в рюкзак:" << endl;
	for (auto& stuff4ki : inBag) {
		stuff4ki.output();
	}

	return dp[capacity];
}

bool compareStuff(stuff a, stuff b) 
{
	if (a.weight != b.weight) {
		return a.weight < b.weight;
	}
	else {
		return a.cost > b.cost;
	}
	//return (static_cast<double>(a.cost) / a.weight) > (static_cast<double>(b.cost) / b.weight);

}

void main() {
	setlocale(LC_ALL, "rus");
	int capacity,amount;
	vector<stuff>manyStuff;
	cout << "Введите вместимости рюкзака " << endl;
	cin >> capacity;
	cout << "Введите количество товаров" << endl;
	cin >> amount;
	for (int i = 0; i < amount; i++)
	{
		stuff product;
		product.input();
		manyStuff.push_back(product);
	}
	sort(manyStuff.begin(), manyStuff.end(), compareStuff);
	//PrintKnapsack(capacity, manyStuff);
	/*knapsack(manyStuff, capacity);*/
	cout << knapsack(manyStuff, capacity) << endl;
	

}