namespace system.Security.Entity.Collection
{
    public class BaseDocument
    {
        public int IsBlock { get; set; }
        public int IsRemove { get; set; }

        public Guid IdUserInsert { get; set; }
        public DateTime DtInsert { get; set; }

        public Guid IdUserUpdate { get; set; }
        public DateTime DtUpdate { get; set; }

        public Guid IdUserDelete { get; set; }
        public DateTime DtDelete{ get; set; }

        public Guid IdUserBlock { get; set; }
        public DateTime DtBlock { get; set; }


    }
}
