namespace IkiSayininToplaminiVerenUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iki sayinin toplamini veren uygulama

            #region
            //cözüm 1:
            int sayi1 = 10;
            int sayi2 = 20;

            // int sayi1 = 10, sayi2 = 20;

            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            #endregion

            #region
            // cözüm 2:
            Console.WriteLine("Lütfen sayi3 değerini giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen sayi4 değerini giriniz");
            int sayi4 = int.Parse(Console.ReadLine());
            // parse metodu sadece string ifadeleri belirtilen tipe çevirir.
            // örnegin int.Parse int e çevirir. bool.Parse bool çevirir.

            Console.WriteLine(sayi3 + sayi4);
            #endregion

            try
            {
                Console.WriteLine("Lütfen sayi5 değerini giriniz");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen sayi6 değerini giriniz");
                int sayi6 = int.Parse(Console.ReadLine());
                Console.WriteLine(sayi3 + sayi4);
            }
            catch (Exception)
            {
                Console.WriteLine(sayi3 + sayi4);
            }
        }
    }
}
