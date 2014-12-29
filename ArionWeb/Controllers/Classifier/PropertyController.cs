using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Services.BaseService;

namespace ArionWeb.Controllers.Classifier
{
    public class PropertyController : ApiController
    {
        private IClassifierService<Property> m_ClassifierService;

        public PropertyController()
        {
        }

        public PropertyController(IClassifierService<Property> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Property> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Property> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
