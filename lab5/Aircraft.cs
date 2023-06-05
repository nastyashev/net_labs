using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    // Абстрактний клас для літаків
    abstract class Aircraft
    {
        protected readonly IMediator mediator;

        public Aircraft(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void RequestLanding();
        public abstract void RequestTakeoff();
    }

    // Конкретний клас для літаків
    class ConcreteAircraft : Aircraft
    {
        public ConcreteAircraft(IMediator mediator) : base(mediator)
        {
        }

        public override void RequestLanding()
        {
            mediator.Land(this);
        }

        public override void RequestTakeoff()
        {
            mediator.Takeoff(this);
        }

        public void RunwayCleared()
        {
            Console.WriteLine("Runway cleared for takeoff.");
        }

        public void ReadyForLanding()
        {
            Console.WriteLine("Ready for landing.");
        }
    }
}
