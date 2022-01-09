using System.Data;

namespace DIAutofac
{
    public interface IRptRepository
    {
        DataSet Writedata(string con, string sp);
    }
}
