using LDSFormsApp.Data;
using LDSFormsApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDSFormsApp.Web.Controllers
{
    [Route("api/Meetings")]
    public class MeetingsController : Controller
    {
        private readonly IMeetingRepository _meetingRepository;

        public MeetingsController(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }

        [HttpGet]
        public IEnumerable<Meeting> Get()
        {
            return _meetingRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Meeting Get(int id)
        {
            return _meetingRepository.Get(id);
        }

        [HttpPost]
        public Meeting Post([FromBody] Meeting entity)
        {
            return _meetingRepository.Add(entity);
        }
    }
}
