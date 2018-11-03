using BoardGameGallery.Models;

namespace BoardGameGallery.Data
{
    public class BoardGameRepository
    {
        private BoardGame[] _boardGames = new BoardGame[]
        {
            new BoardGame
            {
                Id = 1,
                Title = "Arkham Horror 3rd Edition",
                ProductNumber = "FFGAHB01",
                RegPrice = 64.95,
                SpecialPrice = 54.99,
                DescriptionHtml = "<p>Massachusetts. 1926. Too long has the city of Arkham lived on its placid island of ignorance in the midst of the black seas of infinity. Only a small handful of unlucky investigators dare plunge into that abyss to struggle against the ancient evils that threaten reality from every corner of this New England town.</p><p>Arkham Horror is a cooperative game of mystery and terror for up to six players.Inspired by the writings of H.P.Lovecraft, each unique scenario puts you in the shoes of one of Arkham's investigators as they explore the streets of the city and work together to save humanity from unknowable horrors.</p>",
                Contents = new string[]{
                "5 Map Tiles",
                "7 Streets",
                "12 Investigators",
                "4 Scenarios",
                "469 Cards",
                "1 Deck Holder",
                "6 Dice",
                "265 Tokens" },
                NewArrival = true,
                Manufacturer = new Manufacturer { Name = "Fantasy Flight Games", Abbrev = "ffg" }
            },
            new BoardGame
            {
                Id = 2,
                Title = "Axis & Allies & Zombies",
                ProductNumber = "AVHC5010",
                RegPrice = 40.00,
                SpecialPrice = 28.00,
                DescriptionHtml = "<p>It is 1941, and the world is at war. The Axis war machine is crushing everything in its path, while the Allies are rallying together to mount a heroic stand. And then the zombies show up.</p><p>As the commander of one of the five major powers, you are charged with planning a strategy to win the war. But none of your military handbooks mention how to deal with zombies. Now each battle provides more fresh corpses for the flesh-eating hordes, and the problem is getting out of hand. With your human enemies on one side, and the ravenous undead on the other, it is time to ask yourself, \"Do I invest in tanks or chainsaw tanks?\"</p>Stand firm, commander. It's tough choices like this that will determine victory or undeath.</p>",
                Contents = new string[]{
                "1 Game Board",
                "1 Battle Board",
                "5 National Setup Charts",
                "70 National Control Markers",
                "12 Custom Six-sided Combat Dice",
                "6 Custom Six-sided Zombie Dice",
                "50 Plastic Unit Stacking Counters",
                "215 Plastic Miniatures (including 30 All-new Zombie Figures)",
                "60 Cards",
                "Paper Money",
                "Rulebook (including Quick Start Rules)",
                "Introductory Scenario" },
                NewArrival = true,
                Manufacturer = new Manufacturer { Name = "Avalon Hill", Abbrev = "ah" }
            },
            new BoardGame
            {
                Id =3,
                Title = "Discover: Lands Unknown",
                ProductNumber = "FFGDSC01",
                RegPrice = 59.95,
                SpecialPrice = 47.99,
                DescriptionHtml = "<p>You awaken with a splitting headache and no idea of how you got here. The wilderness stretches in every direction, and something howls in the distance. Your quest for answers will have to wait; first, you need to survive. Will you help the others that are stranded here or will you save yourself at any cost?</p><p>Every copy of Discover: Lands Unknown is unlike any other in the world. A mix of environments, storylines, characters, locations, items, and enemies have bene engineered to tell a story unique to this copy of the game. What unknown secrets lie within?</p><ul><li>Explore two environments, of a possible six, each with unique secrets to uncover.</li>Play as 12 characters, of a possible 36, each with different strengths and abilities.<li></li><li>A wide range of different items sets, enemies, and storyline combine to make your copy unique.</li>",
                Contents = new string[]{
                "34 Map Tiles",
                "4 Survivor Tokens",
                "2 Terrain Reference Sheets",
                "254 Cards",
                "242 Tokens" },
                NewArrival = true,
                Manufacturer = new Manufacturer { Name = "Fantasy Flight Games", Abbrev = "ffg" }
            }
        };

        public BoardGame GetBoardGame(int id)
        {
            BoardGame _foundGame = null;
            foreach(var game in _boardGames)
            {
                if(game.Id == id)
                {
                    _foundGame = game;
                }
            }
            return _foundGame;
        }
    }
}
