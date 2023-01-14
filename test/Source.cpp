#include <iostream>

using namespace std;

int main() {
	bool b = false;
	int a;

	cin >> a; //-5
	b = 1 <= a <= 10;

	cout << b;
	return 0;
}