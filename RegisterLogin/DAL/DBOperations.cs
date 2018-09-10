using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterLogin.DAL
{
    public class DBOperations
    {
       public List<Login> GetAllStudent()
        {
            using(ModelEntity loginEntity = new ModelEntity())
            {
               return (loginEntity.LoginTable).ToList();
            }
        }
        //public void Register(Login newUser)
        //{
        //    using (ModelEntity loginEntity = new ModelEntity())
        //    {
        //        loginEntity.LoginTable.Add(newUser);
        //        loginEntity.SaveChanges();
        //    }

        //}
        
    }
}
