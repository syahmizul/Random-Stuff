//Queue.h
#ifndef QUEUE_H
#define QUEUE_H

const int SIZE = 5;
template<class MyData>
class Queue
{
private:
	MyData tata[SIZE]; //array
	int bil;
	int front;
	int rear;
public:
	Queue();
	void Enqueue(MyData);
	void Dequeue();
	MyData QueueFront();
	MyData QueueRear();
	bool Empty();
	void PrintArray();

};
#endif

template <class MyData>
Queue<MyData>::Queue()
{
	front = -1;
	rear = -1;
	bil = 0;
}	//end Constructor

template <class MyData>
void Queue<MyData>::Enqueue(MyData value)
{
	if (bil < SIZE)
	{
		cout << "\nInsert " << value << " into queue.";
		rear++;
		if (rear == SIZE) //once rear is the same as SIZE,rear is equal to 0
			rear = 0;
		if (bil == 0) //sets front to 0 on first iteration
			front = 0;
		tata[rear] = value;
		bil++;
	}
	else
		cout << "Overflow!!!";
}	// end Enqueue

template <class MyData>
void Queue<MyData>::Dequeue()
{
	if (bil == 0)
		cout << "Underflow!!!!!";
	else
	{
		cout << "\nDequeue:" << tata[front];
		front++;
		if (front == SIZE)
			front = 0;
		if (bil == 1)
			rear = front = -1;
		bil--;
	}
} // end Dequeue

template <class MyData>
bool Queue <MyData>::Empty()
{
	return(bil == 0);
} //end Empty

template<class MyData>
void Queue<MyData>::PrintArray()
{
	cout << "Elements in queue : ";
	for (int i = 0; i < sizeof(tata); i++)
		cout << tata[i];
	cout << endl;
}

template <class MyData>
MyData Queue <MyData>::QueueFront()
{
	if (Empty())
		return false;
	else
		return tata[front];
} //end QueueFront

template <class MyData>
MyData Queue <MyData>::QueueRear()
{
	if (Empty())
		return false;
	else
		return tata[rear];
} //end QueueRear