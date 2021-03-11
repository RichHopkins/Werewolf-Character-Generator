using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Character_Generator
{
    public class Werewolf
    {
        public string CharacterName;
        public string PlayerName;
        public string Chronicle;
        public string Breed;
        public string Auspice;
        public string Tribe;
        public string PackName;
        public string PackTotem;
        public string Concept;
        public int Strength;
        public int Dexterity;
        public int Stamina;
        public int Charisma;
        public int Manipulation;
        public int Appearance;
        public int Perception;
        public int Intelligence;
        public int Wits;

        public Werewolf() {
        }

        public Werewolf(string characterName, string playerName, string chronicle, string breed, string auspice, string tribe, string packName, string packTotem, string concept, int strength, int dexterity, int stamina, int charisma, int manipulation, int appearance, int perception, int intelligence, int wits) {
            CharacterName = characterName;
            PlayerName = playerName;
            Chronicle = chronicle;
            Breed = breed;
            Auspice = auspice;
            Tribe = tribe;
            PackName = packName;
            PackTotem = packTotem;
            Concept = concept;
            Strength = strength;
            Dexterity = dexterity;
            Stamina = stamina;
            Charisma = charisma;
            Manipulation = manipulation;
            Appearance = appearance;
            Perception = perception;
            Intelligence = intelligence;
            Wits = wits;
        }
    }
}
