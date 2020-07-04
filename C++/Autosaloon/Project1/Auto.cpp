#include "Auto.h"

Auto* addAuto(Auto* s, int& N)
{
	Auto* tmp = new Auto[++N];
	for (int i = 0; i < N - 1; i++)
	{
		tmp[i] = s[i];
	}
	if (s != nullptr) delete[] s;

	cout << "Автомобиль №" << N << endl;
	tmp[N - 1].fillCars();

	return tmp;
}

void fillAuto(Auto* s, int N)
{
	for (int i = 0; i < N; i++)
		{
			cout << "==========================\n";
			cout << "\t\t Позиция №" << i + 1 << endl;
			cout << "==========================\n";
			s[i].fillCars();
		}
}

void printAuto(Auto* s, int N)
{
	for (int i = 0; i < N; i++)
	{
		cout << "=======================================\n";
		cout << "\t Позиция №: " << i + 1 << endl;
		cout << "=======================================\n";
		s[i].printCars();
	}
}

void saveAuto(Auto* s, int N)
{
	FILE* file = fopen("cars.bin", "wb");
	if (file == NULL)
	{
		cout << "Ошибка при сохранении\n";
	}
	else {
		fwrite(&N, sizeof(int), 1, file);
		for (int i = 0; i < N; i++)
		{
			s[i].toBinFile(file);
		}
		fclose(file);
		cout << "Данные успешно сохранены\n";
	}
}

Auto* upLoadAuto(int& N)
{
	FILE* file = fopen("cars.bin", "rb");
	if (file == NULL)
	{
		cout << "Ошибка при выгрузке данных из БД\n";
		N = 0;
		return nullptr;
	}
	else {
		fread(&N, sizeof(int), 1, file);
		Auto* tmp = new Auto[N];
		for (int i = 0; i < N; i++)
		{
			tmp[i].fromBinFile(file);
		}
		fclose(file);
		return tmp;

	}
}

void sortDate(Auto* s, int N)
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N - 1 - j; j++)
		{
			if (s[j + 1].data_v > s[j].data_v)
			{
				Auto t = s[j];
				s[j] = s[j + 1];
				s[j + 1] = t;
			}
		}

	}
}

void sortPrice(Auto* s, int N)
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N - 1 - j; j++)
		{
			if (s[j + 1].price > s[j].price)
			{
				Auto t = s[j];
				s[j] = s[j + 1];
				s[j + 1] = t;
			}
		}

	}
}

void sortDvig(Auto* s, int N)
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N - 1 - j; j++)
		{
			if (s[j + 1].v_dvig > s[j].v_dvig)
			{
				Auto t = s[j];
				s[j] = s[j + 1];
				s[j + 1] = t;
			}
		}

	}
}

int indexAutoVINFind(Auto * s, int N, long int vin)
{
	int id = -1;
	for (int i = 0; i < N; i++)
	{
		if (s[i].vcode == vin)
		{
			id = i;
		}
	}

	return id;
}

void correctAuto(Auto* s, int N, int V)
{
	
		s[V].fillCars();
	
}

Auto* delAuto(Auto* s, int& N, long int V)
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
		cout << "Данный автомобиль не найден\n";
		return s;
	}
	else
	{
		Auto* tmp = new Auto[--N];
		for (int i = 0; i < N; i++)
		{
			if (i < id)
				tmp[i] = s[i];
			else
				tmp[i] = s[i + 1];
		}
		delete[] s;
		return tmp;
	}
}
