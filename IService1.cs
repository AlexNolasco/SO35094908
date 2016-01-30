using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace PUendelig
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        Activity AddActivity(Activity activity);
    }


    [DataContract]
    public class Activity
    {
        [DataMember]
        public String Status
        {
            get; set;
        }

        [DataMember]
        public String Name
        {
            get; set;
        }
    }
}
