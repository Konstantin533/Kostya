using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Register : Internals, IRegisterO
    {

        

       public void CreateContractEmployee()
        {
            Console.Write("-----Контракт с сотрудником-------");
            Console.Write("Введите номер документа: ");
            NumberDocument = int.Parse(Console.ReadLine());
            Console.Write("Введите окончание контракта: ");
            ClosedDated = Console.ReadLine();
            Console.Write("Введите имя сотрудника ");
            NamePersonal = Console.ReadLine();
          
        }

        public void CreateSupplyContract()
        {
            Console.Write("-----Контракт на поставку товаров-------");
            Console.Write("Введите номер документа: ");
            NumberDocument = int.Parse(Console.ReadLine());
            Console.Write("Введите тип товаров: ");
            TypeProduct = Console.ReadLine();
            Console.Write("Введите количество товаров ");
            QuantityProduct =int.Parse( Console.ReadLine());
            
        }

        public void CreateFinance()
        {
            Console.Write("-----Финансовая накладная-------");
            Console.Write("Итоговая сумма за месяц: ");
            FinalSum = int.Parse(Console.ReadLine());
            Console.Write("Введите номер докумегта: ");
            NumberDocument = int.Parse(Console.ReadLine());
            Console.Write("Введите код департамента ");
            CodeDepartment = int.Parse(Console.ReadLine());
            
        }

        public void SaveDocument()
        {
            throw new NotImplementedException();
        }

        public void InfoDocument()
        {
            Console.Write("-----Информация о документе-------");
            Console.Write($"Номер документа {NumberDocument}");
            
            Console.Write($"Тип товара {TypeProduct} ");
           
            Console.Write($"Количество товаров {QuantityProduct} ");
          
            Console.WriteLine($"\nДата документа - {OpenedDated.ToString("dd-MM-yyyy HH:mm")}");
        }
    }
}
