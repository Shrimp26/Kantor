using System;
//Zaimplementuj kalkulator walutowy. Sprawdź obecne kursy wymiany walut i zakoduj je na stałe.
//Użytkownik jest proszony o podanie kwoty w PLN oraz waluty docelowej (do wyboru EUR, CHF, GBP).
//Niech program najpierw przelicza kwotę na walutę pośrednią w USD, a następnie na walutę docelową.
//Wynik przewalutowania wyświetl w konsoli.

class Kantor{
    static double ExchangeCurrency(double amount, string fromCurrency, string toCurrency)
    {
        double plnToUsdRate = 0.25;
        double usdToEurRate = 0.91;
        double usdToChfRate = 0.88;
        double usdToGbpRate = 0.79;

        double usdAmount = amount * plnToUsdRate;

        double resultAmount;
        switch (toCurrency)
        {
            case "EUR":
                resultAmount = usdAmount * usdToEurRate;
                break;
            case "CHF":
                resultAmount = usdAmount * usdToChfRate;
                break;
            case "GBP":
                resultAmount = usdAmount * usdToGbpRate;
                break;
            default:
                throw new ArgumentException("Nieprawidłowa wartość docelowa");
        }
        return resultAmount;
    }
    
    static void Main()
    {
        Console.WriteLine("Wprowadź kwotę w PLN");
        if (double.TryParse(Console.ReadLine(), out double plnAmount))
        {
            Console.WriteLine("Wprowadź walutę docelową (EUR, CHF, GBP): ");
            string targetCurrency = Console.ReadLine().ToUpper();

            double result = ExchangeCurrency(plnAmount, "PLN", targetCurrency);

            Console.WriteLine($"{plnAmount} PLN jest wart około {result:F2}{targetCurrency}");
        }
        else
        {
            Console.WriteLine("Niepoprawna wartość. Proszę wprowadzić poprawną wartość.");
        }
    }

}

