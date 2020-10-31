#include "Functions.h"

int Functions::nod(int a, int b)
{
	while (a != b) {
		if (a > b) {
			a = a - b;
		}
		if (b > a) {
			b = b - a;
		}
	}

	return a;
}

int Functions::evenDigits(int a)
{
	int b = 0, n = 1;
	while (a > 0) {
		int tmp = a % 10;
		if (!(tmp % 2)) {
			b += tmp * n;
			n *= 10;
		}
		a /= 10;
	}

	return b;
}

int Functions::sumArray(int **a, int n)
{
	int sum = 0;
	for (int i = 0; i < n; i++) {
		for (int j = i + 1; j < n; j++) {
			if (!(a[i][j] % 2)) {
				sum += a[i][j];
			}
		}
	}

	return sum;
}

void Functions::fillArray(int **&a, int n)
{
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			//a[i][j] = rand() * (double)n / RAND_MAX;
			a[i][j] = rand() % (n * 10) + 1;
		}
	}
}

void Functions::sort(int &x, int &y, int &z) {
	if (x < y) {
		swap(x, y);
	}
	if (x < z) {
		swap(x, z);
	}
	if (y < z) {
		swap(y, z);
	}
}

void Functions::swap(int &a, int &b) {
		int tmp = a; a = b; b = tmp;
}

void Functions::printSort(int x, int y, int z)
{
	cout << endl << "1. " << x << " >= " << y << " >= " << z << endl;
}

void Functions::printNod(int a, int b, int nod)
{
	cout << "2. NOD(" << a << ", " << b << ") = " << nod << endl;
}

void Functions::printEvenDigits(int a, int b)
{
	cout << "3. a = " << a << "; b = " << b << endl;
}

void Functions::printArray(int** a, int n)
{
	cout << "4. "<< endl;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			cout << setw(10) << a[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
}

void Functions::printArrayResult(int** a, int n, int sum)
{
	cout << endl;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			if (i < j) {
				cout << setw(10) << a[i][j] << " ";
			} else {
				cout << setw(10) << "-" << " ";
			}
			
		}
		cout << endl;
	}
	cout << endl;
	cout << "Summary = " << sum << endl;
}
