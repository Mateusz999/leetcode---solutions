class Solution {
public:
    int minimumSum(int num) {
    
    int cyfra = 0;

    vector<int> tablica;

    while(num!=0){
         cyfra = num%10;
         tablica.push_back(cyfra);
         num /=10;
         /*
            W kodzie powyżej wykonujemy prostą operacje pozyskania cyfry z 
            z każdej pozycji liczby w kolejności J/D/S/T itd.
         */
    }
    sort(tablica.begin(),tablica.end());
    int rozmiarTablicy = tablica.size()-1;

    int num1 = 10*tablica[0] + tablica[rozmiarTablicy-1];
    int num2 = 10*tablica[1] + tablica[rozmiarTablicy];
    /*
        W kodzie powyżej dopieramy liczby dwucyfrowe w specyficznej kolejnosci 
        z posortowanego vectora. Robimy to w sposob, który zobrazuje na przykładzie

        1. Liczba na wejściu: 2934
        2. Posortowany vector {2,3,4,9}
        3. num1 = 29, num2 = 34
    */
    return num1+num2;
    }
};