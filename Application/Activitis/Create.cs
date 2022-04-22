using Domin;
using MediatR;
using Persistent;

namespace Application.Activitis
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activiti activiti { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _Context;
            public Handler(DataContext Context)
            {
               _Context = Context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _Context.Activities.Add(request.activiti);
                await _Context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}