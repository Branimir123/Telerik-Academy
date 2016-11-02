#include <iostream>
#include "stdafx.h"
#include "FixedStack.h"
#include "assert.h"

//Constructor that creates an empty stack with size that equals zero
template<typename TYPE, int MAX_SIZE>
inline FixedStack<TYPE, MAX_SIZE>::FixedStack()
{
	Size = 0;
}

//Pushing an element
template<typename TYPE, int MAX_SIZE>
void FixedStack<TYPE, MAX_SIZE>::Push(const TYPE & Element)
{
	if (Size == MAX_SIZE) {

		throw std::exception("Stack is full, cannot push more!");
	}

	Data[Size++] = Element;
}


//Popping the top element
template<typename TYPE, int MAX_SIZE>
TYPE& FixedStack<TYPE, MAX_SIZE>::Pop() {
	if (this->Size > 0) {

		return Data[--this->Size];

	}

	throw std::invalid_argument("Stack is empty cannot pop!");
}

//Returning the top element of the stack without removing it
template<typename TYPE, int MAX_SIZE>
TYPE& FixedStack<TYPE, MAX_SIZE>::Top() {

	return this->Data[--this->Size];

}

//Removing all of the elements of the stack 
template<typename TYPE, int MAX_SIZE>
void FixedStack<TYPE, MAX_SIZE>::Clear() {

	this->Size = 0;

}


//Returning the current size of the stack 
template<typename TYPE, int MAX_SIZE>
size_t FixedStack<TYPE, MAX_SIZE>::get_size() {

	return this->Size;

}

//Returning the top element of the stack without removing it
template<typename TYPE, int MAX_SIZE>
size_t FixedStack<TYPE, MAX_SIZE>::get_max_size() {

	return this->MAX_SIZE;

}

//Check if stack is empty 
template<typename TYPE, int MAX_SIZE>
inline bool FixedStack<TYPE, MAX_SIZE>::is_empty() const
{
	return this->Size == 0;
}
