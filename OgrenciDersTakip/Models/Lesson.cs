using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciDersTakip.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HourPerWeek { get; set; }
        public List<User> Users { get; set; }
    }
}