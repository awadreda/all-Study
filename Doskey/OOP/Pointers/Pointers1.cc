#include <iostream>
#include <algorithm>
using namespace std;

int main()
{

  int x;
  x = 12;
  int *ptr;
  ptr = &x;
  cout << ptr << "\n";
  cout << *ptr << "\n";
  *ptr += 10;
  cout << x << "\n";
  cout << ptr << "\n";

  return 0;
}
