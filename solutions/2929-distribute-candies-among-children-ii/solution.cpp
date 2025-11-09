class Solution {
    /*
        Mamy dane dwie dodatnie liczby całkowite N i LIMIT

        Zwróć TOTAL NUMBER rozdystrubuowaniu N cukierów pośród trójkę dzieci tak,
        że żadne dziecko nie będzie miało więcej cukierków niż wynosi LIMIT.

        Ograniczenia:
        1 <= n <= 1 000 000 ( 10^6)
        1 <= limit <= 1 000 000 (10^6)



    */
public:
    long long distributeCandies(int n, int limit) {
        long long licznik = 0; 

        for (int i = 0; i <= min(limit, n); i++) {
            if (n - i <= 2 * limit) licznik += min(n - i, limit) - max(0, n - i - limit) + 1;
        }
        return licznik;
    }
};