﻿using System;
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
    public class DataObjectCollection : CollectionBase
    {
        public void Add(DataObject item) => List.Add(item);

        public DataObject this[int index]
        {
            get
            {
                return List[index] as DataObject;
            }
            set
            {
                List[index] = value;
            }
        }
    }    
}
