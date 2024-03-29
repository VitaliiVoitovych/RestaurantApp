﻿namespace RestaurantApp.BL.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TableNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Payment> Payments { get; set; }
        public override string ToString()
        {
            return $"Номер столику №{TableNumber} \n" +
                   $"{Customer} \n" +
                   $""+ OrderDate.ToString("HH:mm dd.MM.yyyy");
        }
    }
}
