using System;
using StoreAppLibrary;
using StoreAppLibrary.Exceptions;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            string str = "abc";

            int[] numbers = null;


            try
            {
                Console.WriteLine(str[5]);

                Student car = (Student)human;

                Console.WriteLine(numbers.Length);
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("Istifade etdiyiniz deyer nulldir!");
                //Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Bele bir index yoxdur!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmedik bir xeta bas verdi");
            }

            Console.WriteLine("Davam edir..");


            Market market = new Market();
            market.ProductLimit = 20;

            Product product = new Product
            {
                Count = 30,
                No = "PR1",
                Name = "Milla Ayran 1L",
                Price = 10
            };



            try
            {
                market.AddProduct(product);

            }
            catch (ProductAlreadyExistsException ex)
            {
                Console.WriteLine("Eyni nomreli mehsul var!");
                Console.WriteLine(ex.Message);
            }
            catch(ProductLimitOverflowException ex)
            {
                Console.WriteLine("Mehsulu sayi limit asilir!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
