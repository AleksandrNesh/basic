using DevQuestions.Domain.Questions;

namespace DevQuestions.Domain.Comments;

public class Comment
{
   public Guid Id { get; set; } 
   public required Guid UserId { get; set; }
   public Comment? Parent { get; set; }
   public required Guid EntityId { get; set; } // сущность для которой оставили комментарий
   //public string EntityType { get; set; } // тип сущности под которой оставили коммент
   public List<Comment> Children { get; set; } = []; 
   
}