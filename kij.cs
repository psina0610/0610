Console.WriteLine("нельзя вводить буквы! )");

int q = 0;

int w = Convert.ToInt32(Console.ReadLine()) ;
while (w != 0)
    
{
    q += w;
    w = Convert.ToInt32(Console.ReadLine())   ;
}
Console.WriteLine(q);






