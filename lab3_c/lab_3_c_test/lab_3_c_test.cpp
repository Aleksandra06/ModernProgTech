#include "pch.h"
#include "CppUnitTest.h"
#include "../lab_3_c/Functions.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace lab3ctest
{
	TEST_CLASS(TestSortС2)
	{
	public:
		
		TEST_METHOD(Sort_123_if_true)
		{
			int result_x = 1, result_y = 3, result_z = 5;
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}

		TEST_METHOD(Sort_23_if_true)
		{
			int result_x = 3, result_y = 1, result_z = 5;
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}

		TEST_METHOD(Sort_13_if_true)
		{
			int result_x = 1, result_y = 5, result_z = 3;
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}

		TEST_METHOD(Sort_1_if_true)
		{
			int result_x = 3, result_y = 5, result_z = 1;
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}
		TEST_METHOD(Sort_2_if_true)
		{
			int result_x = 3, result_y = 3, result_z = 5;
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}

		TEST_METHOD(Sort_3_if_true)
		{
			int result_x = 5, result_y = 3, result_z = 5; // 5 5 6 | 
			int extented_x = 5, extented_y = 3, extented_z = 1;

			Functions::sort(result_x, result_y, result_z);

			Assert::IsTrue(extented_x = result_x);
			Assert::IsTrue(extented_y = result_y);
			Assert::IsTrue(extented_z = result_z);
		}
	};
}
