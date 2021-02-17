using System;

namespace BankingAppU
{
    public static class Identificator<T>
    {
        private static int _counter;

        public static int GenerateId()
        {
            _counter++;
            return _counter;
        }
    }
}