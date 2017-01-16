using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            int index = 3;

            if (app.Contact.IsExist(index))
            {
                app.Contact.Remove(index);
            }
            else
            {
                if (!app.Contact.IsExist(1))
                {
                    app.Contact.Create(new ContactData(""));
                }
                app.Contact.Remove(1);
            }

        }
    }
}
