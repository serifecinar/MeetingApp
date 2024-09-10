namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users=new();

        static Repository()
        {
            _users.Add(new UserInfo() {Name="Ali", Email="abc@gmail.com",Phone="11111",WillAttend=true});
            _users.Add(new UserInfo() {Name="AHmet", Email="abcd@gmail.com",Phone="222222",WillAttend=false});
            _users.Add(new UserInfo() {Name="Canan", Email="abce@gmail.com",Phone="333",WillAttend=true});
        }
        public static List<UserInfo> Users
        {
            get{ 
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}