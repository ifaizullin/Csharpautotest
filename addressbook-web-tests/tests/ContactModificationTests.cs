using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            int index = 3;

            ContactData newData = new ContactData("mod_name");
            newData.Lastname = "mod_last_name";
            if (app.Contact.IsExist(index))
            {
                app.Contact.Modify(index, newData);
            }
            else
            {
                if (!app.Contact.IsExist(1))
                {
                    app.Contact.Create(new ContactData(""));
                }
                app.Contact.Modify(1, newData);
            }
            app.Contact.Modify(1, newData);

        }
    }
}
