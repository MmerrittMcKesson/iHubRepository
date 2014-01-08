using System.Runtime.Serialization;

namespace AppenderService
{
    [DataContract(Namespace = "Service", Name = "DataTransfer")]
    public class DataTransferObject
    {
        [DataMember]
        public int Result { get; set; }
    }
}
