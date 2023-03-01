using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Internals
    {
        private int finalSum;
        private int numberDocument;
        private int codeDepartment;
        private string namePersonal;
        private string typeProduct;
        private int quantityProduct;
        private DateTime openedDated;
        private string closedDated;
       

        public int FinalSum
        {
            get { return finalSum; }
            set { finalSum = value; }
        }
        public int NumberDocument
        {
            get { return numberDocument; }
            set { numberDocument = value; }
        }
        public int CodeDepartment
        {
            get { return codeDepartment; }
            set { codeDepartment = value; }
        }
        public DateTime OpenedDated
        {
            get { return openedDated; }
            set { openedDated = value; }
        }

       
        
        public string ClosedDated
        {
            get { return closedDated; }
            set { closedDated = value; }
        }
        public string NamePersonal
        {
            get { return namePersonal; }
            set { namePersonal = value; }
        }

       
        public string TypeProduct
        {
            get { return typeProduct; }
            set { typeProduct = value; }
        }
        public int QuantityProduct
        {
            get { return quantityProduct; }
            set { quantityProduct = value; }
        }
    }
}
