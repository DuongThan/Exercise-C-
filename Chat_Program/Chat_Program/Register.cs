using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Program
{
    class Register
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string repassWord;

        public string RepassWord
        {
            get { return repassWord; }
            set { repassWord = value; }
        }
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public void Register_Account()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.Write("User Name    :");
            Console.SetCursorPosition(10, 4);
            Console.Write("Password     :");
            Console.SetCursorPosition(10, 5);
            Console.Write("Repassword   :");
            Console.SetCursorPosition(10, 6);
            Console.Write("FullName     :");
            Console.SetCursorPosition(10, 7);
            Console.Write("Address      :");
            Console.SetCursorPosition(10, 3);
            Console.Write("PhoneNumber  :");
            //--------------------------

            Console.SetCursorPosition(18, 3);
            userName = Console.ReadLine();
            Console.SetCursorPosition(18, 4);
            passWord = Console.ReadLine();
            Console.SetCursorPosition(18, 5);
            repassWord = Console.ReadLine();
            Console.SetCursorPosition(18, 6);
            fullName = Console.ReadLine();
            Console.SetCursorPosition(18, 7);
            address = Console.ReadLine();
            Console.SetCursorPosition(18, 3);
            phoneNumber = Console.ReadLine();

        }
        public bool CheckAccount()
        {
            return true;
        }
    }
}
