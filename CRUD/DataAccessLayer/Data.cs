using CRUD.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataAccessLayer
{
    public class Data
    {
        private readonly CRUDContext _context;

        public Data (CRUDContext context)
        {
            _context = context;
        }

        /*
        CREATE PROCEDURE sp_create
        @Username varchar(50),
        @Pass varchar(20),
        @Phone numeric(10,0),
        @Email varchar(10)
        AS
        BEGIN
	        INSERT INTO Usuario (Username, Pass, Phone, Email) VALUES (@Username, @Pass, @Phone, @Email)
        END
        */
        public void Create(string username, string password, int phone, string email)
        {
            var parametros = new[]
            {
                new SqlParameter("@Username", SqlDbType.VarChar, 50) { Value = username},
                new SqlParameter("@Pass", SqlDbType.VarChar, 20) { Value = password},
                new SqlParameter("@Phone", SqlDbType.Int) { Value = phone},
                new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = email}
            };

            _context.Database.ExecuteSqlRaw("EXEC sp_create @Username, @Pass, @Phone, @Email", parametros);
        }

        /*
        CREATE PROCEDURE sp_delete
        @UserId int
        AS
        BEGIN
	        DELETE FROM Usuario WHERE UserId = @UserId
        END
        */

        public void Delete(int UserId)
        {
            var parametros = new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId };

            _context.Database.ExecuteSqlRaw("EXEC sp_delete @UserId", parametros);
        }

        /*
        CREATE PROCEDURE sp_update
        @UserId INT,
        @Username varchar(50),
        @Pass varchar(20),
        @Phone numeric(10,0),
        @Email varchar(100)
        AS
        BEGIN
	        UPDATE Usuario
	        SET 
	        Username = @Username,
	        Pass = @Pass,
	        Phone = @Phone,
	        Email = @Email
	        WHERE UserId = @UserId
        END
        */
        public void Update(int userId, string username, string password, int phone, string email)
        {
            var parametros = new[]
            {
                new SqlParameter("@UserId", SqlDbType.Int) { Value =  userId},
                new SqlParameter("@Username", SqlDbType.VarChar, 50) { Value = username},
                new SqlParameter("@Pass", SqlDbType.VarChar, 20) { Value = password},
                new SqlParameter("@Phone", SqlDbType.Int) { Value = phone},
                new SqlParameter("@Email", SqlDbType.VarChar, 100) { Value = email}
            };

            _context.Database.ExecuteSqlRaw("EXEC sp_update @UserId, @Username, @Pass, @Phone, @Email", parametros);
        }

        /*
        CREATE PROCEDURE sp_read
        @Username varchar(50)
        AS 
        BEGIN
	        SELECT * FROM Usuario WHERE Username = @Username
        END
         */
        public Usuario Read(string username)
        {
            var parametro = new SqlParameter("@Username", SqlDbType.VarChar, 50) { Value = username};

            FormattableString consulta = $"EXEC sp_read @Username = {parametro}";

            return _context.Usuarios.FromSqlInterpolated(consulta).AsNoTracking().AsEnumerable().FirstOrDefault();
        }

        /*
         CREATE PROCEDURE sp_select
        AS
        BEGIN
	        SELECT * FROM Usuario
        END
         */
        public List<Usuario> Select()
        {
            return _context.Usuarios.FromSqlRaw("EXEC sp_select").AsNoTracking().AsEnumerable().ToList();
        }
    }
}
