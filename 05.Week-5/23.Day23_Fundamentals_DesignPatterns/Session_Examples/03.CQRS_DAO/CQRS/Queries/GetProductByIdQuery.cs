namespace CQRSDemoApplication.CQRS.Queries
{
    public class GetProductByIdQuery
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
        {           
            this.Id = id;
        }
    }
}
