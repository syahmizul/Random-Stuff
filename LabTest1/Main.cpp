#include <iostream>
#include "Student.h"
using namespace std;

int main() {
	Student obj;
	obj.getName(&obj);
	obj.getMarks(&obj);
	obj.showResult(&obj);
}