internal class Program
{
    private static void Main(string[] args)
    {
        anamenu: //////////////////// ANA MENU ///////////////////
        Console.WriteLine("1- Soru1");
        Console.WriteLine("2- Soru2");
        Console.WriteLine("3- Soru3");
        Console.WriteLine("4- Soru4");
        Console.Write("Seçmek istediğiniz sorunun numarasını girin:");
        int sorunumarasi;
        sorunumarasi=int.Parse(Console.ReadLine());
        switch (sorunumarasi)
        {
            case 1: ////////// SORU 1 KODLAR //////////////////
        int n;
        Console.Write("Dizinin eleman sayısını girin: ");
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
          
            Console.Write("{0}. sayıyı girin: ",i+1);
            dizi[i]= int.Parse(Console.ReadLine());
        }
        foreach (int sayi in dizi)
        {
            if(sayi%2==0)
            {
            Console.WriteLine(sayi);
            }
            
        }
            goto anamenu; ///////////////// CASE 1 SONU ///////////////////////

            case 2: //////////////////// SORU 2 KODLAR /////////////////////////
            sayi1hata:
            Console.Write("Pozitif Bir Sayı Girin:");
            int sayi1=int.Parse(Console.ReadLine());
            while (sayi1<=0)
            {
                Console.WriteLine("Pozitif Sayı Girmeniz gerekiyor!");
                goto sayi1hata;
            }
            sayi2hata:
            Console.Write("Pozitif Bir Sayi Daha Girin:");
            int sayi2=int.Parse(Console.ReadLine());
            while (sayi2<=0)
            {
                Console.WriteLine("Pozitif Sayı Girmeniz gerekiyor!");
                goto sayi2hata;
            }
            int [] sayilar= new int[sayi1];
            for (int i = 0; i < sayi1; i++)
            {
                sayilardizihata:
                Console.Write("{0}. pozitif sayıyı girin:",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
                while(sayilar[i]<=0)
                {
                    Console.WriteLine("Pozitif Sayı Girmeniz gerekiyor!");
                    goto sayilardizihata;
                }
                
            }
            foreach (int dizisayi in sayilar)
                {
                    if(dizisayi%sayi2==0 || dizisayi==sayi2)
                    {
                        Console.WriteLine(dizisayi);
                    }
                }
            goto anamenu; //////////////////// CASE 2 SONU //////////////////

            case 3: ////////////// SORU 3 KODLAR ////////////////////////////
                    elemansayihata:
                    Console.Write("Dizinin eleman sayısını girin: ");
                    int elemansayi=int.Parse(Console.ReadLine());
                    while(elemansayi<=0)
                    {
                        Console.WriteLine("Pozitif Sayı Girmeniz gerekiyor!");
                        goto elemansayihata;
                        
                    }
                    string [] kelimeler=new string[elemansayi];
                    for (int i = 0; i < elemansayi; i++)
                    {
                        Console.Write("{0}. kelimeyi girin:",i+1);
                        kelimeler[i]=Console.ReadLine();
                    }
                    Array.Reverse(kelimeler);
                    foreach (string kelime in kelimeler)
                    {
                        Console.WriteLine(kelime);
                    }
                    goto anamenu; /////// SORU 3 SONU ///////////////////

                    case 4: ////////// SORU 4 KODLAR ///////////////
                    Console.Write("Bir cümle giriniz: ");
                    string cumle=Console.ReadLine();
                    int harfSayac=0,kelimeSayac=1;
                    for (int i = 0; i < cumle.Length; i++)
                    {
                        harfSayac++;
                        if(cumle[i]==' ')
                        {
                            kelimeSayac++;
                            harfSayac--;
                        }
                    }
                    Console.WriteLine("Toplam harf sayısı= "+harfSayac);
                    Console.WriteLine("Toplam kelime sayısı= "+kelimeSayac);
                    goto anamenu; /////// SORU 4 SONU ////////////////
        }
        
        
    }
}