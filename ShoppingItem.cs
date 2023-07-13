using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZakupów
{
    class ShoppingItem
    {
        private string description; 
        private double amount;
		private double price;
		private UnitTypes unit;     

        public string Description {
            get
            {
                return description;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public double Amount {
            get
            {
                return amount;
            }
            set
            {
                if(value >= 0)
                    amount = value;
            }
        }
		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				if (value >= 0)
                    price = value;
			}
		}

		public UnitTypes Unit {
            get
            {
                return unit;
            }
            set
            {
                if(Enum.IsDefined(typeof (UnitTypes),value))
                    unit = value;
            }
        }

        public ShoppingItem() : this("Unknown", 1.0,1.0, UnitTypes.szt)
        {

        }

        public ShoppingItem(string description): this(description, 1.0, 1.0, UnitTypes.szt)
        {
        }

        public ShoppingItem(string description, double amount, double price) : this(description, amount, price, UnitTypes.szt)
        {

        }

        public ShoppingItem(string description, double amount, double price, UnitTypes unit)
        {
            this.description = description;
            this.amount = amount;
			this.price = price;
			this.unit = unit;
        }

        public override string ToString()
        {
            string textOut = string.Empty;
            textOut = $"{description, -45} {"Ilośc"} {amount, 6:f2}  {unit, -6} {"Cena"} { price,3:f2} {"Zł"}";
            return textOut;
        }

    }
}
