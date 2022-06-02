

//OOP
//*************************

using QuizDay1.OOP;

Angkot angkot1 = new Angkot("D1234UM", "2015","ANGKOT",4_500,20);
Angkot angkot2 = new Angkot("D1256UM", "2017", 23_500, 5);
SUV suv1 = new SUV("D111X","2017",500_000,17);
SUV suv2 = new SUV("J111X", "1017", 456_000, 231);

ICar carInf = new CarImpl();
var listCar = carInf.InitListCar(new Car[] { angkot1, angkot2, suv1, suv2 });
var myCar = carInf.FindCarByNomor(listCar, "D111X");
var listAngkot = carInf.FindCarByType(listCar,EnumCar.ANGKOT);
var listSuv = carInf.FindCarByType(listCar, EnumCar.SUV);
var totalRevenueAngkot = carInf.TotalPendapatan(listCar, EnumCar.ANGKOT);
var totalRevenueSUV = carInf.TotalPendapatan(listCar, EnumCar.SUV);
var totalRevenueAll = carInf.TotalPendapatan(listCar, EnumCar.ALL_CAR);

/*Console.WriteLine(angkot1);
Console.WriteLine(angkot2);
Console.WriteLine(suv1);
Console.WriteLine(suv2);*/
Console.WriteLine(myCar);

Console.WriteLine(totalRevenueAngkot);
Console.WriteLine(totalRevenueSUV);
Console.WriteLine(totalRevenueAll);



Console.ReadLine();



//**************************




//Quiz 1.1 GuessNumber
void GuessNumber()
{
    void fufu(int result)
    {
        while (true)
        {
            Console.Write("Enter your guess ? ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == result)
            {
                Console.WriteLine($"Tebakan kamu benar, angka yang ditebak {answer}");
                break;
            }
            else if (answer < result)
            {
                Console.WriteLine("Your guess is too low");
            }
            else if (answer > result)
            {
                Console.WriteLine("Your guess is too high");
            }
        }
    }
    Console.WriteLine("Guess magic number between 0-20");
    Random random = new Random();
    int result = random.Next(0, 21);
    bool counter = true;
    fufu(result);
    while (counter == true)
    {
        again();
    }
    void again()
    {
        Console.WriteLine("Tebak lagi ?");
        string retry = Console.ReadLine();
        if (retry == "y")
        {
            result = random.Next(0, 21);
            fufu(result);
        }
        else if (retry == "n")
        {
            Console.WriteLine("Your quit");
            //break;
            counter = false;
        }
    }
}
//Quiz 1.2 Max Number
void MaxNumber()
{
    int number = -1;
    int counter = -1;
    while (number != 0)
    {
        Console.Write("Enter integer [ Type 0 for exit ] : ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > counter)
        {
            counter = number;
        }
    }
    Console.WriteLine($"angka terbesar : {counter}");
}
//Quiz 1.3 Input Length
/*Console.Write("Enter numbers : ");
string result = Console.ReadLine();
*/

//Quiz 1.4 Digit Extract
void DigitExtract(){
    Console.Write("Enter numbers : ");
    string result = Console.ReadLine();
    for (int i = result.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(result[i]);
    }
}
//Quiz 1.5 AngkaPembagi
void AngkaPembagi()
{
    Console.Write("Enter numbers : ");
    int result = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i < result; i++)
    {
        if (result % i == 0)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}
//Quiz 1.6 Prima
void Prima()
{
    Console.Write("Enter limit number : ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 2; i < number; i++)
    {
        bool counter = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                counter = false;
                continue;
            }
        }
        if (counter)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}
//Quiz 1.7 Palindrome
Console.Write("Enter strings : ");
string answer=Console.ReadLine().ToLower();
int i= 0;
int j=answer[answer.Length-1];
bool counter = false;   
while (i != j)
{
    
        if (answer[i] != answer[j])
        {
            counter = true;
            break;
        }
    
    i++;
    j--;

}
if (counter==false)
{
    Console.WriteLine("String is palindrome");
}
else
{
    Console.WriteLine("String is not a palindrome");
}




