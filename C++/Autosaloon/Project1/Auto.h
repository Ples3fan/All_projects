#define _CRT_SECURE_NO_WARNINGS
#pragma once
#include"MyString.h"
struct Auto {
	MyString mark;
	MyString cuz;
	int dours = 0;
	char klas;
	MyString rule;
	int data_v=0;
	int v_dvig=0;
	int power = 0;
	MyString priv;
	MyString k_per;
	float speed100 = 0;
	int maxspeed = 0;
	int benz = 0;
	int dlin = 0;
	int shir = 0;
	int vis = 0;
	int mass = 0;
	int v_bak = 0;
	long int vcode = 0;
	int price = 0;
	//int NProd = 0;
	//Salary* sales = nullptr;
	void fillCars()
	{
		char tmp[500] = "";
		cout << "������: ";
		cin.get(); cin.getline(tmp, 200);
		mark.setMyString(tmp);
		cout << "��� ������: ";
		cin.getline(tmp, 200);
		cuz.setMyString(tmp);
		cout << "���������� ������: ";
		cin >> dours;
		cout << "�����: "; cin >> klas;
		cout << "��������� ����: ";
		cin.get(); cin.getline(tmp, 200);
		rule.setMyString(tmp);
		cout << "��� �������: "; cin >> data_v;
		cout << "����� ��������� (���.��): "; cin >> v_dvig;
		cout << "�������� (�.�): "; cin >> power;
		cout << "��� �������: ";
		cin.get(); cin.getline(tmp, 200);
		priv.setMyString(tmp);
		cout << "��� ������� �������: ";
		cin.getline(tmp, 200);
		k_per.setMyString(tmp);
		cout << "������ �� 100 ��/� (�������): ";
		cin >> speed100;
		cout << "������������ ��������(��/�): ";
		cin >> maxspeed;
		cout << "������ ������� �� 100 ��: ";
		cin >> benz;
		cout << "������ ����������(��): ";
		cin >> dlin;
		cout << "������ ����������(��): ";
		cin >> shir;
		cout << "������ ����������(��): ";
		cin >> vis;
		cout << "����� ����������(��): ";
		cin >> mass;
		cout << "����� ���������(�): "; cin >> v_bak;
		cout << "VIN-��� ����������: "; cin >> vcode;
		cout << "���� ����������: "; cin >> price;
	}
	
	void printCars()
	{
		cout << "������: " << mark.str << endl;
		cout << "��� ������: " << cuz.str << endl;
		cout << "���������� ������: " << dours << endl;
		cout << "�����: " << klas << endl;
		cout << "��������� ����: " << rule.str << endl;
		cout << "��� �������: "<<data_v<<endl;
		cout << "����� ��������� (���.��): " << v_dvig << endl;
		cout << "�������� (�.�): "<<power<<endl;
		cout << "��� �������: " << priv.str << endl;
		cout << "��� ������� �������: " << k_per.str << endl;
		cout << "������ �� 100 ��/� (�������): " << speed100 << endl;
		cout << "������������ ��������(��/�): " << maxspeed << endl;
		cout << "������ ������� �� 100 ��: " << benz << endl;
		cout << "������ ����������(��): " << dlin << endl;
		cout << "������ ����������(��): " << shir << endl;
		cout << "������ ����������(��): " << vis << endl;
		cout << "����� ����������(��): " << mass << endl;
		cout << "����� ���������(�): "<<v_bak<<endl;
		cout << "VIN-��� ����������: "<<vcode << endl;
		cout << "���� ����������: "<<price << endl;
	}

