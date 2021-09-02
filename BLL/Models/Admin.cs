using System.Collections.Generic;

namespace BLL.Models
{
    internal sealed class Admin : AuthorizedUser
    {
        //private static Admin Instance;
        private static List<Manager> Managers;

        private Admin(string email, string password) : base(email, password)
        {
            Managers = new List<Manager>();
        }
        private Admin(string email, string password, List<Manager> managers) : base(email, password)
        {
            Managers = new List<Manager>(managers);
        }

        //internal static Admin GetInstance(string email, string password)
        //{
        //    if (Instance == null)
        //        Instance = new Admin(email, password);

        //    return Instance;
        //}
        //internal static Admin GetInstance(string email, string password, List<Manager> managers)
        //{
        //    if (Instance == null)
        //        Instance = new Admin(email, password);

        //    return Instance;
        //}

        //public List<Manager> GetManagers()
        //{
        //    return Managers;
        //}
        //public void AddManager(Manager manager)
        //{
        //    if (manager != null)
        //    {
        //        Managers.Add(manager);
        //    }
        //}
        //public void AddManager(List<Manager> managers)
        //{
        //    if (managers != null)
        //    {
        //        foreach (Manager manager in managers)
        //        {
        //            Managers.Add(manager);
        //        }
        //    }
        //}
    }
}
