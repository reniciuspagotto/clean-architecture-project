using ArquiteturaPadrao.Domain.Command.User;
using ArquiteturaPadrao.Domain.Entities;
using ArquiteturaPadrao.Domain.Repositories;
using ArquiteturaPadrao.Infra.Context;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace ArquiteturaPadrao.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected DataContext _context;
        private readonly IConfiguration _config;

        public UserRepository(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public GetUserAuthenticateCommand UserLogin(string username, string password)
        {
            var query = "select * from [User] where active=1 and username=@username and password=@password";
            using (SqlConnection conn = new SqlConnection(_config.GetConnectionString("cnstr")))
            {
                conn.Open();
                var result = conn.Query<GetUserAuthenticateCommand>(query, new { username, password }).FirstOrDefault();
                conn.Close();
                return result;
            }
        }
    }
}
