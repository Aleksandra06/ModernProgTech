#include "pch.h"
#include "CppUnitTest.h"
#include "../lab_3_c/Functions.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace lab3nodtest
{
	TEST_CLASS(TestNod)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			int a = 65, b = 78;
			int extented = 13;

			int result = Functions::nod(a, b);

			Assert::AreEqual(extented, result);
		}
		TEST_METHOD(Test_1_if_true)
		{
			int a = 26, b = 13;
			int extented = 13;

			int result = Functions::nod(a, b);

			Assert::AreEqual(extented, result);
		}
		TEST_METHOD(Test_2_if_true)
		{
			int a = 15, b = 30;
			int extented = 15;

			int result = Functions::nod(a, b);

			Assert::AreEqual(extented, result);
		}

		TEST_METHOD(Test_12_if_true)
		{
			int a = 6, b = 4;
			int extented = 2;

			int result = Functions::nod(a, b);

			Assert::AreEqual(extented, result);
		}

		TEST_METHOD(Test_0_if_true)
		{
			int a = 13, b = 13;
			int extented = 13;

			int result = Functions::nod(a, b);

			Assert::AreEqual(extented, result);
		}

	};
}
