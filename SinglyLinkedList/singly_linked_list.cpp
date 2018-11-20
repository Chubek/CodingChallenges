#include <iostream>

template <class T>
class LinkedList
{
private:
	size_t _size;
public:

	class Node
	{
	public:
		Node* next;
		T value;
		Node(T val) : value(val), next(NULL) {}
	};

	Node* head;

	LinkedList() : _size(0), head(NULL) {}

	~LinkedList() {
		std::cout << "Linked List Deleted!" << std::endl;
	}

	void push(T val) {
		Node* node = new Node(val);
		node->next = head;
		head = node;
		++_size;
	}
	size_t size() {
		return _size;
	}
	bool empty() const {
		return head == NULL;
	}
	T pop() {
		Node* n = head;
		if (n == NULL) return NULL;
		head = n->next;
		_size--;
		return n->value;


	}
};

int main() {
	LinkedList<int> list;
	std::cout << "Empty: " << list.empty() << std::endl;
	list.push(5);
	list.push(6);
	list.push(7);
	list.push(8);
	list.push(9);
	list.push(10);
	std::cout << "Empty: " << list.empty() << std::endl;

	std::cout << "Size: " << list.size() << std::endl;
	list.pop();

	std::cout << "Size: " << list.size() << std::endl;
	LinkedList<int>::Node* n = list.head;
	while (n != NULL) {
		std::cout << n->value << std::endl;
		n = n->next;
	}
}
