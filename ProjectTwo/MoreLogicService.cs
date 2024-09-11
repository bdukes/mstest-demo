using Project.One;

namespace Project.Two;

public partial class MoreLogicService(BusinessLogicService logicService)
{
    public string DoThings(int number)
    {
        var value = logicService.GetBusinessLogicCount(new string('*', number));
        return new string('*', value);
    }
}