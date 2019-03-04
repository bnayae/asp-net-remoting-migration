using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;

namespace Client
{
    internal static class RestHelper
    {
        public static readonly JsonMediaTypeFormatter DefaultFormatter;
        public static readonly MediaTypeFormatter[] DefaultFormatters;
        static RestHelper()
        {
            DefaultFormatter = new JsonMediaTypeFormatter();
            DefaultFormatters = new MediaTypeFormatter[]
                                    {
                                        DefaultFormatter,
                                        new JsonMediaTypeFormatter()
                                    };
            DefaultFormatter.SerializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                ContractResolver = new DefaultContractResolver
                {
                    IgnoreSerializableAttribute = false
                }
            };
        }

        public static readonly HttpClient Proxy = new HttpClient { Timeout = Debugger.IsAttached ? TimeSpan.FromMinutes(10) : TimeSpan.FromSeconds(30) };
    }


}
