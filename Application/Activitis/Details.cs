using Domin;
using MediatR;
using Persistent;

namespace Application.Activitis
{
    public class Details
    {
        public class Query : IRequest<Activiti>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activiti>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Activiti> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.FindAsync(request.Id);
            }
        }
    }
}