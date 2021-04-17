namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _dataContext;

        public ActorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddActor(Actor actor)
        {
            _dataContext.Actor.Add(actor);
            _dataContext.SaveChanges();
        }

        public void DeleteActor(int actorId)
        {
            Actor actor = GetActorById(actorId);
            _dataContext.Actor.Remove(actor);
            _dataContext.SaveChanges();
        }

        public void EditActor(Actor actor)
        {
            _dataContext.Actor.Update(actor);
            _dataContext.SaveChanges();
        }

        public Actor GetActorById(int id)
        {
            var result = _dataContext.Actor.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _dataContext.Actor.AsEnumerable();
            return result;
        }
    }
}
