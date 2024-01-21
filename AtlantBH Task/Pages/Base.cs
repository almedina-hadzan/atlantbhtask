using AtlantBH_Task.TestCases;
using SeleniumExtras.PageObjects;

namespace AtlantBH_Task.Pages
{
    public class Base : BaseTest
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(GetDriver(), page);
            return page;
        }

        public static Home HomePage
        {
            get { return GetPage<Home>(); }
        }

        public static SignUp SignUpPage
        {
            get { return GetPage<SignUp>(); }
        }

        public static ContactList ContactListPage
        {
            get { return GetPage<ContactList>(); }
        }

        public static LogIn LogInPage
        {
            get { return GetPage<LogIn>(); }
        }

        public static AddNewContact AddNewContactPage 
        {
            get { return GetPage<AddNewContact>(); }
        }
    }
}

