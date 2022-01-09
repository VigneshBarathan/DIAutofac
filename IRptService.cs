using System.Data;

namespace DIAutofac
{
    public interface IRptService
    {
        DataSet Write(string con, string sp);
    }
}
