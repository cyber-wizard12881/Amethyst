using System.Collections.Generic;
using Amethyst.Domain.Classes;
using Amethyst.Models;

namespace Amethyst.Mappers
{
    public static class BirthdaysMapper
    {
        public static List<BirthdayModel> MapToBirthdayModel(List<Birthday> domainList)
        {
            List<BirthdayModel> contractList = new List<BirthdayModel>();
            domainList.ForEach(dl =>
            {
                contractList.Add(new BirthdayModel
                {
                    Id = dl.Id,
                    Name = dl.Name,
                    Birthdate = dl.Birthdate
                });
            });
            return contractList;
        }

        public static Birthday MapToBirthday(BirthdayModel contractBirthday)
        {
            return new Birthday
            {
                Id = contractBirthday.Id,
                Name = contractBirthday.Name,
                Birthdate = contractBirthday.Birthdate
            };
        }
    }
}
