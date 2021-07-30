using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_const_and_readonly_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*Access levels:a. private - Only accessible by the class containing the field/function.
                            b. public - Accessible to all and any project/assembly that has a reference to our assembly.
                            c. protected - Accessible only to the inherating classes.
                            d. internal - Only accessible by the current project/assembly.*/

            #endregion

            #region question 2

            /*Access modifiers help us utilize the encapsulation and abstraction part of OOP(Object oriented programming)
              by allowing us to decide what the user can see and what the programmer can see. We only give the user the abilites
              we want him to be able to use.*/

            #endregion

            #region question 3

            /*The Default Access Levels:a. class - internal.
                                        b. members - private.
                                        c. enum/interface - public.*/

            BankAccount myAcc = new BankAccount(200.00D, "TheBank", 934537643);
            //myAcc.balance = 2000000;
            myAcc.WithdrawOrDeposit(70.00D);
            Console.WriteLine($"{myAcc.GetAccountDetails()}");

            #endregion
        }
    }
}
