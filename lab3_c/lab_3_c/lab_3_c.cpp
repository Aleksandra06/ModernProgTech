#include "Functions.h"
#include <time.h>

int main()
{
	srand(time(NULL));

	int x, y, z;

	x = 5;
	y = 1;
	z = 3;

	Functions functions;

	functions.sort(x, y, z);
	functions.printSort(x, y, z);
	
	int a =323, b = 306;

	int nod = functions.nod(a, b);
	functions.printNod(a, b, nod);

	int a2 = 12345;

	int b2 = functions.evenDigits(a2);
	functions.printEvenDigits(a2, b2);

	int n = 4;
	int** ptr_array = new int*[n];
	for (int i = 0; i < n; i++) { ptr_array[i] = new int[n]; }


	functions.fillArray(ptr_array, n);
	int sum = functions.sumArray(ptr_array, n);
	functions.printArray(ptr_array, n);
	functions.printArrayResult(ptr_array, n, sum);

	return 0;
}