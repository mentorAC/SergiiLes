#include <iostream>

using namespace std;

int main() {
	//cout << "hello c++!";


	//const int c_size = 5;
	//int size;
	//cin >> size;
	//int arr[c_size];//{ 5,2,7,3,9 };



	/*for (int i = 0; i < 5; i++)
	{
		cout << arr[i] << " ";
	}*/

	int a = 10;
	int b = 11;

	cout << "Value\taddress\n";
	cout << a << "\t" << &a << endl;
	cout << b << "\t" << &b << endl;

	return 0;
}