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
    public class PositionController : ApiController
    {
        private IClassifierService<Position> m_ClassifierService;

        public PositionController()
        {
        }

        public PositionController(IClassifierService<Position> classifierService)
        {
            m_ClassifierService = classifierService;
        }

        public IEnumerable<Position> Get([FromUri] int[] id)
        {
            return m_ClassifierService.Get(id);
        }

        public IEnumerable<Position> GetAll()
        {
            return m_ClassifierService.Get();
        }
    }
}
