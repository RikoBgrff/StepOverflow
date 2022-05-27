using System;

namespace StepOverflow.Entities
{
    public class Message : IEntity
    {
        public int Id { get; set; }//message id
        public DateTime? CreatedTime { get; set; }//message sent datetime
        public int ToId { get; set; }//who recieves
        public int FromId { get; set; }//who sent
        public object MessageObject { get; set; } //this property was created as an object because message can also be a text,image,voice or smth.


    }
}
