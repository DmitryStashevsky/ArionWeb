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
    public class KeyController : ApiController
    {
        private IClassifierService<Key> m_ClassifierService;

        public KeyController()
        {
        }

        public KeyController(IClassifierService<Key> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Key> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Key> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
