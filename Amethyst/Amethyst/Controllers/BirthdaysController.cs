using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Amethyst.Domain.Classes;
using Amethyst.Mappers;
using Amethyst.Models;
using Amethyst.Repositories.Classes;
using Amethyst.Services.Classes;
using Amethyst.Services.Interfaces;

namespace Amethyst.Controllers
{
    //[Authorize]
    [RoutePrefix("api/Birthdays")]
    public class BirthdaysController : ApiController
    {
        private readonly IBirthdaysService _myService;

        public BirthdaysController():this(new BirthdaysService(new GenericRepository<Birthday>(new BirthdaysDbContext())))
        {

        }

        public BirthdaysController(IBirthdaysService myService)
        {
            _myService = myService;
        }

        // GET api/values
        [Route("Get")]
        public List<BirthdayModel> Get()
        {
            return BirthdaysMapper.MapToBirthdayModel(_myService.GetAllMyEntities().ToList());
        }

        [Route("GetByName")]
        public List<BirthdayModel> GetByName(string name)
        {
            return BirthdaysMapper.MapToBirthdayModel(_myService.GetMyEntities(bd => bd.Name.Contains(name.Trim())).ToList());
        }

        [Route("GetByBirthDate")]
        public List<BirthdayModel> GetByBirthdate(string date)
        {
            var birthDate = Convert.ToDateTime(date).ToString("yyyy-mm-dd");
            return BirthdaysMapper.MapToBirthdayModel(_myService.GetMyEntities(bd => bd.Birthdate.ToString("yyyy-mm-dd").Equals(birthDate, StringComparison.InvariantCultureIgnoreCase)).ToList());
        }

        // GET api/values/5
        [Route("GetById")]
        public List<BirthdayModel> GetById(int id)
        {
            return BirthdaysMapper.MapToBirthdayModel(_myService.GetMyEntities(bd => bd.Id == id).ToList());
        }

        // POST api/values
        [Route("Create")]
        public void Post([FromBody]BirthdayModel birthDay)
        {
            birthDay.Id = 0;
            _myService.CreateMyEntity(BirthdaysMapper.MapToBirthday(birthDay));
        }

        // PUT api/values/5
        [Route("Update")]
        public void Put(int id, [FromBody]BirthdayModel birthdayModel)
        {
            Birthday birthDay = _myService.GetMyEntities(bd => bd.Id == id).FirstOrDefault();

            if (birthDay != null)
            {
                birthDay.Birthdate = !string.IsNullOrWhiteSpace(birthdayModel.Birthdate.ToString("yyyy-mm-dd")) ? birthdayModel.Birthdate : birthDay.Birthdate;
                birthDay.Name = !string.IsNullOrWhiteSpace(birthdayModel.Name) ? birthdayModel.Name : birthDay.Name;
                _myService.UpdateMyEntity(birthDay);
            }
        }

        // DELETE api/values/5
        [Route("Delete")]
        public void Delete(int id)
        {
            Birthday birthday = _myService.GetMyEntities(bd => bd.Id == id).FirstOrDefault();
            if (birthday != null)
                _myService.DeleteMyEntity(birthday);
        }
    }
}
