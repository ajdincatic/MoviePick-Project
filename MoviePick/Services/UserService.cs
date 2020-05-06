using AutoMapper;
using eProdaja.Services;
using MoviePick.Data.Request;
using MoviePick.Database;
using MoviePick.Helper;
using MoviePick.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePick.Services
{
    public class UserService :
        BaseCRUDService<Data.Model.User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest, Database.User>, IUserService
    {
        public UserService(MoviePickContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }

        public Data.Model.User Authenticiraj(UserLoginRequest request)
        {
            User user = _context.User.FirstOrDefault(x => x.Username == request.Username);

            if (user == null)
                throw new Exception("Wrong username or password");

            var newHash = HashGenerator.GenerateHash(user.PasswordSalt, request.Password);

            if (newHash != user.PasswordHash)
                throw new Exception("Wrong username or password");


            Data.Model.User atuhUser = _mapper.Map<Data.Model.User>(user);
            return atuhUser;
        }

        public override List<Data.Model.User> Get(UserSearchRequest search)
        {
            var query = _context.User.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.FirstName.StartsWith(search.Username));
            }

            return _mapper.Map<List<Data.Model.User>>(query.ToList());
        }

        public override Data.Model.User Insert(UserUpsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password and password confirm not matched");
            }

            entity.PasswordSalt = HashGenerator.GenerateSalt();
            entity.PasswordHash = HashGenerator.GenerateHash(entity.PasswordSalt, request.Password);

            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.User>(entity);
        }
    }
}