	void toBinFile(FILE* fp) {
		fwrite(&mark.length, sizeof(int), 1, fp);
		fwrite(mark.str, sizeof(char), mark.length, fp);

		fwrite(&cuz.length, sizeof(int), 1, fp);
		fwrite(cuz.str, sizeof(char), cuz.length, fp);

		fwrite(&dours, sizeof(int), 1, fp);
		fwrite(&klas, sizeof(char), 1, fp);

		fwrite(&rule.length, sizeof(int), 1, fp);
		fwrite(rule.str, sizeof(char), rule.length, fp);

		fwrite(&data_v, sizeof(int), 1, fp);
		fwrite(&v_dvig, sizeof(int), 1, fp);
		fwrite(&power, sizeof(int), 1, fp);

		fwrite(&priv.length, sizeof(int), 1, fp);
		fwrite(priv.str, sizeof(char), priv.length, fp);

		fwrite(&k_per.length, sizeof(int), 1, fp);
		fwrite(k_per.str, sizeof(char), k_per.length, fp);

		fwrite(&speed100, sizeof(float), 1, fp);
		fwrite(&maxspeed, sizeof(int), 1, fp);
		fwrite(&benz, sizeof(int), 1, fp);
		fwrite(&dlin, sizeof(int), 1, fp);
		fwrite(&shir, sizeof(int), 1, fp);
		fwrite(&vis, sizeof(int), 1, fp);
		fwrite(&mass, sizeof(int), 1, fp);
		fwrite(&v_bak, sizeof(int), 1, fp);
		fwrite(&vcode, sizeof(long int), 1, fp);
		fwrite(&price, sizeof(int), 1, fp);
	}

	void fromBinFile(FILE* fp) {
		fread(&mark.length, sizeof(int), 1, fp);
		mark.str = new char[mark.length + 1];
		fread(mark.str, sizeof(char), mark.length, fp);
		mark.str[mark.length] = '\0';

		fread(&cuz.length, sizeof(int), 1, fp);
		cuz.str = new char[cuz.length + 1];
		fread(cuz.str, sizeof(char), cuz.length, fp);
		cuz.str[cuz.length] = '\0';

		fread(&dours, sizeof(int), 1, fp);
		fread(&klas, sizeof(char), 1, fp);

		fread(&rule.length, sizeof(int), 1, fp);
		rule.str = new char[rule.length + 1];
		fread(rule.str, sizeof(char), rule.length, fp);
		rule.str[rule.length] = '\0';

		fread(&data_v, sizeof(int), 1, fp);
		fread(&v_dvig, sizeof(int), 1, fp);
		fread(&power, sizeof(int), 1, fp);

		fread(&priv.length, sizeof(int), 1, fp);
		priv.str = new char[priv.length + 1];
		fread(priv.str, sizeof(char), priv.length, fp);
		priv.str[priv.length] = '\0';

		fread(&k_per.length, sizeof(int), 1, fp);
		k_per.str = new char[k_per.length + 1];
		fread(k_per.str, sizeof(char), k_per.length, fp);
		k_per.str[k_per.length] = '\0';

		fread(&speed100, sizeof(float), 1, fp);
		fread(&maxspeed, sizeof(int), 1, fp);
		fread(&benz, sizeof(int), 1, fp);
		fread(&dlin, sizeof(int), 1, fp);
		fread(&shir, sizeof(int), 1, fp);
		fread(&vis, sizeof(int), 1, fp);
		fread(&mass, sizeof(int), 1, fp);
		fread(&v_bak, sizeof(int), 1, fp);
		fread(&vcode, sizeof(long int), 1, fp);
		fread(&price, sizeof(int), 1, fp);
	}
};

Auto* addAuto(Auto* s, int& N);
void fillAuto(Auto* s, int N);
void printAuto(Auto* s, int N);
void saveAuto(Auto* s, int N);
Auto* upLoadAuto(int& N);
void sortDate(Auto* s, int N);
void sortPrice(Auto* s, int N);
void sortDvig(Auto* s, int N);
int indexAutoVINFind(Auto*s, int N, long int vin);
void correctAuto(Auto* s, int N, int V);
Auto* delAuto(Auto* s, int& N, long int V);