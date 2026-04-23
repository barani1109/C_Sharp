using CodeChallenge4.Abstracts;
using CodeChallenge4.BL;
using CodeChallenge4.Concrete;
using Unity;

namespace CodeChallenge4
{
    static class UnityResolver
    {
        public static DistanceBL DIInjector()
        {
            UnityContainer uc = new UnityContainer();  

            uc.RegisterType<IDistance, DistanceClass>();

            DistanceBL bl = uc.Resolve<DistanceBL>();

            return bl;
        }
    }
}