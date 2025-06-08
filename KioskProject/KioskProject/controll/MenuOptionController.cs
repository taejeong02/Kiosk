using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProject
{
    public class MenuOptionController
    {
        public MenuOptionData OptionData { get; private set; } = new MenuOptionData();
        private int basePrice;

        public MenuOptionController(int price)
        {
            basePrice = price;
        }

        public void SetSpiciness(string level)
        {
            OptionData.Spiciness = level;
        }

        public void SetUpsize(bool isUpsize)
        {
            OptionData.IsUpsize = isUpsize;
        }

        public void IncreaseQty()
        {
            OptionData.Quantity++;
        }

        public void DecreaseQty()
        {
            if (OptionData.Quantity > 1)
                OptionData.Quantity--;
        }

        public int GetTotalPrice()
        {
            return OptionData.CalculateTotalPrice(basePrice);
        }

        public int GetQuantity()
        {
            return OptionData.Quantity;
        }
    }
}
