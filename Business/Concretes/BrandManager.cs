using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Response;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreateBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            Brand brand = new();
            brand.Name= createBrandRequest.Name;
            _brandDal.Add(brand);

            //mapping
            CreateBrandResponse createBrandResponse =new CreateBrandResponse();
            createBrandResponse.Name= brand.Name;
            createBrandResponse.Id = 4;
            createBrandResponse.CreatedDate = brand.CreatedDate;

            return createBrandResponse;

        }

        public List<GetAllBrandResponse> GetAll()
        {
            List < Brand > brands= _brandDal.GetAll();
            List<GetAllBrandResponse> getAllBrandResponses=new List<GetAllBrandResponse> ();

            foreach (var brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name= brand.Name;
                getAllBrandResponse.Id = brand.Id;  getAllBrandResponse.CreatedDate = brand.CreatedDate;
                getAllBrandResponses.Add(getAllBrandResponse);
            }
            return getAllBrandResponses;
        }
    }
}
