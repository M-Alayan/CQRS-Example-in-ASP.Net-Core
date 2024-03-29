﻿using CQRSExample.Domain.Entities;

namespace CQRSExample.Application.Movies.Commands.CreateMovie
{
    public static class CreateUserCommandExtension
    {
        public static Movie CreateMovie(this CreateMovieCommand command)
        {
            var movie = new Movie
                (
                    command.Title,
                    command.Description,
                    command.Genre,
                    command.Rating
                );

            return movie;
        }
    }
}
