using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine(" Wybierz zadanie:");
            Console.WriteLine("1. Zadanie 2.1");
            Console.WriteLine("2. Zadanie 2.2");
            Console.WriteLine("3. Zadanie 2.3");
            Console.WriteLine("4. Zadanie 2.4");
            Console.WriteLine("5. Zadanie 2.5");
            Console.WriteLine("6. Zadanie 2.6");
            Console.WriteLine("7. Zadanie 2.7");
            Console.WriteLine("8. Zadanie 2.8");
            Console.WriteLine("9. Zadanie 2.9");
            Console.WriteLine("10. Zadanie 2.10");
            Console.WriteLine("11. Zakończ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                // ZADANIE 1 
                
                case "1":
                    Console.Clear();
                    double F, C;
            
                    Console.WriteLine("Wpisz temperature w Celsjusza: ");
                    C = double.Parse(Console.ReadLine());


                    F = (9 * C) / 5 + 32;
                    
                    
                    Console.WriteLine("Temperatura w stopniach Farenhaita: ");
                    Console.WriteLine(F);
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                   
                   Console.ReadKey(); 
                    

                    break;
                
                // ZADANIE 2 
                case "2":
                    Console.Clear();

                    double a, b, c, delta;
                    Console.WriteLine("Obliczanie delty dla równania kwadratowego  ax^2+bx+c=0 ");
                    
                    Console.WriteLine("Podaj a:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj b:");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj c:");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Delta dla tego równania wynosi: ");
                    delta = (b * b) - 4 * a * c;
                    Console.WriteLine(delta);
                    
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 3 
                case "3":
                    Console.Clear();

                    double masa, wzrost, BMI;
                        Console.WriteLine("Kalkulator BMI");
                    
                    Console.WriteLine("Podaj swoją mase w kilogramach:");
                    masa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj swój wzrost w metrach");
                    wzrost = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Twoje BMI wynosi: ");
                    BMI = masa / (wzrost * wzrost);
                    Console.WriteLine(BMI);
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 4
                case "4":
                    Console.Clear();

                    int x = 100;
                    Console.WriteLine(++x * 2);
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 5 
                case "5":
                    Console.Clear();

                    int x2 = 2, y2 = 3;
                    x2 *= y2 * 2;
                    
                    Console.WriteLine("Zmienna x=");
                    Console.WriteLine(x2);
                    
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 6
                case "6":
                    Console.Clear();

                    int x3, y3 = 4;
                    x3 = (y3 -= 2);
                    x3 = y3++;
                    x3 = y3--; 
                    
                    Console.WriteLine("Zmienna x=" + x3);
                  
                    
                    
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 7
                case "7":
                    Console.Clear();
                    
                    int x4, y4 = 5;
                    x4 = ++y4 * 2;
                    x4 = y4++;
                    x4 = y4--;
                    Console.WriteLine("y = " + ++y4); 
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 8
                case "8":
                    Console.Clear();
                    
                    bool x5;
                    int y5 = 1, z5 = 1;
                    x5 = (y5 == 1 &&  z5++ == 1);
                    Console.WriteLine("x = " + x5);
                    Console.WriteLine("y = " + y5);
                    Console.WriteLine("z = " + z5);

                    
                    
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                // ZADANIE 9 
                case "9":
                    Console.Clear();
                    
                    //a)
                    int x6 = 1, y6 = 4, z6 = 2;
                    bool wynik6 = (x6++ > 1 && y6++ == 4 && z6-- > 0);
                    Console.WriteLine("a) wynik={0} x={1} y={2} z={3}", wynik6, x6, y6, z6);
                    
                    //b)
                    int x7 = 1, y7 = 4, z7 = 2;
                    bool wynik7 = (x7++ > 1 & y7++ == 4 && z7-- > 0);
                    Console.WriteLine("b) wynik={0} x={1} y={2} z={3}", wynik7, x7, y7, z7);

                    //c)
                    int x8 = 1, y8 = 4, z8 = 2;
                    bool wynik8 = (x8++ > 1 & y8++ == 4 & z8-- > 0);
                    Console.WriteLine("c) wynik={0} x={1} y={2} z={3}", wynik8, x8, y8, z8);
                    
                    //d)
                    int x9 = 1, y9 = 3, z9 = 4;
                    bool wynik9 = (x9 == 1 || y9++ > 2 || ++z9 > 0);
                    Console.WriteLine("d) wynik={0} x={1} y={2} z={3}", wynik9, x9, y9, z9);
                    
                    //e)
                    int x10 = 1, y10 = 3, z10 = 4;
                    bool wynik10 = (x10 == 1 | y10++ > 2 || ++z10 > 0);
                    Console.WriteLine("e) wynik={0} x={1} y={2} z={3}", wynik10, x10, y10, z10);
                    
                    //f)
                    int x11 = 1, y11 = 3, z11 = 4;
                    bool wynik11 = (x11 == 1 | y11++ > 2 | ++z11 > 0);
                    Console.WriteLine("f) wynik={0} x={1} y={2} z={3}", wynik11, x11, y11, z11);
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                
                // ZADANIE 9 
                case "10":
                    Console.Clear();
                    
                    double powierzchnia = 100, osoby = 10;
                    double gestoscZaludnienia = osoby/powierzchnia;
                    Console.WriteLine(gestoscZaludnienia);
                   
                    
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
                
                // ZADANIE 3 
                case "11":
                    // Wyjście z programu
                    return;
                default:
                    Console.Clear();
                    
                   
                   
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    Console.WriteLine("WCISNIJ DOWOLNY KLAWISZ BY PRZEJSC DO WYBORU ZADANIA");
                    
                    Console.ReadKey();
                    
                    break;
            }
        }
    }
}