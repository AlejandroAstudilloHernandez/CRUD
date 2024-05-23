using CRUD.DataAccessLayer;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BussinessLayer
{
    public class Bussiness
    {
        private readonly Data _data;

        public Bussiness(Data data)
        {
            _data = data;
        }

        public void Create(string username, string password, int phone, string email)
        {
            _data.Create(username, password, phone, email);
        }

        public Usuario Read(string username)
        {
            return _data.Read(username);
        }

        public void Update(int UserId, string username, string password, int phone, string email)
        {
            _data.Update(UserId, username, password, phone, email);
        }

        public void Delete(int UserId)
        {
            _data.Delete(UserId);
        }

        public List<Usuario> Select()
        {
            return _data.Select();
        }
    }
}
