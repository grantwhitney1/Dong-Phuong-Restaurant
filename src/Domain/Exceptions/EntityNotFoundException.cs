namespace DongPhuong.Domain.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException() : base (message: "Your requested Entity was not found.")
    {
        
    }
    
    public EntityNotFoundException(string message) : base(message: message)
    {
        
    }

    public EntityNotFoundException(string message, Exception innerException) : 
        base(message: message, innerException: innerException)
    {
        
    }
}