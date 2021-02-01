using System;
using System.Collections.Generic;
using System.Text;

namespace InkapslingArvOchPolymorfism
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a text input in a numericonly field. This fired an error!";

        }
    }

    class BadRequestError : UserError
    {
        public override string UEMessage()
        {
            return $"The request you sent to the website server, " +
                $"it was somehow incorrect or corrupted.";
        }
    }



    class TestClass2 : UserError
    {
        public override string UEMessage()
        {
            return $"Testing Testing ... for TestClass2";
        }
    }
    class TestClass3 : UserError
    {
        public override string UEMessage()
        {
            return $"Testing Testing ... for TestClass3";
        }
    }
}
