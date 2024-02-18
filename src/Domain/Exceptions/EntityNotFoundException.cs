namespace DongPhuong.Domain.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException() : base("Your requested Entity was not found.")
    {
    }

    public EntityNotFoundException(string message) : base(message)
    {
    }

    public EntityNotFoundException(string message, Exception innerException) :
        base(message, innerException)
    {
    }
}