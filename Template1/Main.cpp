#include <iostream>
using namespace std;

template<class T>
class Template {
private:
	T instvar1;
public:
	Template(T v1);
	~Template();
	T printout();
};
template<class T>
Template<T>::Template(T v1) {
	instvar1 = v1;

}
template<class T>
Template<T>::~Template() {

}template<class T>
T Template<T>::printout() {
	return instvar1;
}


int main()
{
	Template<float> test(1.2);
	cout << test.printout();
}