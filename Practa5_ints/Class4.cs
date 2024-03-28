using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practa5_ints
{
    public class MyClass
    {
        private string myPrivateField; // Приватное поле для хранения значения

        public string MyPublicProperty
        {
            get { return myPrivateField; } // Метод чтения значения свойства
            set { myPrivateField = value; } // Метод записи значения свойства
        }
    }

}
