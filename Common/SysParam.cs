using System;

namespace Common
{

    [Serializable]
    public class SysParam : DataObject

    {
        public int Score { get; set; }

        public override string ToString() => $"{base.ToString()} = {Score}";
    }
}