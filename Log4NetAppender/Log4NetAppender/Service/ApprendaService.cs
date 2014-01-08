using System;

namespace AppenderService
{
    public class ApprendaService : IApprendaService
    {
        public DataTransferObject SomeMethod(DataTransferObject data)
        {
            return data;
        }
        
        public string Echo(string input)
        {
            return String.Format("You typed {0}", input);
        }
    }
}
