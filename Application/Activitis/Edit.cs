using MediatR;
using Domin;
using Persistent;
using AutoMapper;

namespace Application.Activitis
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activiti activiti { get; set; }
        }

        public class Handle : IRequestHandler<Command>
        {
            private readonly DataContext _Context;
            private readonly IMapper _mapper;
            public Handle(DataContext Context, IMapper mapper)
            {
                _mapper = mapper;
                _Context = Context;
            }

            async Task<Unit> IRequestHandler<Command, Unit>.Handle(Command request, CancellationToken cancellationToken)
            {
                var activiti = await _Context.Activities.FindAsync(request.activiti.Id);
                _mapper.Map(request.activiti,activiti);
                await _Context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}