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
    public class ElementGroupController : ApiController
    {
        private IClassifierService<ElementGroup> m_ClassifierService;

        public ElementGroupController()
        {
        }

        public ElementGroupController(IClassifierService<ElementGroup> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<ElementGroup> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<ElementGroup> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
