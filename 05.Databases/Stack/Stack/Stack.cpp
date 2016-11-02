// Stack.cpp : Defines the entry point for the console application.

#include "stdafx.h"
#include <iostream>
#include "FixedStack.h"
#include "FixedStack.cpp"

int main()
{

	FixedStack<int, 10> stack;

	try {
		stack.Push(10);
		stack.Push(10);

		std::cout << stack.Pop();

		stack.Clear();

		std::cout << stack.Pop();
	}
	catch (const std::exception& ex) {
		std::cout << ex.what() << std::endl;
	}

	return 0;
}

