using ProjectLinq.EntityClasses;
using ProjectLinq.ViewModelClasses;

namespace ProjectLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initiate the View Model
            SamplesViewModel vm = new SamplesViewModel
            {
                //USe query or method Syntax
                UseQuerySyntax = true
            };

            //Call a sample method
            vm.GetAllLooping();
            foreach (var item in vm.Products)
            {
                Console.WriteLine(item.ToString());
            }

            //Display Product Collection

            //Console.WriteLine(Product.color.ToString());

            //Display result Text
            Console.WriteLine(vm.ResultText);
        }
    }
}