#include <iostream>
using namespace std;
#include <array>
#include <vector>

int main()

{
  int nums[] = {10, 20, 30, 40};
  cout << nums << "\n";
  cout << &nums[0] << "\n";

  cout << nums[0] << "\n";
  cout << *nums << "\n";

  cout << nums[1] << "\n";
  cout << *(nums + 1) << "\n";

  int *ptr = nums;

  cout << "\n===========================\n";
  cout << ptr << "\n";
  cout << *ptr << "\n";
  cout << "\n===========================\n";
  ptr++;
  cout << ptr << "\n";
  cout << *ptr << "\n";
  cout << "\n===========================\n";
  ptr += 2;
  cout << ptr << "\n";
  cout << *ptr << "\n";
  cout << "\n===========================\n";

  return 0;
}