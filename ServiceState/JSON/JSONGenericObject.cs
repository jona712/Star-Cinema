using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class JSONGenericObject<T>
    {
        public static T JSonToObject(string pDatos)
        {

            T @object = (T)JsonConvert.DeserializeObject<T>(pDatos);

            return @object;

        }


    }

