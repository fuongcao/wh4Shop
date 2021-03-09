namespace wh4Shop.AppCore.ViewModel
{
    using System.ComponentModel;
    public class UserViewModel
    {
        [DisplayName("Tên đăng nhập")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
