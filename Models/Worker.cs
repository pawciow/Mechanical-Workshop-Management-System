using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mechanical_Workshop_Management_System.Models
{
    public class Worker
    {
        public string Name { set; get; }
        public Specialization Speciality { get; set; }
        public enum Specialization
        {
            Mechanic, // mechanik
            Car_tinsmith, // blacharz samochodowy
            car_painter // lakiernik
        }
    }
}
