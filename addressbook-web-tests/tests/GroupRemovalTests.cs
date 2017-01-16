using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {       

        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            int index = 1;

            if (app.Groups.IsExist(index))
            {
                app.Groups.Remove(index);
            }
            else
            {
                if (!app.Groups.IsExist(1))
                {
                    app.Groups.Create(new GroupData(""));
                }
                app.Groups.Remove(1);
            }
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }                                               
    }
}
