/* 
Masz daną liczbę n, która odpowiada numerze zespołów biorących udział w turnieju,
który na dziwne zasady

1. Jeśli bieżący numer drużyn jest parzysty, każda drużyna ma pare.
    Całkowita ilość dopasowań to n/2, oraz ta sama ilość awansuje to kolejnej rundy.

2. Jeśli bieżąca ilość drużyn jest nieparzysta, jeden zespół randomowo awantuje
    do kolejnej rundy, a reszta zostawie sparowana. Całkowita liczba dopasowań to
    (n-1)/2, natomiast (n-1)/2+1 drużyn awantuje do kolejnej rundy.

Zwróć liczbę dopasowań w całym turnieju

Ograniczenia: 1 <= n <= 200
*/

class Solution {
public:
    int numberOfMatches(int n) {
    
    int iloscDopasowan = 0;

    while(n>1){
        if(n% 2 == 0){

            iloscDopasowan += n/2;
            n/=2;
        } 
        else{
            iloscDopasowan+= (n-1)/2;
            n = (n-1)/2+1;
        }
    }

    return iloscDopasowan;
    }
};