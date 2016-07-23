#pragma once
#include<iostream>
using namespace std;
class AD
{
private:
	int *heso;
	int bac;
public:
	DaThuc();
	DaThuc(int, int*);
	friend ostream& operator<<(ostream&, DaThuc);
	friend istream& operator>>(istream&, DaThuc);
	DaThuc operator +(DaThuc);
	DaThuc operator -(DaThuc);
	DaThuc operator *(DaThuc);
	DaThuc operator /(DaThuc);
	~DaThuc();
};

