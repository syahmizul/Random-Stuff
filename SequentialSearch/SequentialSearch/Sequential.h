#ifndef SEQUENTIAL_H
#define SEQUENTIAL_H
const int SIZE = 10;
class Sequential {
public:
	int locationWanted;
	int array[SIZE];
	bool SequentialSearch(int[], int, int, int&);

};
#endif