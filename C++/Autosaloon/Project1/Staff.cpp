#include "Staff.h"


Staff* addStaff(Staff* s, int& N)
{
	Staff* tmp = new Staff[++N];
	for (int i = 0; i < N - 1; i++)
	{
		tmp[i] = s[i];
	}
	if (s != nullptr) delete[] s;

	cout << "Сотрудник №" << N << endl;
	tmp[N - 1].fillStaff();

	return tmp;
}

void fillStaff(Staff* s, int N)
{
		for (int i = 0; i < N; i++)
		{
			cout << "==========================\n";
			cout << "\t\t Сотрудник №" << i + 1 << endl;
			cout << "==========================\n";
			s[i].fillStaff();
		}
}

void printStaff(Staff* s, int N)
{
	for (int i = 0; i < N; i++)
	{
		cout << "=======================================\n";
		cout << "\t Сотрудник №: " << i + 1 << endl;
		cout << "=======================================\n";
		s[i].printStaff();
	}
}

void saveStaff(Staff* s, int N)
{
	FILE* file = fopen("staff.bin", "wb");
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

Staff* upLoadStaff(int& N)
{
	FILE* file = fopen("staff.bin", "rb");
	if (file == NULL)
	{
		cout << "Ошибка при выгрузке данных из БД\n";
		N = 0;
		return nullptr;
	}
	else {
		fread(&N, sizeof(int), 1, file);
		Staff* tmp = new Staff[N];
		for (int i = 0; i < N; i++)
		{
			tmp[i].fromBinFile(file);
		}
		fclose(file);
		return tmp;

	}
}

void printPosStaff(Staff* s, int N, int PStaff)
{
	for (int i = 0; i < N; i++)
	{
		if (i == PStaff)
		{
			cout << "=======================================\n";
			cout << "\t Сотрудник №: " << i + 1 << endl;
			cout << "=======================================\n";
			s[i].printStaff();
		}
	}
}

void getVINCode()
{
	FILE* fp = fopen("orders.bin", "rb");
	int i = 0;
	while (!feof(fp))
	{
		long int a = 0;
		fread(&a, sizeof(long int), 1, fp);
		cout << "№ " << ++i << ": " << a << endl;
	}
	fclose(fp);
}

int indexStaffByPhone(Staff * s, int N, long int phone)
{
	int id = -1;
	for (int i = 0; i < N; i++)
	{
		if (s[i].number == phone)
		{
			id = i;
		}
	}
	 
	return id;
}

int fillPersentStaff(Salary* sall, int N)
{
	int id = 0;
	for (int i = 0; i < N; i++)
	{
		id++;
	}
	return id;
}

int searchStaff(Staff* s, int N, char* line)
{
	int id = -1;
	for (int i = 0; i < N; i++)
	{
		if (strcmp(s[i].FIO.str, line) == 0)
		{
			id = i;
		}
	}
	if (id == -1)
	{
		cout << "Неверные данные\n";
		
	}
	return id;
}

void correctStaff(Staff* s, int N, int V)
{
	s[V].fillStaff();
}




