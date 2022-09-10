internal class Program
{
    private static void Main(string[] args)
    {
        int[]sayilar=new int[20];
        for(int i=0;i<20;i++)
        {
            tekrardene:
                Console.Write("{0}. Sayıyı Girin: ",i+1);
            if(int.TryParse(Console.ReadLine(),out int sayi) && sayi!=null)
            {
                sayilar[i]=sayi;
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
                goto tekrardene;
            }
        }
            Array.Sort(sayilar);
            int[]ilkGrup=new int[3];
            for(int j=0;j<3;j++)
            {
                ilkGrup[j]=sayilar[j];
            }
            int[]ikinciGrup=new int[3];
            for(int k=19;k>16;k--)
            {
                ikinciGrup[19-k]=sayilar[k];
            }

            int ilkGrup_Toplam=0,ikinciGrup_Toplam=0,ilkGrup_Ort,ikinciGrup_Ort;

            foreach (int altEleman1 in ilkGrup)
            {
                ilkGrup_Toplam+=altEleman1;
            }
            ilkGrup_Ort=ilkGrup_Toplam/3;
                Console.WriteLine("En küçük 3 sayının ortalaması= "+ilkGrup_Ort);
            foreach (int altEleman2 in ikinciGrup)
            {
                ikinciGrup_Toplam+=altEleman2;
            }
                ikinciGrup_Ort=ikinciGrup_Toplam/3;
                Console.WriteLine("En büyük 3 sayının ortalaması= "+ikinciGrup_Ort);
                Console.WriteLine("Ortalamaların Toplamı= "+(ilkGrup_Ort+ikinciGrup_Ort));
    }
}