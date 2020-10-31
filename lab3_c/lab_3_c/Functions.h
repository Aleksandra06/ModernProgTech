#pragma once
#include <iostream>
#include <iomanip>
using namespace std;

class Functions {
	
public: 
	
	static void sort(int& x, int& y, int& z);

	static int nod(int a, int b);

	static int evenDigits(int a);

	static int sumArray(int **a, int n);

	static void fillArray(int **&a, int n);

	void printSort(int x, int y, int z);

	void printNod(int a, int b, int nod);

	void printEvenDigits(int a, int b);

	void printArray(int **a, int n);

	void printArrayResult(int **a, int n, int sum);

private:
	static void swap(int& a, int& b);

};

