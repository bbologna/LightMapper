using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LightMapper.Core;
using LigthMapper.Core.Tests.Fakes;

namespace LigthMapper.Core.Tests
{
    [TestClass]
    public class MapTest
    {
        [TestMethod]

            public void SimpleMapTest()
            {
                // Arrange
                var mappingBuilder = new MapResolver();
                mappingBuilder.RegisterMap(new FakePersonMapDefinition());

                // Act
                var result = mappingBuilder.Map<FakePersonEntity, FakePersonDto>(new FakePersonDto() { Name = "Bruno", LastName = "Bologna" });

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(FakePersonEntity));
                Assert.AreEqual("Bruno", result.Name);
                Assert.AreEqual("Bologna", result.LastName);
            }
        }
    }
}
