using System;
using System.Collections.Generic;
using System.Text;

namespace Movieshop.Entities.Logger
{
    public class LoggerMessagesDisplay
    {
        // Movie Messages
        public const string MoviesListed = "All Movies listed successfully!";
        public const string NoMoviesInDB = "There is no Movies in the DB!";
        public const string MovieFoundDisplayDetails = "Movie was found in the DB, show the details of the Movie";
        public const string NoMovieFound = "This is no Movie found in the DB!";
        public const string MovieCreated = "New Movie is created in the DB";
        public const string MovieNotCreatedModelStateInvalid = "New Movie is NOT created in the DB, ModelState is not valid";
        public const string MovieEdited = "Movie is edited successfully";
        public const string MovieEditNotFound = "Movie for editting is not found in the DB";
        public const string MovieEditErrorModelStateInvalid = "Movie is not edited, ModelState is not valid";
        public const string MovieDeleted = "Movie is deleted successfully";
        public const string MovieDeletedError = "Movie is NOT deleted, error happend in process of deletion";
        // Producer Messages
        public const string ProducersListed = "All Producers listed successfully!";
        public const string NoProducersInDB = "There is no Producers in the DB!";
        public const string ProducerFoundDisplayDetails = "Producer was found in the DB, show the details of the Producer";
        public const string NoProducerFound = "This is no Producer found in the DB!";
        public const string ProducerCreated = "New Producer is created in the DB";
        public const string ProducerNotCreatedModelStateInvalid = "New Producer is NOT created in the DB, ModelState is not valid";
        public const string ProducerEdited = "Producer is edited successfully";
        public const string ProducerEditNotFound = "Producer for editting is not found in the DB";
        public const string ProducerEditErrorModelStateInvalid = "Producer is not edited, ModelState is not valid";
        public const string ProducerDeleted = "Producer is deleted successfully";
        public const string ProducerDeletedError = "Producer is NOT deleted, error happend in process of deletion";
        // Actor Messages
        public const string ActorsListed = "All Actors listed successfully!";
        public const string NoActorsInDB = "There is no Actors in the DB!";
        public const string ActorFoundDisplayDetails = "Actor was found in the DB, show the details of the Actor";
        public const string NoActorFound = "This is no Actor found in the DB!";
        public const string ActorCreated = "New Actor is created in the DB";
        public const string ActorNotCreatedModelStateInvalid = "New Actor is NOT created in the DB, ModelState is not valid";
        public const string ActorEdited = "Actor is edited successfully";
        public const string ActorEditErrorModelStateInvalid = "Actor is not edited, ModelState is not valid";
        public const string ActorDeleted = "Actor is deleted successfully";
        public const string ActorDeletedError = "Actor is NOT deleted, error happend in process of deletion";
        // Production Messages
        public const string ProductionsListed = "All Productions listed successfully!";
        public const string NoProductionInDB = "There is no Production in the DB!";
        public const string ProductionFoundDisplayDetails = "Production was found in the DB, show the details of the Actor";
        public const string NoProductionFound = "This is no Production found in the DB!";
        public const string ProductionCreated = "New Production is created in the DB";
        public const string ProductionNotCreatedModelStateInvalid = "New Production is NOT created in the DB, ModelState is not valid";
        public const string ProductionEdited = "Production is edited successfully";
        public const string ProductionEditErrorModelStateInvalid = "Production is not edited, ModelState is not valid";
        public const string ProductionDeleted = "Production is deleted successfully";
        public const string ProductionDeletedError = "Production is NOT deleted, error happend in process of deletion";
        // Genre Messages
        public const string GenreListed = "All genres listed successfully!";
        public const string NoGenresInDB = "There is no genre in the DB!";
        public const string GenreFoundDisplayDetails = "Genre was found in the DB, show the details of the Genre";
        public const string NoGenreFound = "This is no Genre found in the DB!";
        public const string GenreCreated = "New Genre is created in the DB";
        public const string GenreNotCreatedModelStateInvalid = "New Genre is NOT created in the DB, ModelState is not valid";
        public const string GenreEdited = "Genre is edited successfully";
        public const string GenreEditErrorModelStateInvalid = "Genre is not edited, ModelState is not valid";
        public const string GenreDeleted = "Genre is deleted successfully";
        public const string GenreDeletedError = "Genre is NOT deleted, error happend in process of deletion";
        // Category Messages
        public const string CategoriesListed = "All categories listed successfully!";
        public const string NoCategoriesInDB = "There is no categories in the DB!";
        public const string CategoryFoundDisplayDetails = "Category was found in the DB, show the details of the category";
        public const string NoCategoryFound = "This is no category found in the DB!";
        public const string CategoryCreated = "New category is created in the DB";
        public const string CategoryNotCreatedModelStateInvalid = "New category is NOT created in the DB, ModelState is not valid";
        public const string CategoryEdited = "Category is edited successfully";
        public const string CategoryEditErrorModelStateInvalid = "Category is not edited, ModelState is not valid";
        public const string CategoryDeleted = "Category is deleted successfully";
        public const string CategoryDeletedError = "Category is NOT deleted, error happend in process of deletion";
        // Upload Photo Messages
        public const string PhotoUploaded = "Photo is successfully uploaded";
        public const string PhotoUploadedError = "Photo is NOT uploaded";
        public const string PhotosListed = "All photos listed successfully!";
        public const string NoPhotosInDB = "There is no photos in the DB!";
        public const string PhotoFoundDisplayDetails = "Photo was found in the DB, show the details of the photo";
        public const string NoPhotoFound = "This is no photo found in the DB!";
        public const string PhotoCreated = "New photo is created in the DB";
        public const string PhotoNotCreatedModelStateInvalid = "New photo is NOT created in the DB, ModelState is not valid";
        public const string PhotoEdited = "Photo is edited successfully";
        public const string PhotoEditErrorModelStateInvalid = "Photo is not edited, ModelState is not valid";
        public const string PhotoDeleted = "Photo is deleted successfully";
        public const string PhotoDeletedError = "Photo is NOT deleted, error happend in process of deletion";
        // User Messages
        public const string UsersListed = "All users listed successfully!";
        public const string NoUsersInDB = "There is no user in the DB!";
        public const string UserFoundDisplayDetails = "User was found in the DB, show the details of the user";
        public const string NoUserFound = "This is no user found in the DB!";
        public const string UserCreated = "New user is created in the DB";
        public const string UserNotCreatedModelStateInvalid = "New user is NOT created in the DB, ModelState is not valid";
        public const string UserEdited = "User is edited successfully";
        public const string UserEditErrorModelStateInvalid = "User is not edited, ModelState is not valid";
        public const string UserDeleted = "User is deleted successfully";
        public const string UserDeletedError = "User is NOT deleted, error happend in process of deletion";
    }
}
