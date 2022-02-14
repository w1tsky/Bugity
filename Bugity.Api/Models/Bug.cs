namespace Bugity.Api.Models
{
    public class Bug : BaseItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public BugStatus Status { get; set; }

        public int? AssignedUserId { get; set; }
        public virtual User AssignedUser { get; set; }
    }
}
