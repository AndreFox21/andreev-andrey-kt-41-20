using AndreevAndreyKT_41_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreevAndreyKT_41_20.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT4120_True()
        {
            var testGroup = new AcademGroup
            {
                AcademGroupId = 1,
                GroupName = "KT-41-20",
                GroupDescription = "Факультет ИВТ"
            };

            var result = testGroup.IsValidGroupName();

            Assert.True(result);

        }
    }
}
