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
    public class DataObjectCollection : CollectionBase
    {
        private static JsonSerializerSettings _setting;

        static DataObjectCollection()
        {
            _setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                ContractResolver = new DefaultContractResolver
                {
                    IgnoreSerializableAttribute = false
                }
            };
        }

        public DataObjectCollection() : base()
        {
        }

        public DataObjectCollection(int capacity) : base(capacity)
        {
        }

        public void Add(object item) => List.Add(item);

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

        //[OnSerializing()]
        //private void OnSerializingMethod(StreamingContext context)
        //{
        //}

        //[OnSerialized()]
        //private void OnSerializedMethod(StreamingContext context)
        //{
        //}

        //[OnDeserializing()]
        //private void OnDeserializingMethod(StreamingContext context)
        //{
        //}

        //[OnDeserialized()]
        //private void OnDeserializedMethod(StreamingContext context)
        //{
        //    var casted = new ArrayList();
        //    foreach (JObject item in List)
        //    {
        //        var obj = JsonConvert.DeserializeObject<DataObject>(item.ToString(), _setting);
        //        //var obj = item.ToObject<DataObject>();
        //        casted.Add(obj);
        //    }
        //    List.Clear();
        //    foreach (var item in casted)
        //    {
        //        List.Add(item);
        //    }
        //}
    }


    
}
