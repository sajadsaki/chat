using MediatR;
using Persistent;

namespace Application.Activitis
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid id { get; set; }

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
                var activiti =await _Context.Activities.FindAsync(request.id);
                _Context.Remove(activiti);
                await _Context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}