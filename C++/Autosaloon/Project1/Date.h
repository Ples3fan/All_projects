#pragma once
#include "Lib.h"

struct Date{
	//свойства структуры
	int year = 0;
	int month = 0;
	int day = 0;

	//методы структуры
	void fillDate()	{
		cout << "введите год -> ";
		cin >> year;
		cout << "введите мес€ц -> ";
		cin >> month;
		cout << "введите день -> ";
		cin >> day;
	}
	void getNowDate()	{
		// создаем стд объект даты и времени
		struct tm *tim = new tm;
		// определ€ем текущую млисекунду
		time_t tt = time(NULL);
		//заполн€ем все пол€ стд структуры
		localtime_s(tim, &tt);
		//заполн€ем нужные пол€ нашей структуры
		year = 1900 + tim->tm_year;
		month = 1 + tim->tm_mon;
		day = tim->tm_mday;
	}
	void printDate(){
		cout << year << "/" << month / 10 << month%10 << "/" << day << endl;
	}

	char* toString()
	{
		char* str = new char[11];
		sprintf(str, "%d/%d%d/%d%d", year, month / 10, month%10, day/10,day%10);
		return str;
	}

	bool isLeapYear(){
		if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
			return true;
		else 
			return false;
	}

	int monthDays(){
		if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
			return 31;
		else if (month == 4 || month == 6 || month == 9 || month == 11)
			return 30;
		else if (isLeapYear())
			return 29;
		else
			return 28;
	}

	void toNextDay(){
		if (month == 12 && day == 31)
		{
			month = 1;
			day = 1;
			year++;
		}
		else if (day == monthDays())
		{
			day = 1;
			month++;
		}
		else
		{
			day++;
		}
	}
};

 