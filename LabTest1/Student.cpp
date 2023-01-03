#include <iostream>
#include "Student.h"
using namespace std;

Student::Student() {
	final = 0;
	midterm = 0;
}

Student::~Student() {

}

void Student::getName(Student* obj)
{
	cout << "Student Name : "; cin >> obj->name;
}

void Student::getMarks(Student* obj)
{
	cout << "Mid Term Exam : "; cin >> obj->midterm;
	cout << "Final Exam : "; cin >> obj->final;
}

void Student::showResult(Student* obj)
{
	double total = obj->final + obj->midterm;
	bool isPassed = (total >= 40) ? true : false;
	
	cout << "\n--------------------\n";
	cout << "Name : " << obj->name << endl;
	cout << "Total Marks : " << total << endl;

	if (isPassed)
		cout << "You pass!!\n";
	else
		cout << "You fail!!\n";
	
}