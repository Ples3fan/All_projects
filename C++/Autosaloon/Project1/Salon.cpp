#include"Staff.h"
#include"Windows.H"
#define fileAutosloon 1
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(0, "");
	FILE *fp = NULL;
	int id = -1;
	char pass[50] = "";
	char login[50] ="";
	char loginA[50] = "admin";
	char passA[50] = "admin";
	int correct = 0;
	char search[250] = "";
	long int pokup = 0;
	int NCars = 0;
	int NStaff = 0;
	int NSalary = 0;
	Auto* cars = nullptr;
	Staff* staff = nullptr;
	Salary* salary = nullptr;
	
#if fileAutosloon == 1
	cars = upLoadAuto(NCars);
	staff = upLoadStaff(NStaff);
	salary = upLoadSal(NSalary);
	//Массив продаж - дописать
#endif
	cout << "======================================АВТОСАЛОН Mersedes-Benz========================================\n";
	cout << "=====================================================================================================\n";
	cout << "=============================================||||||||================================================\n";
	cout << "==========================================|||===||===|||=============================================\n";
	cout << "=======================================|||======||======|||==========================================\n";
	cout << "=====================================||=========||=========||========================================\n";
	cout << "=====================================||=========||=========||========================================\n";
	cout << "=====================================||=======//==\\\\=======||========================================\n";
	cout << "=====================================||======//====\\\\======||========================================\n";
	cout << "=======================================|||==//======\\\\==|||==========================================\n";
	cout << "==========================================|||========|||=============================================\n";
	cout << "=============================================||||||||================================================\n";
	cout << "=====================================================================================================\n";
	cout << "                                      ВЫБЕРИТЕ ПОЛЬЗОВАТЕЛЯ                                          \n";
	cout << "                                           0 - Клиент                                                \n";
	cout << "                                           1 - Сотрудник                                             \n";
	cout << "\tВаш выбор>>>"; cin >> id;
	bool keyL = false;
	bool keyP = false;
	int pos=0;
	int menu0 = 0;
	int menu1 = 0;
	int menu2 = 0;
	long int vnos = 0;
	int idf = 0;
	staff[0].sales = 0;
	saveStaff(staff, NStaff);
	switch (id)
	{
	case 0:
		do
		{
			cout << "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
			cout << "|||||||||||||||||||||||||||||||||||||||||| МЕНЮ: ||||||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
			cout << "|||||||||||||||||||||||||||||||||||||| 0 - Выход ||||||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 1 - Просмотреть список автомобилей ||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 2 - Сортировать автомобили по Году выпуска ||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 3 - Сортировать автомобили по Цене ||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 4 - Сортировать автомобили по Объему двигателя ||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 5 - Приобрести автомобиль |||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
			cout << "\t\tВаш выбор>>>"; cin >> menu0;
			switch (menu0)
			{
			case 0:cout << "\t\tДо скорой встречи\n"; break;
			case 1: printAuto(cars, NCars); break;
			case 2:sortDate(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//Сортировка по году выпуска
			case 3:sortPrice(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//Сортировка по цене
			case 4:sortDvig(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//Сортировка по объему двигателя
			case 5:cout << "Введите VIN-код желаемого автомобиля: "; 
				cin >> pokup;
				cout << "Обратитесь к продавцу для завершения покупки\n";
				fp = fopen("orders.bin", "ab+");
				fwrite(&pokup, sizeof(long int), 1, fp);
				fclose(fp);
				break;
			default:cout << "Ошибка ввода\n"; break;
				
			}
		} while (menu0!=0);
		return 0;
	case 1:
		do
		{
			cout << "Введите логин(для сотрудников):";
			cin.get(); cin.getline(login, 50);
			cout << "Введите пароль(для сотрудников):";
			cin.getline(pass, 50);
			
				if (strcmp(login,loginA) == 0)
				{
					keyL = true;
					if (strcmp(pass, passA) == 0)
					{
						keyP = true;
						pos = -2;
						break;
					}
				}
				else  
				{
					for (int i = 0; i < NStaff; i++)
					{
						if (strcmp(staff[i].toString(), login) == 0)
						{
							keyL = true;
							if (strcmp(staff[i].birth.toString(), pass) == 0)
							{
								keyP = true;
								pos = indexStaffByPhone(staff, NStaff, atoi(login));
								break;
							}
						}
					}
				}

			
		} while (keyL == false && keyP == false);
		if (pos == -2)
		{
			do
			{
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "\t\t МЕНЮ(администратора): \n";
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "0 - Выход\n";
				cout << "1 - Заполнить БД авто\n";
				cout << "2 - Заполнить БД сотрудников\n";
				cout << "3 - Вывести весь список автомобилей\n";
				cout << "4 - Вывести весь список сотрудников\n";
				cout << "5 - Отчет о продажах\n";
				cout << "6 - Редактирование\n";
				cout << "7 - Добавить автомобиль\n";
				cout << "8 - Добавить сотрудника\n";
				cout << ">>>"; cin >> menu1;
				switch (menu1)
				{
				case 0:cout << "До скорой встречи\n"; break;
				case 1:cout << "Количество автомобилей: "; cin >> NCars;
					cars = new Auto[NCars];
					fillAuto(cars, NCars); 
					saveAuto(cars, NCars);
					break;
				case 2:cout << "Количество сотрудников: "; cin >> NStaff;
					staff = new Staff[NStaff];
					fillStaff(staff, NStaff);
					saveStaff(staff, NStaff);
					break;
				case 3:printAuto(cars, NCars);
					break;
				case 4:printStaff(staff, NStaff);
					break;
				case 5:
					for (int i = 0; i < NStaff; i++)
					{
						NSalary += staff[i].sales;
					}
					printSal(salary, NSalary); break;//Тут отчет о продажах
				case 6:
					do
					{
						cout << "В какой БД будем проводить изменения?(1 - Автомобили, 2 - Сотрудники)\n";//Редактирование полей
						cin >> correct;
						switch (correct)
						{
						case 1:printAuto(cars, NCars);
							cout << "Введите VIN-код автомобиля для корректировки: "; cin >> vnos;
							idf = indexAutoVINFind(cars, NCars, vnos);
							cars = new Auto[NCars];
							correctAuto(cars, NCars, idf);
							saveAuto(cars, NCars);
							break;
						case 2:printStaff(staff, NStaff);
							cout << "Введите ФИО сотрудника: ";
							cin.get(); cin.getline(search, 250);
							idf = searchStaff(staff, NStaff, search);
							staff = new Staff[NStaff];
							correctStaff(staff, NStaff, idf);
							saveStaff(staff, NStaff);
							break;
						default:cout << "Введены неверные данные\n";
							break;
						}
					} while (correct != 0);
				case 7:cars = addAuto(cars, NCars);
					saveAuto(cars, NCars);
					break;
				case 8:staff = addStaff(staff, NStaff);
					saveStaff(staff, NStaff);
					break;
				default:cout << "Ошибка ввода\n"; break;
				}
			} while (menu1!=0);
			return 0;
		}
		if (pos >=0 )
		{
			do
			{
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "\t\t МЕНЮ(сотрудника): \n";
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "0 - Выход\n";
				cout << "1 - Список автомобилей\n";
				cout << "2 - Моя статистика\n";
				cout << "3 - Оформить продажу\n";
				cout << ">>>"; cin >> menu2;
				switch (menu2)
				{
				case 0:cout << "До скорой встречи\n"; break;
				case 1:printAuto(cars, NCars);
					break;
				case 2: printPosStaff(staff, NStaff, pos); break;//Тут статистика конкретного продавца
				case 3:
					getVINCode();
					cout << "Введите VIN-код\n";
					cin >> vnos;
					idf= indexAutoVINFind(cars, NCars, vnos);
					if (idf != -1)
					{
						staff[pos].addSales(cars[idf]);
						saveStaff(staff, NStaff);
						addBD(cars, salary, staff[pos].sales, vnos);
						saveSal(salary, staff[pos].sales);
						delAuto(cars, NCars, vnos);
						saveAuto(cars, NCars);
					}
					else
					{
						cout << "Нет такого VIN-кода\n"; 
					}
					break;

					//Тут перенос автомобиля в массив продаж

				default:cout << "Ошибка ввода\n";
					break;
				}
			} while (menu2!=0);
		}
	default:
		break;
	}
	system("pause");
	return 0;
}