namespace FreeBNS.Model
{
    public class Kill
    {
        public string KillKey { get; set; }
        public int KillKeyDownTime { get; set; }
        public int KillKeyUpTime { get; set; }
        public int KillTime { get; set; }

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
