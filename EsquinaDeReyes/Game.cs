using System.Collections.Generic;

namespace EsquinaDeReyes
{
    public class Game
    {
        private IList<string> _playerNames;

        public IList<string> Players
        {
            get
            {
                return _playerNames;
            }
        }

        public void SetupPlayers(params string[] playerNames)
        {
            _playerNames = new List<string>();

            foreach(string player in playerNames)
            {
                _playerNames.Add(player);
            }
        }


    }
}
