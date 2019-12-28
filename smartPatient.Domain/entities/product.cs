using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartPatient.Domain.entities
{
   public class product
    {

        public int patientId { get; set; }
        public string Name { get; set; }
        public string desciption { get; set; }
        public string speciality { get; set; }
        public double fee { get; set; }

    }
}
