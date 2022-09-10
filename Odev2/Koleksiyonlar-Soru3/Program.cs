using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Bir Cümle Giriniz: ");
        string cumle=Console.ReadLine();
        char[] sesliHarf={'a','e','ı','i','o','ö','u','ü'};
        ArrayList cumledekiSesliler=new();
        for(int i=0;i<cumle.Length;i++)
        {
            if(sesliHarf.Contains(cumle[i]))
            {
                cumledekiSesliler.Add(cumle[i]);
            }
        }
        cumledekiSesliler.Sort();
        Console.WriteLine("******** Cümledeki Sesli Harfler ********");
        foreach (char harf in cumledekiSesliler)
        {
            Console.Write(harf+" ");
        }
    }
}