namespace Movieshop.Services
{
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void Add(Actor actor)
        {
            _actorRepository.AddActor(actor);
        }

        public void Delete(int actorId)
        {
            _actorRepository.DeleteActor(actorId);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.EditActor(actor);
        }

        public Actor GetActorById(int id)
        {
            var result = _actorRepository.GetActorById(id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _actorRepository.GetAllActors();
            return result;
        }
    }
}
