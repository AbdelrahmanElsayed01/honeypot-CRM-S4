namespace HoneypotCRMS4.Models
{
    public class UserViewModel
    {
        public IEnumerable<UserModel> Users { get; set; }
        public UserModel NewUser { get; set; }
    }
}
