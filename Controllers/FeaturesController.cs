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
    public class FeaturesController: Controller
    {
        private readonly VegaContext _context;
        private readonly IMapper _mapper;
        public FeaturesController(VegaContext context, IMapper mapper)
        {
            _context = context;        
            _mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures(){
            var features = await _context.Features.ToListAsync();
            return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }        
    }
}