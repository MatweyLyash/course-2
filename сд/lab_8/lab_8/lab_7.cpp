#include <iostream>
#include <vector>
using namespace std;

void main()
{
	setlocale(LC_ALL, "rus");
	try
	{
		int n,amount, someNumber;
		vector<int> arr;
		cout << "Введите количество элементов в последовательности" << endl;
		cin >> amount;
		cout << "Введите элементы" << endl;
		for (int i = 0; i < amount; i++)
		{
			cin >> someNumber;
			arr.push_back(someNumber);
		}
		cout << "Введите длину возрастающей подпоследовательности" << endl;
		cin >> n;
		if (n > sizeof(arr) / 4 && n < 0)
		{
			throw out_of_range("Длина подпоследовательности не может быть больше 8 и меньше 1");
		}
		vector<int> podArr;
		int flag = 1;
		int buf = 0;
		for (int i = 0; i < sizeof(arr) / 4; i++)
		{
			if (i == 0)
			{
				buf = arr[i];
				podArr.push_back(buf);
			}
			else
			{
				if (buf < arr[i]) {
					podArr.push_back(arr[i]);
					buf = arr[i];
					flag++;
				}
				else
				{
					continue;
				}
			}
		}
		if (n > flag)
		{
			n = flag;
		}
		for (int i = 0; i < n; i++)
		{
			cout << podArr[i] << " ";
		}


	}
	catch (const exception& e)
	{
		cerr << "Ошибка: " << e.what() << endl;

	}

}