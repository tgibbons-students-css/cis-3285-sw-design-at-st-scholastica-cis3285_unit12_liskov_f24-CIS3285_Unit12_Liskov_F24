namespace SubtypeCovariance;

class Program
{
    static void Main(string[] args)
    {

        EntityRepository entityRepository = new EntityRepository();
        Entity myEntity = entityRepository.GetByID(Guid.NewGuid());

        myEntity.Name = "Rylan";
        Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
        Console.WriteLine("New entity Name: " + myEntity.Name);

    }
}