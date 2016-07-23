#include "DaThuc.h"


DaThuc::DaThuc(int bac)
{
	this->bac = bac;
	this->heso = new int[30];
}
DaThuc::DaThuc() {

	this->bac = 0;
	this->heso = new int;
}
DaThuc DaThuc::operator+(DaThuc dt)
{
	DaThuc kq;
	for (int i = 0; i <= bac; i++) {
		kq.heso[i] = dt.heso[i] + heso[i];
	}
	
	return kq;
} 

DaThuc::~DaThuc()
{
}

ostream & operator<<(ostream &out, DaThuc dathuc)
{
	for (int i = 0; i <= dathuc.bac; i++) {
		out << dathuc.heso[i] << "*x^" << dathuc.bac - 1<<"+";
		if (i == dathuc.bac) {
			out << dathuc.heso[i];
		}
		out << "=0";
	}
	return out;
	// TODO: insert return statement here
}

istream & operator>>(istream &in, DaThuc dathuc)
{
	cout << "Nhap vao bac cua da thuc :";
	in >> dathuc.bac;
	for (int i = 0; i <= dathuc.bac; i++) {
		cout << " He so a[" << i << "] =";
		in >> dathuc.heso[i];
	}
	return in;
	// TODO: insert return statement here
}
int main() {
	DaThuc dt1;
	DaThuc dt2;
	cin >> dt1;
	cout << dt1;
	cin >> dt2;
	cout << dt2;
	cout << dt1 + dt2;
	system("pause");
	return 0;
}