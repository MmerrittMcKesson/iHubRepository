using System.Runtime.Serialization;

namespace root.Contracts
{
    [DataContract(Namespace = "AppenderService", Name = "DataTransfer")]
    public class DataTransferObject
    {
        public DataTransferObject()
        {
        }

        [DataMember]
        public int Result { get; set; }
    }
}
