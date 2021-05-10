using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoApi.Controllers;
using PhotoApi.DataAccess;
using PhotoApi.Model;
using PhotoApi.ViewModel.FriendVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;

namespace PhotoApi.Test
{
    [TestClass]
    public class FriendApiTest
    {
        private FriendController _controller;
        private string _seed;

        public FriendApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<FriendController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new FriendSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            FriendVM vm = _controller.CreateVM<FriendVM>();
            Friend v = new Friend();

            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Friend>().FirstOrDefault();

                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Friend v = new Friend();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                context.Set<Friend>().Add(v);
                context.SaveChanges();
            }

            FriendVM vm = _controller.CreateVM<FriendVM>();
            var oldID = v.ID;
            v = new Friend();
            v.ID = oldID;

            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Friend>().FirstOrDefault();

                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Friend v = new Friend();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                context.Set<Friend>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Friend v1 = new Friend();
            Friend v2 = new Friend();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                context.Set<Friend>().Add(v1);
                context.Set<Friend>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<Friend>().Count(), 0);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
