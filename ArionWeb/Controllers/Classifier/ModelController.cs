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
    public class ModelController : ApiController
    {
        private IClassifierService<Model> m_ClassifierService;

        public ModelController()
        {
        }

        public ModelController(IClassifierService<Model> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Model> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Model> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
