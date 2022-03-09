using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ContactsApp.Model
{
   public class Phone 
    {
        private long _number;
        public long Number
        {
            get => _number;
            set
            {
                if(value.ToString().Length !=11 || value.ToString()[0] != '7')
                {
                    throw new ArgumentException(message: "Номер телефона начинается с 7 и 11 состоять из чифр ");
                }
                _number = value;

            }
        }
    }
}
