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
    public class ElementClassController : ApiController
    {
        private IClassifierService<ElementClass> m_ClassifierService;

        public ElementClassController()
        {
        }

        public ElementClassController(IClassifierService<ElementClass> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<ElementClass> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<ElementClass> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
