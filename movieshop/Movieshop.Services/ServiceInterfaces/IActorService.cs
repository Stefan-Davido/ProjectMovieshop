namespace Movieshop.Services.ServiceInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IActorService
    {
        void Add(Actor actor);
        void Edit(Actor actor);
        void Delete(int actorId);
        Actor GetActorById(int id);
        IEnumerable<Actor> GetAllActors();
    }
}
