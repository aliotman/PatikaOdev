internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        System.Console.Write("Dizinin eleman sayısını girin: ");
        tekrargiris:
        n=int.Parse(Console.ReadLine());
        while(n<=0)
        {
            System.Console.WriteLine("Lütfen Pozitif Bir sayı girin!");
            goto tekrargiris;
        }
        int [] dizi=new int[n];
        for(int i=0;i<n;i++)
        {
          
            System.Console.Write("{0}. sayıyı girin: ",i+1);
             dizi[i]= int.Parse(Console.ReadLine());
        }
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }
    }
}