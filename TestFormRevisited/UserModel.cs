using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestFormRevisited
{
    

    public class UserModel
    {
        private List<UserEntity> _userEntityList;
        public UserModel()
        {
            _userEntityList = new List<UserEntity>();
        }


        public List<UserEntity> Get()
        {
            return _userEntityList;
        }


        public UserEntity Get(Guid id)
        {
            UserEntity user;

            user = _userEntityList[UserById(id)];
            return user;
        }


        public void Set(UserEntity user)
        {
            _userEntityList.Add(user);
        }


        public void Edit(Guid id, UserEntity updatedUser)
        {
            _userEntityList[UserById(id)] = updatedUser;
        }


        public void Delete(UserEntity user)
        {
            _userEntityList.Remove(user);
        }

        private int UserById(Guid id)
        {
            var index = _userEntityList.FindIndex(x => x.Id == id);
            if (index != -1)
                return index;
            else
                return 0;
        }
    }
}
