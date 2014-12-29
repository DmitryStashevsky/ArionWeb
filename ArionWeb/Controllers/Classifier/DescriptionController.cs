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
    public class DescriptionController : ApiController
    {
        private IClassifierService<Description> m_ClassifierService;

        public DescriptionController()
        {
        }

        public DescriptionController(IClassifierService<Description> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Description> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Description> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
