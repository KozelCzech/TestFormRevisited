namespace TestFormRevisitedTests
{
    public class UserModelTests
    {
        [Fact]
        public void Get_ReturnsEmptyListInitially()
        {
            var userModel = new UserModel();

            var result = userModel.Get();

            Assert.Empty(result);
        }


        [Theory]
        [InlineData("Bob","Andrew", 52)]
        [InlineData(null, "asda", 17)]
        [InlineData("v", "fg", null)]
        public void Set_AddsUserToTheList(string firstName, string lastName, int age)
        {
            var userModel = new UserModel();
            var userEntity = new UserEntity { FirstName = firstName, LastName = lastName, Age = age};

            userModel.Set(userEntity);

            Assert.Single(userModel.Get());
        }


        [Fact]
        public void Get_ReturnsUserById()
        {
            var userModel = new UserModel();
            var userEntity = new UserEntity { Id = Guid.NewGuid(), FirstName = "a", LastName = "b", Age = 5 };

            userModel.Set(userEntity);
            var result = userModel.Get(userEntity.Id);

            Assert.NotNull(result);
            Assert.Equal(userEntity, result);
        }


        [Theory]
        [InlineData("Bob", "Andrew", 52, "asd", "fds", 7)]
        [InlineData(null, "Alan", 525787, "wrsa", "fdd", null)]
        [InlineData("gfet", "asd", 21, null, "fasd", 78)]
        public void Update_ReplacesExistingUserBasedOnId(string firstName, string lastName, int age, string updatedFirstName, string updatedLastName, int updatedAge)
        {
            var userModel = new UserModel();
            var userEntity = new UserEntity { Id = Guid.NewGuid(), FirstName = "a", LastName = "b", Age = 5 };
            var updatedUser = new UserEntity { FirstName = "c", LastName = "d", Age = 6 };

            userModel.Set(userEntity);
            userModel.Edit(userEntity.Id, updatedUser);

            Assert.Equal(updatedUser, userModel.Get(userEntity.Id));
        }


        [Fact]
        public void Remove_DeleteUserFromList()
        {
            var userModel = new UserModel();
            var userEntity = new UserEntity { Id = Guid.NewGuid(), FirstName = "a", LastName = "b", Age = 5 };

            userModel.Set(userEntity);
            userModel.Delete(userEntity);
            var users = userModel.Get();

            Assert.DoesNotContain(userEntity, users);
        }
    }
}