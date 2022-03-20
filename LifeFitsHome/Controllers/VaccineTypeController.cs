using LifeFitsHome.Model.Entity;
using LifeFitsHome.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeFitsHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineTypeController : GenericBaseController<VaccineType, IVaccineTypeService>
    {
        public VaccineTypeController(IVaccineTypeService vaccineTypeService) : base(vaccineTypeService)
        {
        }

        [HttpPost]
        public IActionResult AddVaccineType(VaccineType vaccineType)
        {
            return base.GetResponseByResultSuccess(base._service.Add(vaccineType));
        }

        [HttpGet("getbyname")]
        public IActionResult GetVaccineTypeByName(string name)
        {
            return base.GetResponseByResultSuccess(base._service.GetVaccineTypeByName(name));
        }
        [HttpGet("getbyid")]
        public IActionResult GetVaccineTypeById(int id)
        {
            return base.GetResponseByResultSuccess(base._service.GetVaccineTypeById(id));
        }
        [HttpDelete]
        public IActionResult DeleteVaccineType(VaccineType vaccineType){
            return base.GetResponseByResultSuccess(base._service.Delete(vaccineType));
        }
        [HttpPut]
        public IActionResult UpdateVaccineType(VaccineType vaccineType){
            return base.GetResponseByResultSuccess(base._service.Update(vaccineType));
        }
    }
}
