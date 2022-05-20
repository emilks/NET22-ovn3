using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    } 

    public class NumericInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    public class NonPositiveInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a nonpositive number in a numeric field requiering a positive number. This fired an error!";
        }
    }

    public class EmptyInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a empty string in a field requiering a non-empty string!";
        }
    }

    public class TooLargeIntInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a number that is too big. That produced an error!";
        }
    }
}
