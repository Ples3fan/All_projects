#define _CRT_SECURE_NO_WARNINGS
#pragma once
#include"Salary.h"

struct Staff {
	MyString FIO;
	Date birth;
	long int number;
	int category;
	double percentpersale;
	double stavka=8960;
	int sales = 0;
	Salary* arrSal = nullptr;

	void fillStaff()
	{
		char tmp[250] = "";
		cout << "ФИО: ";
		cin.get(); cin.getline(tmp, 250);
		FIO.setMyString(tmp);
		cout << "Дата рождения: ";
		birth.fillDate();
		cout << "Номер телефона: ";
		cin >> number;
		cout << "Категория: ";
		cin>>category;
		
	}
	void printStaff()
	{
		cout << "ФИО: " << FIO.str << endl;
		cout << "Дата рождения: "; birth.printDate();cout << endl;
		cout << "Номер телефона: " << number << endl;
		cout << "Категория: " << category << endl;
		cout << "Заработная плата(ставка): " << stavka << endl;
		cout << "Заработная плата( +% от продаж в зависимости от категории)\n";
		cout << "Завершенных продаж: " << sales << endl;
	}
	void toBinFile(FILE* fp) {
		fwrite(&FIO.length, sizeof(int), 1, fp);
		fwrite(FIO.str, sizeof(char), FIO.length, fp);

		fwrite(&birth, sizeof(Date), 1, fp);
		fwrite(&number, sizeof(long int), 1, fp);
		fwrite(&category, sizeof(int), 1, fp);
		fwrite(&stavka, sizeof(double), 1, fp);
		fwrite(&percentpersale, sizeof(double), 1, fp);
		fwrite(&sales, sizeof(int), 1, fp);

	}
	void fromBinFile(FILE* fp) {
		fread(&FIO.length, sizeof(int), 1, fp);
		FIO.str = new char[FIO.length + 1];
		fread(FIO.str, sizeof(char), FIO.length, fp);
		FIO.str[FIO.length] = '\0';

		fread(&birth, sizeof(Date), 1, fp);
		fread(&number, sizeof(long int), 1, fp);
		fread(&category, sizeof(int), 1, fp);
		fread(&stavka, sizeof(double), 1, fp);
		fread(&percentpersale, sizeof(double), 1, fp);
		fread(&sales, sizeof(int), 1, fp);
	}

	char* toString()
	{
		char* str = new char[11];
		sprintf(str, "%d", number);
		return str;
	}
	void addSales(Auto order)
	{
		
			Salary* tmp = new Salary[++sales];
			for (int i = 0; i < sales-1; i++)
			{
				tmp[i] = arrSal[i];
			}
		 
		 	if (arrSal != nullptr) delete[] arrSal;
		 	
			tmp[sales - 1].addSales(order);
			arrSal = tmp;
	}

};

Staff* addStaff(Staff* s, int& N);
void fillStaff(Staff* s, int N);
void printStaff(Staff* s, int N);
void saveStaff(Staff* s, int N);
Staff* upLoadStaff(int& N);
void printPosStaff(Staff* s, int N, int PStaff);

void getVINCode();
//char strLogin(Staff* s, int N, char* line);

int indexStaffByPhone(Staff* s, int N, long int phone);
int fillPersentStaff(Salary* sall, int N);
int searchStaff(Staff* s, int N, char* line);
void correctStaff(Staff* s, int N, int V);