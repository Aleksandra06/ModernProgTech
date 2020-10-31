#include "pch.h"
#include "CppUnitTest.h"
#include "../lab_3_c/Functions.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace lab3evendigisttest
{
	TEST_CLASS(lab3evendigisttest)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			int a = 12345;
			int extented = 24;
			int result = Functions::evenDigits(a);
			Assert::AreEqual(extented, result);
		}
	};
}
