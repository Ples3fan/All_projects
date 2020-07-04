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
		cout << "Модель: ";
		cin.get(); cin.getline(tmp, 200);
		mark.setMyString(tmp);
		cout << "Тип кузова: ";
		cin.getline(tmp, 200);
		cuz.setMyString(tmp);
		cout << "Количество дверей: ";
		cin >> dours;
		cout << "Класс: "; cin >> klas;
		cout << "Положение руля: ";
		cin.get(); cin.getline(tmp, 200);
		rule.setMyString(tmp);
		cout << "Год выпуска: "; cin >> data_v;
		cout << "Объем двигателя (куб.см): "; cin >> v_dvig;
		cout << "Мощность (л.с): "; cin >> power;
		cout << "Тип привода: ";
		cin.get(); cin.getline(tmp, 200);
		priv.setMyString(tmp);
		cout << "Тип коробки передач: ";
		cin.getline(tmp, 200);
		k_per.setMyString(tmp);
		cout << "Разгон до 100 км/ч (секунды): ";
		cin >> speed100;
		cout << "Максимальная скорость(км/ч): ";
		cin >> maxspeed;
		cout << "Расход бензина на 100 км: ";
		cin >> benz;
		cout << "Длинна автомобиля(мм): ";
		cin >> dlin;
		cout << "Ширина автомобиля(мм): ";
		cin >> shir;
		cout << "Высота автомобиля(мм): ";
		cin >> vis;
		cout << "Масса автомобиля(кг): ";
		cin >> mass;
		cout << "Объем бензобака(л): "; cin >> v_bak;
		cout << "VIN-код автомобиля: "; cin >> vcode;
		cout << "Цена автомобиля: "; cin >> price;
	}
	
	void printCars()
	{
		cout << "Модель: " << mark.str << endl;
		cout << "Тип кузова: " << cuz.str << endl;
		cout << "Количество дверей: " << dours << endl;
		cout << "Класс: " << klas << endl;
		cout << "Положение руля: " << rule.str << endl;
		cout << "Год выпуска: "<<data_v<<endl;
		cout << "Объем двигателя (куб.см): " << v_dvig << endl;
		cout << "Мощность (л.с): "<<power<<endl;
		cout << "Тип привода: " << priv.str << endl;
		cout << "Тип коробки передач: " << k_per.str << endl;
		cout << "Разгон до 100 км/ч (секунды): " << speed100 << endl;
		cout << "Максимальная скорость(км/ч): " << maxspeed << endl;
		cout << "Расход бензина на 100 км: " << benz << endl;
		cout << "Длинна автомобиля(мм): " << dlin << endl;
		cout << "Ширина автомобиля(мм): " << shir << endl;
		cout << "Высота автомобиля(мм): " << vis << endl;
		cout << "Масса автомобиля(кг): " << mass << endl;
		cout << "Объем бензобака(л): "<<v_bak<<endl;
		cout << "VIN-код автомобиля: "<<vcode << endl;
		cout << "Цена автомобиля: "<<price << endl;
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