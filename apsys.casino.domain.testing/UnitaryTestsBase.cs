using Ninject;
using Ninject.MockingKernel.Moq;
using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    public class UnitaryTestsBase<T> where T : ITesteable
    {
        private MoqMockingKernel _moqMockingKernel;
        internal T ClassUnderTest {get; set;}
        
        /// <summary>
        /// Costructor
        /// </summary>
        public UnitaryTestsBase()
        {
            _moqMockingKernel = new MoqMockingKernel();
        }

        [SetUp]
        public void SetUp()
        {
            ClassUnderTest = _moqMockingKernel.Get<T>();
            ClassUnderTest.SetMockData();
        }
    }
}
