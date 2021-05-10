using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoApi.Controllers;
using PhotoApi.DataAccess;
using PhotoApi.Model;
using PhotoApi.ViewModel.UserVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;

namespace PhotoApi.Test
{
    [TestClass]
    public class UserApiTest
    {
        private UserController _controller;
        private string _seed;

        public UserApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<UserController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new UserSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            UserVM vm = _controller.CreateVM<UserVM>();
            User v = new User();

            v.UserName = "gsw9v2V";
            v.Password = "Vk0qi";
            v.NickName = "V0Q53o";
            v.Email = "RBdy";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<User>().FirstOrDefault();

                Assert.AreEqual(data.UserName, "gsw9v2V");
                Assert.AreEqual(data.Password, "Vk0qi");
                Assert.AreEqual(data.NickName, "V0Q53o");
                Assert.AreEqual(data.Email, "RBdy");
                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            User v = new User();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.UserName = "gsw9v2V";
                v.Password = "Vk0qi";
                v.NickName = "V0Q53o";
                v.Email = "RBdy";
                context.Set<User>().Add(v);
                context.SaveChanges();
            }

            UserVM vm = _controller.CreateVM<UserVM>();
            var oldID = v.ID;
            v = new User();
            v.ID = oldID;

            v.UserName = "qyEg";
            v.Password = "ZJa8tvGD";
            v.NickName = "LpPX";
            v.Email = "qw0z";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.UserName", "");
            vm.FC.Add("Entity.Password", "");
            vm.FC.Add("Entity.NickName", "");
            vm.FC.Add("Entity.Email", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<User>().FirstOrDefault();

                Assert.AreEqual(data.UserName, "qyEg");
                Assert.AreEqual(data.Password, "ZJa8tvGD");
                Assert.AreEqual(data.NickName, "LpPX");
                Assert.AreEqual(data.Email, "qw0z");
                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            User v = new User();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.UserName = "gsw9v2V";
                v.Password = "Vk0qi";
                v.NickName = "V0Q53o";
                v.Email = "RBdy";
                context.Set<User>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            User v1 = new User();
            User v2 = new User();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.UserName = "gsw9v2V";
                v1.Password = "Vk0qi";
                v1.NickName = "V0Q53o";
                v1.Email = "RBdy";
                v2.UserName = "qyEg";
                v2.Password = "ZJa8tvGD";
                v2.NickName = "LpPX";
                v2.Email = "qw0z";
                context.Set<User>().Add(v1);
                context.Set<User>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<User>().Count(), 0);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
