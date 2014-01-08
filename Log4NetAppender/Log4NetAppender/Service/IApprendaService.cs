using System.ServiceModel;
using AppenderService;

namespace AppenderService
{
    [ServiceContract(Namespace = "Service", Name = "AppenderService")]
    public interface IApprendaService
    {
        [OperationContract]
        DataTransferObject SomeMethod(DataTransferObject data);

        /// <summary>
        /// Echo some stuff as a test
        /// </summary>
        [OperationContract]
        string Echo(string input);
    }
}
