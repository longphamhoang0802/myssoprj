using myssocms.Models;
using ServiceStack.OrmLite;
using System.Collections.Generic;
using System.Linq;

namespace myssocms.Services
{
    public class Film_usersService : SettingService
    {
        public Film_usersService() { }

        public Film_users GetById(int id)
        {
            using (var db = _connectionData.OpenDbConnection())
            {
                var query = db.From<Film_users>().Where(x => x.Id == id);
                return db.Select(query).FirstOrDefault();
            }
        }
        
    }
}
