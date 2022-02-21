using System;
using Assignment_3_New.Models;

namespace Password.Check
{
    public class PasswordCheck
    {
        public bool Customer(int candidate)
        {
            if (candidate < 8)
            {
                return false;
            }
            throw new NotImplementedException("Not implemented.");
        }
    }
}
