using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CMMS3.Infrastructure;
using CMMS3.Models;
using CMMS3.Models.DTO;
using CMMS3.Models.DTO.CompanyDTO;

namespace CMMS3.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly IUnitOfWork<CmmsContext> _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CompaniesController(IUnitOfWork<CmmsContext> unitOfWork, ILoggerManager logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            var resultIndex = _unitOfWork.CompanyRep.GetAll(false);
            var result = _mapper.Map<IEnumerable<CompanyListDTO>>(resultIndex);

            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var resultFind = _unitOfWork.CompanyRep.GetById(id);
            if (resultFind == null)
                return NotFound();
            var result = _mapper.Map<CompanyListDTO>(resultFind);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,CompanyIndex,CompanyTitle,Description,IsActive")]
            CompanyListDTO model)
        {

        }
    }
}
