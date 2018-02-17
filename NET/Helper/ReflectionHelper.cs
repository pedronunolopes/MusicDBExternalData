using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssMusicDBExternalData.Helper
{
    internal class ReflectionHelper
    {
        /// <summary>
        /// Creates object instance
        /// </summary>
        /// <param name="typeOfInstance"></param>
        /// <returns></returns>
        public static object CreateInstance(Type typeOfInstance)
        {
            return Activator.CreateInstance(typeOfInstance, true);
        }

        public static object ExecuteMethod(object instance, string methodToExecute, object[] methodParameters)
        {
            object result = null;
            Type type = instance.GetType();
            MethodInfo method = type.GetMethod(methodToExecute);

            result = method.Invoke(instance, methodParameters );

            return result;
        }

        public static object ExecuteMethod(object instance, string methodToExecute)
        {
            return ExecuteMethod(instance, methodToExecute, null);
        }
    }
}
