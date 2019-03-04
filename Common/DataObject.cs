using System;

namespace Common
{
    [Serializable]
    public class DataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Name}: {Id}";
    }
}