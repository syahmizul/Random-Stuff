class Student {
private:
	double final;
	double midterm;
	char name[20];

public:
	Student();
	~Student();
	void getName(Student* obj);
	void getMarks(Student* obj);
	void showResult(Student* obj);
};
