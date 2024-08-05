#include <iostream>
using namespace std;
bool check(int a)
{
	if (a > 1)
	{
		return true;
	}
	else
	{
		return false;
	}
}

void hanoi(int N,int i, int helper,int k)
{
	if (N == 1)
	{
		cout << "Диск 1 перемещён с стержня " << i << " на стержень " << k << endl;
		return;
	}
	hanoi(N - 1, i,k, helper);
	cout << "Диск "<<N<<" перемещён с стержня " << i << " на стержень " << k << endl;
	hanoi(N - 1,helper,i, k);
}

int main()
{
	setlocale(LC_ALL, "rus");
	int N, amount, i, k;
	cout << "Введите кол-во стержней:";
	cin >> amount;
	if (!check(amount))
	{
		return 0;
	}
	cout << "\nВведите кол-во дисков:";
	cin >> N;
	if (!check(N-1))
	{
		return 0;
	}
	hanoi(N, 1, amount - 1, amount );
	return 0;

}