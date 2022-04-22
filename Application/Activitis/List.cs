using System.Diagnostics;
using MediatR;
using Persistent;
using Domin;
using Microsoft.EntityFrameworkCore;

namespace Application.Activitis
{
    public class List
    {
        public class Query : IRequest<List<Activiti>>
        {

        }


        public class Handler : IRequestHandler<Query, List<Activiti>>
        {
            DataContext _context;
            public Handler(DataContext context)
            {
                _context=context;
            }
            public async Task<List<Activiti>> Handle(Query request, CancellationToken cancellationToken)
            {
               return await _context.Activities.ToListAsync();
            }
        }
    }
}