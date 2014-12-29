using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Models;
using Services.BaseService;

namespace ArionWeb.Controllers.Classifier
{
    public class CoefficientController : ApiController
    {
        private IClassifierService<Coefficient> m_ClassifierService;

        public CoefficientController()
        {
        }

        public CoefficientController(IClassifierService<Coefficient> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Coefficient> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Coefficient> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}