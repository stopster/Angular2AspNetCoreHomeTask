using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Vega.Data;
using Vega.Models;
using Vega.Controllers.Resources;

namespace Vega.Controllers
{
    public class MakesController: Controller
    {
        private readonly VegaContext _context;
        private readonly IMapper _mapper;

        public MakesController(VegaContext context, IMapper mapper)
        {
            _context = context;            
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes(){
            var makes = await _context.Makes.Include(m=>m.Models).ToListAsync();
            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}