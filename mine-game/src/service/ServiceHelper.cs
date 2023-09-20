using mine_game.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mine_game.src.service
{
    class ServiceHelper
    {
        private Dictionary<String, BaseServiceInterface> serviceMap = new Dictionary<String, BaseServiceInterface>();

        private static ServiceHelper serviceHelper;

        public static ServiceHelper Instance()
        {
            if (serviceHelper == null)
            {
                serviceHelper = new ServiceHelper();
            }
            return serviceHelper;
        }

        private ServiceHelper()
        {
            // 实例化类并加载
            var serviceList = ReflectionUtil.getInstance<BaseServiceInterface>();
            serviceList.ForEach(serviceInterface => serviceMap.Add(serviceInterface.GetType().Name, serviceInterface));
        }

        public T getInstance<T>(Type t) where T : BaseServiceInterface
        {
            return (T)serviceMap[t.Name];
        }
    }
}
