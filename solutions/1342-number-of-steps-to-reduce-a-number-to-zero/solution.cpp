/*
Daną mamy liczbę całkowitą num, zwróć ilość kroków potrzebną do zredukowania jej do zera.

W pierwszym kroku, jeśli wartość jest parzysta, musimy podzielić ją przez 2,
w innym wypadku musimy odjąc 1

Ograniczenia:
0 <= n <=1 000 000 
*/

class Solution {
public:
    int numberOfSteps(int num) {
    int licznik = 0;

    if(num == 0) return 0;
    while(num!=0){
        if(num % 2 == 0) num/=2;
        else num--;
    licznik++;
    }
    return licznik;
    }
};