using System.ServiceModel;

namespace root.Contracts
{
    [ServiceContract(Namespace = "AppenderService", Name = "ApprendaService")]
    public interface IApprendaService
    {
        [OperationContract]
        DataTransferObject SomeMethod(DataTransferObject data);

        /// <summary>
        /// Echo some stuff back
        /// </summary>
        [OperationContract]
        string Echo(string input);
    }
}
