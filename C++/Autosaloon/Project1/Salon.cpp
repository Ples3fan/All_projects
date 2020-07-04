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
	//������ ������ - ��������
#endif
	cout << "======================================��������� Mersedes-Benz========================================\n";
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
	cout << "                                      �������� ������������                                          \n";
	cout << "                                           0 - ������                                                \n";
	cout << "                                           1 - ���������                                             \n";
	cout << "\t��� �����>>>"; cin >> id;
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
			cout << "|||||||||||||||||||||||||||||||||||||||||| ����: ||||||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
			cout << "|||||||||||||||||||||||||||||||||||||| 0 - ����� ||||||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 1 - ����������� ������ ����������� ||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 2 - ����������� ���������� �� ���� ������� ||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 3 - ����������� ���������� �� ���� ||||||||||||||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 4 - ����������� ���������� �� ������ ��������� ||||||||||||||||||||||||||||\n";
			cout << "||||||||||||||||||||||||| 5 - ���������� ���������� |||||||||||||||||||||||||||||||||||||||||||||||||\n";
			cout << "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
			cout << "\t\t��� �����>>>"; cin >> menu0;
			switch (menu0)
			{
			case 0:cout << "\t\t�� ������ �������\n"; break;
			case 1: printAuto(cars, NCars); break;
			case 2:sortDate(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//���������� �� ���� �������
			case 3:sortPrice(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//���������� �� ����
			case 4:sortDvig(cars, NCars);
				saveAuto(cars, NCars);
				printAuto(cars, NCars);
				 break;//���������� �� ������ ���������
			case 5:cout << "������� VIN-��� ��������� ����������: "; 
				cin >> pokup;
				cout << "���������� � �������� ��� ���������� �������\n";
				fp = fopen("orders.bin", "ab+");
				fwrite(&pokup, sizeof(long int), 1, fp);
				fclose(fp);
				break;
			default:cout << "������ �����\n"; break;
				
			}
		} while (menu0!=0);
		return 0;
	case 1:
		do
		{
			cout << "������� �����(��� �����������):";
			cin.get(); cin.getline(login, 50);
			cout << "������� ������(��� �����������):";
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
				cout << "\t\t ����(��������������): \n";
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "0 - �����\n";
				cout << "1 - ��������� �� ����\n";
				cout << "2 - ��������� �� �����������\n";
				cout << "3 - ������� ���� ������ �����������\n";
				cout << "4 - ������� ���� ������ �����������\n";
				cout << "5 - ����� � ��������\n";
				cout << "6 - ��������������\n";
				cout << "7 - �������� ����������\n";
				cout << "8 - �������� ����������\n";
				cout << ">>>"; cin >> menu1;
				switch (menu1)
				{
				case 0:cout << "�� ������ �������\n"; break;
				case 1:cout << "���������� �����������: "; cin >> NCars;
					cars = new Auto[NCars];
					fillAuto(cars, NCars); 
					saveAuto(cars, NCars);
					break;
				case 2:cout << "���������� �����������: "; cin >> NStaff;
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
					printSal(salary, NSalary); break;//��� ����� � ��������
				case 6:
					do
					{
						cout << "� ����� �� ����� ��������� ���������?(1 - ����������, 2 - ����������)\n";//�������������� �����
						cin >> correct;
						switch (correct)
						{
						case 1:printAuto(cars, NCars);
							cout << "������� VIN-��� ���������� ��� �������������: "; cin >> vnos;
							idf = indexAutoVINFind(cars, NCars, vnos);
							cars = new Auto[NCars];
							correctAuto(cars, NCars, idf);
							saveAuto(cars, NCars);
							break;
						case 2:printStaff(staff, NStaff);
							cout << "������� ��� ����������: ";
							cin.get(); cin.getline(search, 250);
							idf = searchStaff(staff, NStaff, search);
							staff = new Staff[NStaff];
							correctStaff(staff, NStaff, idf);
							saveStaff(staff, NStaff);
							break;
						default:cout << "������� �������� ������\n";
							break;
						}
					} while (correct != 0);
				case 7:cars = addAuto(cars, NCars);
					saveAuto(cars, NCars);
					break;
				case 8:staff = addStaff(staff, NStaff);
					saveStaff(staff, NStaff);
					break;
				default:cout << "������ �����\n"; break;
				}
			} while (menu1!=0);
			return 0;
		}
		if (pos >=0 )
		{
			do
			{
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "\t\t ����(����������): \n";
				cout << "+++++++++++++++++++++++++++++++++++++\n";
				cout << "0 - �����\n";
				cout << "1 - ������ �����������\n";
				cout << "2 - ��� ����������\n";
				cout << "3 - �������� �������\n";
				cout << ">>>"; cin >> menu2;
				switch (menu2)
				{
				case 0:cout << "�� ������ �������\n"; break;
				case 1:printAuto(cars, NCars);
					break;
				case 2: printPosStaff(staff, NStaff, pos); break;//��� ���������� ����������� ��������
				case 3:
					getVINCode();
					cout << "������� VIN-���\n";
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
						cout << "��� ������ VIN-����\n"; 
					}
					break;

					//��� ������� ���������� � ������ ������

				default:cout << "������ �����\n";
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