Console.WriteLine("***********Hesap Makinesi Uygulamasına Hoşgeldiniz**********");
Console.WriteLine("İşlem yapmak istediğiniz 1.sayıyı giriniz");
double sayi1 = Convert.ToDouble((Console.ReadLine()));
Console.WriteLine("İşlem yapmak istediğiniz 2.sayıyı giriniz");
double sayi2 = Convert.ToDouble((Console.ReadLine()));
dön2: Console.WriteLine("{Toplama}='+' {Çıkarma}='-' {Çarpma}='*' {Bölme}='/'");
char islem = Convert.ToChar((Console.ReadLine()));



dön:
switch (islem)
{
	case '+':
        Console.WriteLine("Toplama İşlemi Sonucunuz ="+" "+(sayi1+sayi2));
        break;
    case '-':
        Console.WriteLine("Çıkarma İşlemi Sonucunuz =" + " " + (sayi1 - sayi2));
        break;
    case '*':
        Console.WriteLine("Çarpma İşlemi Sonucunuz =" + " " + (sayi1  * sayi2));
        break;
    case '/':

        if (sayi2!=0)
        {
            
            Console.WriteLine("Bölme İşlemi Sonucunuz =" + " " + (sayi1 / sayi2));
            break;
        }
        else
        {
            Console.WriteLine("Lütfen 0'dan farklı bir sayı giriniz");
            Console.WriteLine("İşlem yapmak istediğiniz 2.sayıyı giriniz");
            sayi2 = Convert.ToDouble((Console.ReadLine()));
            goto dön;
            
        }
    default:
        Console.WriteLine("Hatalı İşlem Girişi Yaptınız ");
        goto dön2;
        break;

}
