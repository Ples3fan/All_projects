#include "Salary.h"



Salary* addBD(Auto* s, Salary* ss1, int& N,long int V)
{
	int id = -1;
	for (int i = 0; i < N; i++)
	{
		if (s[i].vcode==V)
		{
			id = i;
		}
	}
	if (id == -1)
	{
		return ss1;
	}
	else
	{
		Salary* tmp = new Salary[N];
		for (int i = 0; i < N; i++)
		{
			if (i == id)
				tmp[i] = ss1[i];
			else
				break;
		}
		return tmp;
	}
}

void printSal(Salary * s, int N)
{
	for (int i = 0; i < N; i++)
	{
		cout << "=======================================\n";
		cout << "\t Позиция №: " << i + 1 << endl;
		cout << "=======================================\n";
		s[i].printSale();
	}
}

void saveSal(Salary * s, int N)
{
	FILE* file = fopen("prodaja.bin", "wb");
	if (file == NULL)
	{
		cout << "Ошибка при сохранении\n";
	}
	else {
		fwrite(&N, sizeof(int), 1, file);
		for (int i = 0; i < N; i++)
		{
			s[i].toBinSale(file);
		}
		fclose(file);
		cout << "Данные успешно сохранены\n";
	}
}

Salary * upLoadSal(int & N)
{
	FILE* file = fopen("prodaja.bin", "rb");
	if (file == NULL)
	{
		cout << "Ошибка при выгрузке данных из БД\n";
		N = 0;
		return nullptr;
	}
	else {
		fread(&N, sizeof(int), 1, file);
		Salary* tmp = new Salary[N];
		for (int i = 0; i < N; i++)
		{
			tmp[i].fromBinSale(file);
		}
		fclose(file);
		return tmp;
	}
}

