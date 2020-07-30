using System.Threading.Tasks;

namespace BasicAzureTest.Interfaces {
    public interface IBusinessLayer
    {
        Task<string> GetGirlName(int x);
    }
}
