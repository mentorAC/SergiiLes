#include <iostream>

using namespace std;

int main() {

	/*int a = 10;

	int* ptr = &a;
	cout << &a << "\t" << ptr << endl;

	*ptr = 11;
	cout << a << endl;*/

	/*int arr[5]{5,4,3,2,1};
	cout << arr<< endl;
	cout << &arr[0] << "\t" << (arr + 0)<< "\t" << arr[0] << "\t" << *(arr + 0) << endl;
	cout << &arr[1] << "\t" << (arr + 1) << "\t" << arr[1] << "\t" << *(arr + 1) << endl;
	cout << &arr[2] << "\t" << (arr + 2) << "\t" << arr[2] << "\t" << *(arr + 2) << endl;
	cout << &arr[3] << "\t" << (arr + 3) <<"\t" << arr[3]<< "\t" << *(arr + 3) << endl;*/

	///int a = 10;
	int* arr = new int[10];

	arr += 1;
	delete[] arr;


	int a = 10;
	int& ref = a;

	ref = 15;
	cout << a;



	return 0;
}