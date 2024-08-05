#include "stdafx.h"
#include <algorithm>
#include <iostream>
#include <ctime>
#include <iomanip>

#include "Levenshtein.h"


#define FIRST_LEN 300
#define SECOND_LEN 200
using namespace std;
char* GenerateRandomString(int size)
{
	char* str = (char*)malloc(sizeof(char) * size);
	for (int i = 0; i < size; i++) {
		str[i] = rand() % 26 + 'a'; // 26 букв в алфавите
	}
	return str;
}

void main() {
	setlocale(LC_ALL, "rus");
	srand(time(NULL));
	clock_t t1 = 0, t2 = 0, t3=0, t4=0, t5 = 0, t6=0,t7=0,t8=0;

	
	char s1[300] = "", s2[250] = "";
	char* s_1 = GenerateRandomString(FIRST_LEN);
	cout << "S1: " << endl;
	for (int i = 0; i < FIRST_LEN; i++) {
		if (i % 50 == 0)
		{
			cout << "\n";
		}
		cout << s_1[i];
		s1[i] = s_1[i];
	}
	cout << endl << endl;

	char* s_2 = GenerateRandomString(SECOND_LEN);
	cout << "S2: " << endl;
	for (int i = 0; i < SECOND_LEN; i++) {
		if (i % 50 == 0)
		{
			cout << "\n";
		}
		cout << s_2[i];
		s2[i] = s_2[i];
	}
	cout << endl << endl;
	
	int  lx = sizeof(s1) - 1, ly = sizeof(s2) - 1;

	std::cout << std::endl;
	std::cout << std::endl << "-- расстояние Левенштейна -----" << std::endl;
	std::cout << std::endl << "--длина --- рекурсия -- дин.програм. ---"
		<< std::endl;
	for (int i = 8; i < std::min(lx, ly); i++)
	{

		t1 = clock(); levenshtein_r(i, s1, i - 2, s2); t2 = clock();
		t3 = clock(); levenshtein(i, s1, i - 2, s2); t4 = clock();
		
		std::cout << std::right << std::setw(2) << i - 2 << "/" << std::setw(2) << i
			<< "        " << std::left << std::setw(10) << (t2 - t1)
			<< "   " << std::setw(10) << (t4 - t3) << std::endl;

	}
	
	system("pause");
	

}