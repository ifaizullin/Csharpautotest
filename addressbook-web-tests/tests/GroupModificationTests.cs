using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
     [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
         [Test]
         public void GroupModificationTest()
         {
             int index = 2;

             GroupData newData = new GroupData("My group MODIFY 222111");
             newData.Header = null;
             newData.Footer = null;

             if (app.Groups.IsExist(index))
             {
                 app.Groups.Modify(index, newData);
             }
             else
             {
                 if (!app.Groups.IsExist(1))
                 {
                     app.Groups.Create(new GroupData(""));
                 }
                 app.Groups.Modify(1, newData);
             }
         }
    }
}
