let nmber = -4;
count = 0;
if (nmber== 0 || nmber<0)
{ console.log("Daxil edilen eded 0 ve 0dan kicik ola bilmez"); }
else
{

    while (nmber > 1 )
    {
        
        if (nmber % 2 != 0)
        {
            
            console.log("Eded  2nin qwvveti deyil");
           
            count++;
            break;
        }
        nmber = nmber / 2;
         
        
    }
    if (count == 0)
    {
        console.log("eded 2 nin quvvetidir");
       
    }


}