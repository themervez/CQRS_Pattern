﻿using MediatR;

namespace CQRS_Pattern.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand : IRequest//for using mediatr
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
    }
}
