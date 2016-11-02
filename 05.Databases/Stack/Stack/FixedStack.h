#pragma once

template <typename TYPE, int MAX_SIZE>
class FixedStack {
	public:
		inline FixedStack();
		
		void Push(const TYPE & obj);
		TYPE& Pop();
		TYPE& Top();
		void Clear();

		size_t get_size();
		size_t get_max_size();
		bool is_empty() const;

	private:
		TYPE Data[MAX_SIZE];
		size_t Size;
};