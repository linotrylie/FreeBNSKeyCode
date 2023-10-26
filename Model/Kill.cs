using System.Runtime.Serialization;

namespace FreeBNS.Model
{
    [DataContract]
    public class Kill
    {
        [DataMember]
        public string KillKey { get; set; }
        [DataMember]
        public int KillKeyDownTime { get; set; }
        [DataMember]
        public int KillKeyUpTime { get; set; }
        [DataMember]
        public int KillTime { get; set; }
        [DataMember]
        private int _KillLastUseTime = 0;
        public int KillLastUseTime
        {
            get
            {
                return this._KillLastUseTime;
            }
            set
            {
                this._KillLastUseTime = value;
            }
        }
    }
}
