#include "pch.h"
#include "CppUnitTest.h"
#include "../lab_3_c/Functions.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace lab3sumarraytest
{
	TEST_CLASS(lab3sumarraytest)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			int n = 3;
			int** ptr_array = new int*[n];
			for (int i = 0; i < n; i++) { ptr_array[i] = new int[n]; }
			ptr_array[0][0] = 1; ptr_array[0][1] = 2; ptr_array[0][2] = 4;
			ptr_array[1][0] = 1; ptr_array[1][1] = 1; ptr_array[1][2] = 3;
			ptr_array[2][0] = 1; ptr_array[2][1] = 1; ptr_array[2][2] = 1;
			int extented = 6;
			int result = Functions::sumArray(ptr_array, n);

			Assert::AreEqual(extented, result);
		}
	};
}
