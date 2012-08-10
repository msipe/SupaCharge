using NUnit.Framework;
using SupaCharge.Core.Collections.Extensions;
using SupaCharge.Testing;

namespace SupaCharge.UnitTests.Core.Collections.Extensions {
  [TestFixture]
  public class ElementsAtTestcs : BaseTestCase {
    [Test]
    public void TestElementsAt() {
      var ary = new[] {"a", "b", "c"};

      Assert.That(ary.ElementsAt(), Is.EqualTo(new string[0]));
      Assert.That(ary.ElementsAt(0), Is.EqualTo(new[] {"a"}));
      Assert.That(ary.ElementsAt(0, 1), Is.EqualTo(new[] {"a", "b"}));
      Assert.That(ary.ElementsAt(0, 1, 2), Is.EqualTo(new[] {"a", "b", "c"}));
      Assert.That(ary.ElementsAt(0, 1, 0), Is.EqualTo(new[] {"a", "b", "a"}));
      Assert.That(ary.ElementsAt(0, 1, 0, 0, 1, 0, 1), Is.EqualTo(new[] {"a", "b", "a", "a", "b", "a", "b"}));
    }
  }
}