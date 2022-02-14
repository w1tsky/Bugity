using System;

namespace Bugity.Entities
{
    public class BaseItem
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}