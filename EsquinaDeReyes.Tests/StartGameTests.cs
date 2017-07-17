using NUnit.Framework;

namespace EsquinaDeReyes.Tests
{
    [TestFixture]
    public class StartGameTests
    {
        [Test]
        public void SetInitialPlayers()
        {
            var g = new Game();

            g.SetupPlayers("Luis", "Rossy", "Fer");

            CollectionAssert.Contains(g.Players, "Luis");
            CollectionAssert.Contains(g.Players, "Rossy");
            CollectionAssert.Contains(g.Players, "Fer");
        }
    }
}
