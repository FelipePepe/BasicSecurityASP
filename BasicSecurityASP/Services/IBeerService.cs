using BasicSecurityASP.Model;

namespace BasicSecurityASP.Services
{
    public interface IBeerService
    {
        public Task<IEnumerable<Beer>> Get();
    }
}
