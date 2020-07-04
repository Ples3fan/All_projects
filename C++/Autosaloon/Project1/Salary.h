#pragma once
#include"Auto.h"
#include"Date.h"

struct Salary {
	
	Date DSalar;
	Auto cars;
	
	
	void addSales(Auto order) 
	{
		DSalar.getNowDate();
		cars = order;
	}
	
	void printSale() {
		cout << "Дата продажи: " << DSalar.toString() << endl;
		cout << "Автомобиль (VIN-код): " << cars.vcode << endl;
	}
	void toBinSale(FILE*fp) {
		fwrite(&DSalar, sizeof(Date), 1, fp);
		fwrite(&cars.vcode, sizeof(long int), 1, fp);
	}
	void fromBinSale(FILE *fp) {
		fread(&DSalar, sizeof(Date), 1, fp);
		fread(&cars.vcode, sizeof(long int), 1, fp);
	}

};

Salary* addBD(Auto* s, Salary* ss1, int& N,long int V);
void printSal(Salary* s, int N);
void saveSal(Salary* s, int N);
Salary* upLoadSal(int& N);