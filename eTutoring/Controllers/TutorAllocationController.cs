﻿using eTutoring.Models.DTO.FormModels;
using eTutoring.Repositories;
using System.Threading.Tasks;
using System.Web.Http;

namespace eTutoring.Controllers
{
    [RoutePrefix("api/allocation")]
    public class TutorAllocationController : ApiController
    {
        private readonly TutorAllocationRepository _repo = new TutorAllocationRepository();

        [Route("add")]
        [HttpPost]
        public async Task<IHttpActionResult> AddAllocation(TutorAllocationFormModel form)
        {
            await _repo.AllocateTutorToStudents(form.TutorId, form.StudentIds);
            var response = new
            {
                message = "Allocation completed"
            };
            return Ok(response);
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IHttpActionResult> RemoveAllocation(StudentDeallocationFormModel form)
        {
            await _repo.DeallocateStudents(form.StudentIds);
            var response = new
            {
                message = "Deallocation completed"
            };
            return Ok(response);
        }

        [Route("view")]
        [HttpGet]
        public IHttpActionResult VeryCool()
        {
            var result = _repo.RetrieveAllAllocations();
            return Ok(result);
        }
    }
}
