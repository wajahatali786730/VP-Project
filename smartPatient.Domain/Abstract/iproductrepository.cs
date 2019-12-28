using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartPatient.Domain.entities;

namespace smartPatient.Domain.Abstract
{
   public interface iproductrepository
{
        IEnumerable<product> products { get; }
}

}
