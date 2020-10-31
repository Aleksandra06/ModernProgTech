#include "pch.h"
#include "CppUnitTest.h"
#include "../lab_3_c/Functions.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace lab3evendigisttest
{
	TEST_CLASS(lab3evendigisttest)
	{
	public:
		
		TEST_METHOD(Test_all_if_true)
		{
			int a = 2468;
			int extented = 2468;
			int result = Functions::evenDigits(a);
			Assert::AreEqual(extented, result);
		}

		TEST_METHOD(Test_not_if_true1)
		{
			int a = 13579;
			int extented = 0;
			int result = Functions::evenDigits(a);
			Assert::AreEqual(extented, result);
		}

		TEST_METHOD(Test_diff_if_true)
		{
			int a = 12345;
			int extented = 24;
			int result = Functions::evenDigits(a);
			Assert::AreEqual(extented, result);
		}

		TEST_METHOD(Test_0_if_true)
		{
			int a = 0;
			int extented = 0;
			int result = Functions::evenDigits(a);
			Assert::AreEqual(extented, result);
		}
	};
}
