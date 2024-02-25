using Business.Dtos.Request;
using Business.Dtos.Response;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreateBrandResponse Add(CreateBrandRequest createBrandRequest);
        List<GetAllBrandResponse> GetAll();
    }
 //   respponse and request yenıtlar ve istekler
}
