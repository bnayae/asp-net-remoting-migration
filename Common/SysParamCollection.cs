using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Common
{
    [Serializable]
    public class SysParamCollection : DataObjectCollection
    {
        public void Add(SysParam item) => List.Add(item);

        public SysParam this[int index]
        {
            get
            {
                return base[index] as SysParam;
            }
            set
            {
                base[index] = value;
            }
        }
    }
}
