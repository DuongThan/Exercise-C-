#pragma once
#include<iostream>
using namespace std;
class DaThuc
{
private:
	int *heso;
	int bac;
public:
	DaThuc();
	DaThuc(int);
	friend ostream& operator<<(ostream&, DaThuc);
	friend istream& operator>>(istream&, DaThuc);
	DaThuc operator +(DaThuc);
	DaThuc operator -(DaThuc);
	DaThuc operator *(DaThuc);
	DaThuc operator /(DaThuc);
	~DaThuc();
};

