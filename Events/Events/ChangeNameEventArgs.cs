using System;

namespace Events
{
    public class ChangeNameEventArgs : EventArgs
    {
        public string ExistsName { get; set; }
        public string NewName { get; set; }
    }
}
