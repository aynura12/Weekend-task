let number = 12;
let count = 0;

if (number == 0 || number == 1)
{
    console.log("Hecbir hal odenmir");

}
else
{
    for (let i = 2; i < number ;i++)
    {
        if (number % i == 0)
        {
            console.log("eded murekkebdir");
            count++;
            break;
        }
    }


    if (count == 0)
    { console.log("eded sadedir"); }
}
