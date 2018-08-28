using LDSFormsApp.Data;
using LDSFormsApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSFormsApp.Web.Controllers
{

    [Route("api/AgendaItems")]
    public class AgendaItemsController : Controller
    {
        private readonly IAgendaItemRepository _agendaItemRepository;

        public AgendaItemsController(IAgendaItemRepository agendaItemRepository)
        {
            _agendaItemRepository = agendaItemRepository;
        }

        [HttpGet]
        public IEnumerable<AgendaItem> Get()
        {
            return _agendaItemRepository.GetAll();
        }

        [HttpPost]
        public AgendaItem Post([FromBody] AgendaItem entity)
        {
            return _agendaItemRepository.Add(entity);
        }
    }
}
