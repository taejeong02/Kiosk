namespace KioskProject
{
    public class MenuOptionData
    {
        public string Spiciness { get; set; } = "보통맛";
        public bool IsUpsize { get; set; } = false;
        public int Quantity { get; set; } = 1;

        public int CalculateTotalPrice(int basePrice)
        {
            int total = basePrice * Quantity;
            if (IsUpsize)
                total += 1000 * Quantity;
            return total;
        }
    }
}
