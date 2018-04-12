using SimpleTaskSystem.EntityFrameworkCore;

namespace SimpleTaskSystem.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SimpleTaskSystemDbContext _context;

        public TestDataBuilder(SimpleTaskSystemDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}