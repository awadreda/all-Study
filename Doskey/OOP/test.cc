#include <iostream>
#include <string>
using namespace std;

struct strInfo
{
  string firstname, lastname, phone;
  int age;
};

void readInfo(strInfo &Info)
{

  cout << "enter your first name: \n";
  cin >> Info.firstname;

  cout << "enter last name: " << endl;
  cin >> Info.lastname;

  cout << "enter age: " << endl;
  cin >> Info.age;

  cout << "enter phone number: " << endl;
  cin >> Info.phone;
}

void printInfo(strInfo Info)
{

  cout << "*******************************" << endl;
  cout << "firs name: " << Info.firstname << endl;
  cout << "last name: " << Info.lastname << endl;
  cout << "age: " << Info.age << endl;
  cout << "phone: " << Info.phone << endl;
  cout << "*******************************" << endl;
}

int main()
{

  strInfo person1Info;
  readInfo(person1Info);
  printInfo(person1Info);

  return 0;
}