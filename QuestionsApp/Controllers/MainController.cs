using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DbAccess3;


namespace QuestionsApp.Controllers
{
    //Get /lessons
    public class LessonsController : ApiController
    {
        public IEnumerable<lesson> GET()
        {
           using(Task3Entities entities = new Task3Entities())
          {
              return entities.lessons.ToList();
          }
        }
    }

    //Get /goals
    public class GoalsController : ApiController
    {
        public IEnumerable<goal> GET()
        {
            using (Task3Entities entities = new Task3Entities())
            {
                return entities.goals.ToList();
            }
        }
    }

    //Get /questions
    public class QuestionsController : ApiController
    {
        public IEnumerable<question> GET()
        {
            using (Task3Entities entities = new Task3Entities())
            {
                return entities.questions.ToList();
            }
        }
    }

    //Post postQuestions
    public class PostQuestionController : ApiController
    {
        //Gets the question parameter from the body
        public question POST([FromBody] question question)
        {
            using (Task3Entities entities = new Task3Entities())
            {
                //get the highest Id in the table + 1 => new insert ID (brute force method)
                var maxId = entities.questions.OrderByDescending(u => u.Id).FirstOrDefault();
                question.Id = maxId.Id + 1;
                entities.questions.Add(question);
                entities.SaveChanges();
                return question;
            }
        }
    }

}

