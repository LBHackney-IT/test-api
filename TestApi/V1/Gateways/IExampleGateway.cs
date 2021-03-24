using System.Collections.Generic;
using TestApi.V1.Domain;

namespace TestApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
