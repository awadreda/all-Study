#include <iostream>
using namespace std;

struct stInfo
{
  int age;
  bool HasDriverLisence;
  bool HasRecommendation;
};

stInfo ReadInfo()
{
  stInfo Info;
  cout << "Enter age: " << endl;
  cin >> Info.age;
  cout << "Do you have driving lisence?: " << endl;
  cin >> Info.HasDriverLisence;
  cout << "Do you have a recommendation?: " << endl;
  cin >> Info.HasRecommendation;

  return Info;
}

bool IsAccepted(stInfo Info)
{
  if (Info.HasRecommendation)
  {
    return true;
  }
  else
  {
    return (Info.age > 21 && Info.HasDriverLisence);
  }
}

void PrintInfo(stInfo Info)
{
  if (IsAccepted(Info))
  {
    cout << "\nHired" << endl;
  }
  else
  {
    cout << "\Rejected" << endl;
  }
}

int main()
{

  PrintInfo(ReadInfo());

  return 0;
}