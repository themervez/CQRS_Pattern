﻿namespace CQRS_Pattern.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery
    {
        public GetStudentByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
