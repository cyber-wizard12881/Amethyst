using System;
using Amethyst.Domain.Interfaces;

namespace Amethyst.Domain.Classes
{
    public class Birthday : IBirthday
    {
        public int Id { get; set; }
        public DateTime Birthdate { get; set; }
        public string Name { get; set; }
    }
}