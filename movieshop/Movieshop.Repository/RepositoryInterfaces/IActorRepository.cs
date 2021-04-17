namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IActorRepository
    {
        void AddActor(Actor actor);
        void EditActor(Actor actor);
        void DeleteActor(int actorId);
        Actor GetActorById(int id);
        IEnumerable<Actor> GetAllActors();
    }
}
