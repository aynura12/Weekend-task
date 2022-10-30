
#region Month name

using System;
string monthName = "Avqust";

switch (monthName)
{

    case "Dekabr":
    case "Yanvar":
    case "Fevral":
        Console.WriteLine("Qis");
        break;
    case "Mart":
    case "Aprel":
    case "May":
        Console.WriteLine("Yaz");
        break;
    case "Iyun":
    case "Iyul":
    case "Avqust":
        Console.WriteLine("Yay");
        break;
    case "Sentyabr":
    case "Oktyabr":
    case "Noyabr":
        Console.WriteLine("Payiz");
        break;
    default:
        Console.WriteLine();
        break;
}
#endregion

#region Simplenumber
int number = 0;
int count = 0;

if (number == 0 || number == 1)
{
    Console.WriteLine("Hecbir hal odenmir");

}
else
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine("eded murekkebdir");
            count++;
            break;
        }
    }


    if (count == 0)
    { Console.WriteLine("eded sadedir"); }
}

#endregion

#region Power of 2

int nmber = 17;
count = 0;
if (nmber == 0)
{ Console.WriteLine("2nin quvveti 0 ola bilmez"); }
else
{

    while (nmber > 1)
    {

        if (nmber % 2 != 0)
        {

            Console.WriteLine("Eded  2nin qwvveti deyil");

            count++;

            break;
        }
        nmber = nmber / 2;


    }
    if (count == 0)
    {
        Console.WriteLine("eded 2 nin quvvetidir");

    }


}
#endregion


#region Palindrom Number
int numberPal = 343;
int rev = 0;
int a = 0;
int n=numberPal;
while (numberPal > 0)
    

{
   
    a = numberPal % 10;
    rev = (rev * 10) + a;
    numberPal = numberPal / 10;
    

}

if (n == rev)
{
    Console.WriteLine("Eded palindromdur");
    
}

else
{
    Console.WriteLine("Eded palindrom deyil");
   
}


















#endregion
