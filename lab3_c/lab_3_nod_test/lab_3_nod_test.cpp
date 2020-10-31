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
	};
}
