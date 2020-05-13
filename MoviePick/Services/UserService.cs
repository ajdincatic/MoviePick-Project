using AutoMapper;
using eProdaja.Services;
using Microsoft.EntityFrameworkCore;
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
    public class UserService : IUserService
    {
        public MoviePickContext _context { get; }
        public IMapper _mapper { get; }

        public UserService(MoviePickContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }

        public Data.Model.User Authenticiraj(UserLoginRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Data.Model.User> Get(UserSearchRequest search)
        {
            var query = _context.User.Include(x => x.UserType).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.FirstName.StartsWith(search.Username));
            }

            return _mapper.Map<List<Data.Model.User>>(query.ToList());
        }

        public Data.Model.User Insert(UserUpsertRequest request)
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

        public Data.Model.User GetById(int Id)
        {
            var entity = _context.User.Find(Id);

            return _mapper.Map<Data.Model.User>(entity);
        }

        public Data.Model.User Update(int Id, UserUpsertRequest request)
        {
            var entity = _context.User.Find(Id);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password and password confirm not matched");
            }

            entity.PasswordSalt = HashGenerator.GenerateSalt();
            entity.PasswordHash = HashGenerator.GenerateHash(entity.PasswordSalt, request.Password);

            _context.User.Attach(entity);
            _context.User.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Data.Model.User>(entity);
        }

        public Data.Model.User Delete(int Id)
        {
            var entity = _context.User.Find(Id);
            if (entity == null)
                throw new ArgumentNullException();
            var x = entity;
            _context.User.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Data.Model.User>(x);
        }
    }
}
