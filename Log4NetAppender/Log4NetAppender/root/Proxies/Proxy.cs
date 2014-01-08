using root.Contracts;
using System.ServiceModel;

namespace root.Proxies
{
    internal class Proxy : ClientBase<IApprendaService>, IApprendaService
    {
        public DataTransferObject SomeMethod(DataTransferObject data)
        {
            return base.Channel.SomeMethod(data);
        }


        public string Echo(string input)
        {
            return base.Channel.Echo(input);
        }
    }
}
