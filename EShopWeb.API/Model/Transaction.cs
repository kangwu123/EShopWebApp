using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Transaction : BaseEntity
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public required string Result { set; get; }
        public required string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public required string Provider { set; get; }
        public Guid UserId { get; set; }
    }
}
